import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class DislikeService {
    public constructor(private authService: AuthenticationService, private postService: PostService) { }

    public dislikePost(post: Post, currentUser: User) {
        const innerPost = post;

        const reaction: NewReaction = {
            entityId: innerPost.id,
            isLike: false,
            userId: currentUser.id
        };
        let hasReaction = innerPost.reactions.some((x) => (x.user.id === currentUser.id && x.isLike === true));
        if (hasReaction) {
            innerPost.reactions = innerPost.reactions.filter((x) => x.user.id !== currentUser.id);
        }

        hasReaction = innerPost.reactions.some((x) => (x.user.id === currentUser.id && x.isLike === false));
        innerPost.reactions = hasReaction
            ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
            : innerPost.reactions.concat({ isLike: false, user: currentUser });

        hasReaction = innerPost.reactions.some((x) => x.user.id === currentUser.id);

        return this.postService.likePost(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                innerPost.reactions = hasReaction
                    ? innerPost.reactions.filter((x) => x.user.id !== currentUser.id)
                    : innerPost.reactions.concat({ isLike: false, user: currentUser });

                return of(innerPost);
            })
        );
    }
}
