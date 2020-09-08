import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { NewComment } from '../models/comment/new-comment';
import { Comment } from '../models/comment/comment';
import { NewReaction } from '../models/reactions/newReaction';

@Injectable({ providedIn: 'root' })
export class CommentService {
    public routePrefix = '/api/comments';

    constructor(private httpService: HttpInternalService) { }

    public createComment(post: NewComment) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}`, post);
    }

    public likeDislikeComment(reaction: NewReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/reaction`, reaction);
    }

    public editComment(comment: Comment) {
        return this.httpService.putRequest<Comment>(`${this.routePrefix}/edit`, comment);
    }

    public deleteComment(id: Number) {
        return this.httpService.deleteRequest(`${this.routePrefix}`, { id });
    }
}
