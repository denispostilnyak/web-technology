import { Component, Input, Output, OnDestroy, EventEmitter } from '@angular/core';
import { Comment } from '../../models/comment/comment';
import { User } from '../../models/user';
import { empty, Observable, Subject } from 'rxjs';
import { AuthenticationService } from '../../services/auth.service';
import { AuthDialogService } from '../../services/auth-dialog.service';
import { DialogType } from '../../models/common/auth-dialog-type';
import { PostDialogType } from '../../models/common/edit-post-dialog-type';
import { LikeService } from '../../services/like.service';
import { DislikeCommentService } from '../../services/dislike-comment.service';
import { LikeCommentService } from '../../services/like-comment.service';
import { EditPostDialogService } from '../../services/edit-post-dialog.service';
import { DislikeService } from '../../services/dislike.service';
import { PostService } from '../../services/post.service';
import { NewComment } from '../../models/comment/new-comment';
import { CommentService } from '../../services/comment.service';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent implements OnDestroy {
    @Input() public comment: Comment;
    @Input() public currentUser: User;

    @Output('onDelete') onDelete: EventEmitter<Number> = new EventEmitter();

    private unsubscribe$ = new Subject<void>();
    public onEditing: boolean = false;

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private dislikeCommentService: DislikeCommentService,
        private likeCommentService: LikeCommentService,
        private commentService: CommentService,
        private postService: PostService,
        private snackBarService: SnackBarService
    ) { }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public likeComment() {
        if (!this.currentUser) {
            this.authService.getUser()
                .pipe(
                    switchMap((userResp) => this.likeCommentService.likeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (this.comment = comment));

            return;
        }

        this.likeCommentService
            .likeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));
    }

    public dislikeComment() {
        if (!this.currentUser) {
            this.authService.getUser()
                .pipe(
                    switchMap((userResp) => this.dislikeCommentService.dislikeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (this.comment = comment));

            return;
        }

        this.dislikeCommentService.
            dislikeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));

    }

    public countDislikes() {
        return this.comment.reactions.filter(item => item.isLike == false).length;
    }

    public countLikes() {
        return this.comment.reactions.filter(item => item.isLike == true).length;
    }

    public showWhoLike() {
        return this.comment.reactions.filter(item => item.isLike == true).map(item => { return (item.user.userName) });
    }

    public showWhoDislike() {
        return this.comment.reactions.filter(item => item.isLike == false).map(item => { return (item.user.userName) });
    }

    public isAuthor() {
        if (!this.currentUser)
            this.authService.getUser()
                .subscribe((userResp) => this.currentUser = userResp);
        return (this.comment.author.id == this.currentUser.id);
    }

    public changeEditingState() {
        if (!this.currentUser)
            this.authService.getUser()
                .subscribe((userResp) => this.currentUser = userResp);

        if (this.onEditing)
            this.commentService
                .editComment(this.comment)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe(c => this.comment = c);

        this.onEditing = !this.onEditing;
    }

    public deleteComment() {
        var strconfirm = confirm("Are you sure do you want delete ?");
        if (strconfirm == true) {
            if (!this.currentUser)
                this.authService.getUser()
                    .subscribe((userResp) => this.currentUser = userResp);

            this.commentService.deleteComment(this.comment.id)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe(() => this.comment.isDeleted = true);
            this.onDelete.emit(this.comment.id);
        }
    }
}