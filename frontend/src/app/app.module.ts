import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorInterceptor } from './helpers/error.interceptor';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutes } from './app.routes';
import { FormsModule } from '@angular/forms';
import { MainThreadComponent } from './components/main-thread/main-thread.component';
import { PostComponent } from './components/post/post.component';
import { HomeComponent } from './components/home/home.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { AuthDialogComponent } from './components/auth-dialog/auth-dialog.component';
import { CommentComponent } from './components/comment/comment.component';
import { MaterialComponentsModule } from './components/common/material-components.module';
import { EditPostDialogComponent } from './components/edit-post-dialog/edit-post-dialog.component';
import { ShowPostComponent } from './components/show-post/show-post.component';
import { ToastrModule } from 'ngx-toastr';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { ScrollingModule as ExperimentalScrollingModule } from '@angular/cdk-experimental/scrolling';
import { VirtualScrollerModule } from 'ngx-virtual-scroller';
import { AgmCoreModule } from '@agm/core';
import { ChartsModule } from 'ng2-charts';

@NgModule({
    declarations: [AppComponent, MainThreadComponent, PostComponent, HomeComponent, UserProfileComponent, EditPostDialogComponent, ShowPostComponent, AuthDialogComponent, CommentComponent],
    imports: [BrowserModule, ScrollingModule, VirtualScrollerModule, ExperimentalScrollingModule, BrowserAnimationsModule,
        HttpClientModule, MaterialComponentsModule, RouterModule.forRoot(AppRoutes), ToastrModule.forRoot(),
        AgmCoreModule.forRoot({
            apiKey: 'AIzaSyCHvhaf_OpR9wni5fuE5QYhh2v0XGK4rBg'
        }), FormsModule, ChartsModule],
    exports: [MaterialComponentsModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
