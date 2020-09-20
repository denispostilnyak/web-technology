import { Injectable } from '@angular/core';
import { HttpInternalService } from '../services/http-internal.service';
import { User } from '../models/user';
import { Password } from '../models/password';

@Injectable({ providedIn: 'root' })
export class UserService {
    public routePrefix = '/api/users';

    constructor(private httpService: HttpInternalService) { }

    public getUserFromToken() {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}/fromToken`);
    }

    public getUserById(id: number) {
        return this.httpService.getFullRequest<User>(`${this.routePrefix}`, { id });
    }

    public getUsers() {
        return this.httpService.getFullRequest<User[]>(`${this.routePrefix}/users`);
    }

    public updateUser(user: User) {
        return this.httpService.putFullRequest<User>(`${this.routePrefix}`, user);
    }

    public copyUser({ longitude, latitude, avatar, email, userName, id }: User) {
        return {
            longitude,
            latitude,
            avatar,
            email,
            userName,
            id
        };
    }

    public changePassword(password: Password) {
        return this.httpService.putRequest(`${this.routePrefix}/password`, password);
    }
}
