import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { Post } from '../../models/post/post';
import { User } from '../../models/user';
import { MatSidenav } from '@angular/material/sidenav';
import { Reaction } from '../../models/reactions/reaction';
import { Subject } from 'rxjs';
import { MatSlideToggleChange } from '@angular/material/slide-toggle';
import { AuthenticationService } from '../../services/auth.service';
import { PostService } from '../../services/post.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { DialogType } from '../../models/common/auth-dialog-type';
import { EventService } from '../../services/event.service';
import { ImgurService } from '../../services/imgur.service';
import { NewPost } from '../../models/post/new-post';
import { switchMap, takeUntil, map } from 'rxjs/operators';
import { HubConnectionBuilder, HubConnection } from '@aspnet/signalr';
import { SnackBarService } from '../../services/snack-bar.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ToastrService } from 'ngx-toastr';
import { ScrollingModule, CdkVirtualScrollViewport } from '@angular/cdk/scrolling';




@Component({
    selector: 'app-main-thread',
    templateUrl: './main-thread.component.html',
    styleUrls: ['./main-thread.component.sass']
})
export class MainThreadComponent implements OnInit, OnDestroy {

    public posts: Post[] = [];
    public cachedPosts: Post[] = [];
    public isOnlyMine = false;
    public isOnlyMineLiked = false;
    public isCommonPosts = false;

    @ViewChild(CdkVirtualScrollViewport, { static: true }) viewport: CdkVirtualScrollViewport;
    @ViewChild('sidenav') sidenav: MatSidenav;

    public currentUser: User;
    public imageUrl: string;
    public imageFile: File;
    public post = {} as NewPost;
    public showPostContainer = false;
    public loading = false;
    public loadingPosts = false;

    public notifications: Reaction[] = [];
    public isNotificationsVisible: boolean = false;

    public postHub: HubConnection;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private toastr: ToastrService,
        private _snackBar: MatSnackBar,
        private snackBarService: SnackBarService,
        private authService: AuthenticationService,
        private postService: PostService,
        private imgurService: ImgurService,
        private authDialogService: AuthDialogService,
        private eventService: EventService
    ) { }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
        this.postHub.stop();
    }

    public ngOnInit() {
        this.registerHub();
        this.getPosts();
        this.getUser();

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe((user) => {
            this.currentUser = user;
            this.post.authorId = this.currentUser ? this.currentUser.id : undefined;
        });
    }

    public getPosts() {
        this.loadingPosts = true;
        this.postService
            .getPosts()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    this.loadingPosts = false;
                    this.posts = this.cachedPosts = resp.body.filter(post => post.isDeleted == false);
                },
                (error) => (this.loadingPosts = false)
            );
    }

    public sendPost() {
        const postSubscription = !this.imageFile
            ? this.postService.createPost(this.post)
            : this.imgurService.uploadToImgur(this.imageFile, 'title').pipe(
                switchMap((imageData) => {
                    this.post.previewImage = imageData.body.data.link;
                    return this.postService.createPost(this.post);
                })
            );

        this.loading = true;

        postSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
            (respPost) => {
                this.addNewPost(respPost.body);
                this.removeImage();
                this.post.body = undefined;
                this.post.previewImage = undefined;
                this.loading = false;
            },
            (error) => this.snackBarService.showErrorMessage(error)
        );
    }

    public showNotifications() {

        if (this.posts != null) {
            let userPosts = this.posts.filter(post => post.author.id == this.currentUser.id);
            userPosts.map(post => (post.reactions.map(react => this.notifications.push(react))));
            this.notifications = this.notifications.filter(notif => notif.isLike == true && notif.user.id != this.currentUser.id);
        }
        this.isNotificationsVisible = !this.isNotificationsVisible;
        if (!this.isNotificationsVisible) {
            this.notifications = [];
            this.sidenav.close();
        }
        if (this.isNotificationsVisible) {
            this.sidenav.open();
        }
    }

    public loadImage(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            target.value = '';
            this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.imageUrl = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public removeImage() {
        this.imageUrl = undefined;
        this.imageFile = undefined;
    }

    public sliderChanged(event: MatSlideToggleChange) {
        if (event.checked) {
            this.isOnlyMine = true;
            this.posts = this.cachedPosts.filter((x) => x.author.id === this.currentUser.id);
        } else {
            this.isOnlyMine = false;
            this.posts = this.cachedPosts;
        }
    }

    public sliderCommonChanged(event: MatSlideToggleChange) {
        if (event.checked) {
            this.isCommonPosts = true;
            this.posts = this.cachedPosts.filter((x) => x.author.id !== this.currentUser.id);
        } else {
            this.isCommonPosts = false;
            this.posts = this.cachedPosts;
        }
    }

    public sliderLikeChanged(event: MatSlideToggleChange) {
        if (event.checked) {
            this.isOnlyMineLiked = true;
            var filtered = this.cachedPosts.filter(x => x.reactions.map(r => r.user.id).includes(this.currentUser.id) == true
                && x.reactions.map(r => r.isLike).includes(true) == true);
            this.posts = filtered;
        } else {
            this.isOnlyMineLiked = false;
            this.posts = this.cachedPosts;
        }
    }

    public toggleNewPostContainer() {
        this.showPostContainer = !this.showPostContainer;
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    public registerHub() {
        this.postHub = new HubConnectionBuilder().withUrl('https://localhost:44344/notifications/post').build();
        this.postHub.start().catch((error) => this.snackBarService.showErrorMessage(error));

        this.postHub.on('NewPost', (newPost: Post) => {
            if (newPost) {
                this.addNewPost(newPost);
            }
        });

        this.postHub.on('Like', (post: Post) => {
            if (post) {
                this.likePostFromHub(post);
            }
        });

        this.postHub.on('Edit', (post: Post) => {
            if (post) {
                this.editPostFromHub(post);
            }
        });

        this.postHub.on('Delete', (post: Post) => {
            if (post) {
                this.deletePostFromHub(post);
            }
        });
    }

    public likePostFromHub(postFrom: Post) {
        this.posts = this.posts.map(post => {
            if (post.id == postFrom.id) {
                return postFrom
            } else {
                return post
            }
        })
        this.toastr.info("Liked Post!");
    }

    public editPostFromHub(postFrom: Post) {
        this.posts = this.posts.map(post => {
            if (post.id == postFrom.id) {
                return postFrom
            } else {
                return post
            }
        })
        this.toastr.success("Edited Post!");
    }

    public deletePostFromHub(postFrom: Post) {
        this.posts = this.posts.map(post => {
            if (post.id == postFrom.id) {
                return postFrom
            } else {
                return post
            }
        })
        this.toastr.error("Deleted Post!");
    }

    public addNewPost(newPost: Post) {
        if (!this.cachedPosts.some((x) => x.id === newPost.id)) {
            this.cachedPosts = this.sortPostArray(this.cachedPosts.concat(newPost));
            if (!this.isOnlyMine || (this.isOnlyMine && newPost.author.id === this.currentUser.id)) {
                this.posts = this.sortPostArray(this.posts.concat(newPost));
                let result = "Successfully added post by " + newPost.author.userName;
                this.toastr.success(result);
            }
        }
    }

    private getUser() {
        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.currentUser = user));
    }

    private sortPostArray(array: Post[]): Post[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }

}
