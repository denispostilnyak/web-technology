import { Injectable, OnDestroy } from '@angular/core';
import { EditPostDialogComponent } from '../components/edit-post-dialog/edit-post-dialog.component';
import { PostDialogType } from '../models/common/edit-post-dialog-type';
import { User } from '../models/user';
import { Post } from '../models/post/post';
import { EditPost } from '../models/post/edit-post';
import { MatDialog } from '@angular/material/dialog';
import { map, takeUntil } from 'rxjs/operators';
import { AuthenticationService } from './auth.service';
import { Subscription, Subject, of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class EditPostDialogService implements OnDestroy {
    private unsubscribe$ = new Subject<void>();

    public constructor(private dialog: MatDialog, private authService: AuthenticationService) { }

    public openEditPostDialog(type: PostDialogType, post: Post) {
        const dialog = this.dialog.open(EditPostDialogComponent, {
            data: { dialogType: type, post: post },
            minWidth: 600,
            minHeight: 600,
            autoFocus: true,
            backdropClass: 'dialog-backdrop',
            position: {
                top: '0'
            }
        });

        return dialog
            .afterClosed()
            .pipe(takeUntil(this.unsubscribe$));
    }
    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }
}
