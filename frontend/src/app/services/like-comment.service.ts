import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { CommentService } from './comment.service';
import { User } from '../models/user';
import { Comment } from '../models/comment/comment';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class LikeCommentService {
    public constructor(private authService: AuthenticationService, private commentService: CommentService) { }

    public likeComment(comment: Comment, currentUser: User) {
        const innerComment = comment;

        const reaction: NewReaction = {
            entityId: innerComment.id,
            isLike: true,
            userId: currentUser.id
        };
        let hasReaction = innerComment.reactions.some((x) => (x.user.id === currentUser.id && x.isLike === false));
        if (hasReaction) {
            innerComment.reactions = innerComment.reactions.filter((x) => x.user.id !== currentUser.id);
        }

        hasReaction = innerComment.reactions.some((x) => (x.user.id === currentUser.id && x.isLike === true));
        innerComment.reactions = hasReaction
            ? innerComment.reactions.filter((x) => x.user.id !== currentUser.id)
            : innerComment.reactions.concat({ isLike: true, user: currentUser });

        hasReaction = innerComment.reactions.some((x) => x.user.id === currentUser.id);

        return this.commentService.likeDislikeComment(reaction).pipe(
            map(() => innerComment),
            catchError(() => {
                innerComment.reactions = hasReaction
                    ? innerComment.reactions.filter((x) => x.user.id !== currentUser.id)
                    : innerComment.reactions.concat({ isLike: true, user: currentUser });

                return of(innerComment);
            })
        );
    }
}
