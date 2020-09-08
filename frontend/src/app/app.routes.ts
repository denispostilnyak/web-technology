import { Routes } from '@angular/router';
import { AuthGuard } from './guards/auth.guard';
import { MainThreadComponent } from './components/main-thread/main-thread.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { ShowPostComponent } from './components/show-post/show-post.component';

export const AppRoutes: Routes = [
    { path: '', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'thread', component: MainThreadComponent, pathMatch: 'full' },
    { path: 'profile', component: UserProfileComponent, pathMatch: 'full', canActivate: [AuthGuard] },
    { path: 'post/:id', component: ShowPostComponent }
];
