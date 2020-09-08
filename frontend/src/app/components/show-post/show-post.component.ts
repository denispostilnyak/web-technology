import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Post } from '../../models/post/post';
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
import { ActivatedRoute } from '@angular/router';
import { SnackBarService } from '../../services/snack-bar.service';

@Component({
    templateUrl: './show-post.component.html',
    styleUrls: ['./show-post.component.sass']
})
export class ShowPostComponent implements OnDestroy, OnInit {
    @Input() public post: Post;
    @Input() public currentUser: User;

    public showComments = false;
    public newComment = {} as NewComment;
    public editPostType = PostDialogType;
    public inputId: Number;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private activateRoute: ActivatedRoute,
        private editPostDialogService: EditPostDialogService,
        private likeService: LikeService,
        private dislikeService: DislikeService,
        private commentService: CommentService,
        private postService: PostService,
        private snackBarService: SnackBarService
    ) { this.inputId = activateRoute.snapshot.params['id']; }

    public loading: boolean;

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public ngOnInit() {
        this.loading = true;
        this.postService.getPosts().pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    this.loading = false;
                    this.post = resp.body.find(post => post.id == this.inputId);
                });
    }
}
