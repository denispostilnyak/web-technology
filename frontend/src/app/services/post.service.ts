import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { Post } from '../models/post/post';
import { EditPost } from '../models/post/edit-post';
import { NewReaction } from '../models/reactions/newReaction';
import { NewPost } from '../models/post/new-post';
import { SharePost } from '../models/post/share-post';

@Injectable({ providedIn: 'root' })
export class PostService {
    public routePrefix = '/api/posts';

    constructor(private httpService: HttpInternalService) { }

    public getPosts() {
        return this.httpService.getFullRequest<Post[]>(`${this.routePrefix}`);
    }

    public createPost(post: NewPost) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}`, post);
    }

    public likePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/like`, reaction);
    }

    public editPost(post: EditPost) {
        return this.httpService.putFullRequest<Post>(`${this.routePrefix}/edit`, post);
    }

    public deletePost(id: Number) {
        return this.httpService.deleteFullRequest<Post>(`${this.routePrefix}`, { id });
    }

    public sharePost(share: SharePost) {
        return this.httpService.postFullRequest(`${this.routePrefix}/share`, share);
    }

    public notifyAboutLike(share: SharePost) {
        return this.httpService.postFullRequest(`${this.routePrefix}/notify`, share);
    }
}
