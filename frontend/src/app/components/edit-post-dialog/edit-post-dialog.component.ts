import { Component, OnInit, Input, Inject, OnDestroy, NgModule } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogType } from '../../models/common/auth-dialog-type';
import { PostDialogType } from '../../models/common/edit-post-dialog-type';
import { Subject } from 'rxjs';
import { Post } from '../../models/post/post';
import { EditPost } from '../../models/post/edit-post';
import { AuthenticationService } from '../../services/auth.service';
import { takeUntil, switchMap, map } from 'rxjs/operators';
import { PostService } from '../../services/post.service';
import { SnackBarService } from '../../services/snack-bar.service';
import { ImgurService } from '../../services/imgur.service';

@Component({
    templateUrl: './edit-post-dialog.component.html',
    styleUrls: ['./edit-post-dialog.component.sass']
})
export class EditPostDialogComponent implements OnInit, OnDestroy {
    @Input() public post: Post;
    public dialogType = PostDialogType;
    public body: string;
    public imageFile: File;
    public previewImage: string;
    private unsubscribe$ = new Subject<void>();

    constructor(
        private dialogRef: MatDialogRef<EditPostDialogComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private authService: AuthenticationService,
        private postService: PostService,
        private imgurService: ImgurService,
        private snackBarService: SnackBarService
    ) { }

    public ngOnInit() {
        this.body = this.data.post.body;
        this.previewImage = this.data.post.previewImage;
    }
    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }
    public loadImage(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            target.value = '';
            this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.previewImage = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public close() {
        this.dialogRef.close(false);
    }
    public save() {
        if (this.imageFile) {
            this.imgurService.uploadToImgur(this.imageFile, 'title').pipe(
                map((imageData) => {
                    this.previewImage = imageData.body.data.link;
                    return
                }));
        }
        this.postService.editPost({ id: this.data.post.id, body: this.body, previewImage: this.previewImage })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((response) => this.dialogRef.close(response), (error) => this.snackBarService.showErrorMessage(error));
    }
}
