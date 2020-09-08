import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Post } from '../../models/post/post';
import { SharePost } from '../../models/post/share-post';
import { AuthenticationService } from '../../services/auth.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { empty, Observable, Subject } from 'rxjs';
import { DialogType } from '../../models/common/auth-dialog-type';
import { PostDialogType } from '../../models/common/edit-post-dialog-type';
import { LikeService } from '../../services/like.service';
import { EditPostDialogService } from '../../services/edit-post-dialog.service';
import { DislikeService } from '../../services/dislike.service';
import { PostService } from '../../services/post.service';
import { NewComment } from '../../models/comment/new-comment';
import { CommentService } from '../../services/comment.service';
import { User } from '../../models/user';
import { Comment } from '../../models/comment/comment';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';
import { HubConnectionBuilder, HubConnection } from '@aspnet/signalr';
import { Reaction } from 'src/app/models/reactions/reaction';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['./post.component.sass']
})
export class PostComponent implements OnDestroy, OnInit {
    @Input() public post: Post;
    @Input() public currentUser: User;

    public showComments = false;
    public newComment = {} as NewComment;
    public editPostType = PostDialogType;
    public isInputEmailVisible: boolean;
    public isLinkVisible: boolean;
    public sharingEmail: string;
    public postHub: HubConnection;


    private unsubscribe$ = new Subject<void>();

    public constructor(
        private toastr: ToastrService,
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private editPostDialogService: EditPostDialogService,
        private likeService: LikeService,
        private dislikeService: DislikeService,
        private commentService: CommentService,
        private postService: PostService,
        private snackBarService: SnackBarService
    ) { }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public ngOnInit() {
        this.post.comments = this.post.comments.filter(c => c.isDeleted == false);
    }

    public openEditPostDialog(type: PostDialogType) {
        this.editPostDialogService.openEditPostDialog(type, this.post)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((editedPost) => (this.post.body = editedPost.body.body, this.post.previewImage = editedPost.body.previewImage));
    }

    public toggleComments() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((user) => {
                    if (user) {
                        this.currentUser = user;
                        this.showComments = !this.showComments;
                    }
                });
            return;
        }
        this.post.comments = this.post.comments.filter(c => c.isDeleted == false);
        this.showComments = !this.showComments;
    }

    public isAuthor() {
        if (this.authService.areTokensExist()) {
            return (this.post.author.id == this.currentUser.id);
        }
    }
    public sharePostViaEmail() {
        let sharePost: SharePost = { postId: this.post.id, userId: this.currentUser.id, email: this.sharingEmail };
        this.postService.sharePost(sharePost).pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => this.snackBarService.showUsualMessage("Succefull!"), (error) => this.snackBarService.showErrorMessage(error));
        this.isInputEmailVisible = !this.isInputEmailVisible;
    }

    public changeVisibilitySharingEmail() {
        if (!this.currentUser)
            this.authService.getUser()
                .subscribe((userResp) => this.currentUser = userResp);
        this.isInputEmailVisible = !this.isInputEmailVisible;
    }

    public closeSharing() {
        if (this.isInputEmailVisible) {
            this.isInputEmailVisible = !this.isInputEmailVisible;
        }

        if (this.isLinkVisible) {
            this.isLinkVisible = !this.isLinkVisible;
        }
    }

    public changeVisibilitySharingLink() {
        if (!this.currentUser)
            this.authService.getUser()
                .subscribe((userResp) => this.currentUser = userResp);
        this.isLinkVisible = !this.isLinkVisible;
    }

    public onDelete(id: Number) {
        this.post.comments = this.post.comments.filter(c => c.id != id);
    }

    public delete() {
        var strconfirm = confirm("Are you sure do you want delete ?");
        if (strconfirm == true) {
            this.postService.deletePost(this.post.id)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe((response) => response, (error) => this.snackBarService.showErrorMessage(error));
            this.post.isDeleted = true;
        }
    }

    public likePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (post));
            if (this.currentUser.id != this.post.author.id) {
                let likedPost: SharePost = { postId: this.post.id, userId: this.currentUser.id, email: "" };
                this.postService.notifyAboutLike(likedPost).pipe(takeUntil(this.unsubscribe$))
                    .subscribe((response) => response, (error) => this.snackBarService.showErrorMessage(error));
            }
            return;
        }

        this.likeService
            .likePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (post));

        if (this.currentUser.id != this.post.author.id) {
            let likedPost: SharePost = { postId: this.post.id, userId: this.currentUser.id, email: "" };
            this.postService.notifyAboutLike(likedPost).pipe(takeUntil(this.unsubscribe$))
                .subscribe((response) => response, (error) => this.snackBarService.showErrorMessage(error));
        }
    }

    public dislikePost() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.dislikeService.dislikePost(this.post, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((post) => (this.post = post));

            return;
        }

        this.dislikeService
            .dislikePost(this.post, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((post) => (this.post = post));
    }

    public countDislikes() {
        return this.post.reactions.filter(item => item.isLike == false).length;
    }

    public countLikes() {
        return this.post.reactions.filter(item => item.isLike == true).length;
    }

    public showWhoLike() {
        return this.post.reactions.filter(item => item.isLike == true).map(item => { return (item.user.userName) });
    }

    public showWhoDislike() {
        return this.post.reactions.filter(item => item.isLike == false).map(item => { return (item.user.userName) });
    }

    public sendComment() {
        this.newComment.authorId = this.currentUser.id;
        this.newComment.postId = this.post.id;

        this.commentService
            .createComment(this.newComment)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    if (resp) {
                        this.post.comments = this.sortCommentArray(this.post.comments.concat(resp.body));
                        this.newComment.body = undefined;
                    }
                },
                (error) => this.snackBarService.showErrorMessage(error)
            );
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }

    private sortCommentArray(array: Comment[]): Comment[] {
        return array.sort((a, b) => +new Date(b.createdAt) - +new Date(a.createdAt));
    }
}
