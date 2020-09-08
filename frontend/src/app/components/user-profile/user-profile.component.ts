import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { User } from '../../models/user';
import { Password } from '../../models/password';
import { Location } from '@angular/common';
import { Subject } from 'rxjs';
import { UserService } from '../../services/user.service';
import { AuthenticationService } from '../../services/auth.service';
import { ImgurService } from '../../services/imgur.service';
import { switchMap, takeUntil, map } from 'rxjs/operators';
import { SnackBarService } from '../../services/snack-bar.service';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit, OnDestroy {
    public user = {} as User;
    public loading = false;
    public imageFile: File;
    public users: User[];
    public isEmailUnique: Boolean = true;
    public isUserNameUnique: Boolean = true;

    public hidePass = true;
    public isResetPasswordVisible: Boolean;
    public newPassword: string;
    public repeatePassword: string;
    public isPasswordsMatch: boolean = true;
    public isChangedSuccesfully: boolean;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private location: Location,
        private userService: UserService,
        private snackBarService: SnackBarService,
        private authService: AuthenticationService,
        private imgurService: ImgurService
    ) { }

    public ngOnInit() {
        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((user) => (this.user = this.userService.copyUser(user)), (error) => this.snackBarService.showErrorMessage(error));
        this.userService.getUsers().pipe(takeUntil(this.unsubscribe$)).subscribe(
            (users) => (
                this.users = users.body
            ), (error) => this.snackBarService.showErrorMessage(error));
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public checkEmailOrUserName() {
        if (this.users) {
            var isExistEmail = this.users.map(resp => { return (resp.email == this.user.email && resp.id != this.user.id) }).includes(true);
            var isExistUserName = this.users.map(resp => { return (resp.userName == this.user.userName && resp.id != this.user.id) }).includes(true);
            this.isEmailUnique = !isExistEmail;
            this.isUserNameUnique = !isExistUserName;
        }
    }

    public changePassword() {
        if (this.newPassword != null && this.newPassword.length != 0) {
            let password: Password = { userid: this.user.id, body: this.newPassword };
            this.userService.changePassword(password)
                .subscribe();
        }
        this.isResetPasswordVisible = !this.isResetPasswordVisible;
        this.isChangedSuccesfully = true;

    }

    public onPassCheck(event: any): void {
        if (this.newPassword == this.repeatePassword) {
            this.isPasswordsMatch = true;
        } else {
            this.isPasswordsMatch = false;
        }
    }

    public resetPassword() {
        this.isResetPasswordVisible = !this.isResetPasswordVisible;
    }

    public saveNewInfo() {
        const userSubscription = !this.imageFile
            ? this.userService.updateUser(this.user)
            : this.imgurService.uploadToImgur(this.imageFile, 'title').pipe(
                switchMap((imageData) => {
                    this.user.avatar = imageData.body.data.link;
                    return this.userService.updateUser(this.user);
                })
            );

        this.loading = true;

        userSubscription.pipe(takeUntil(this.unsubscribe$)).subscribe(
            () => {
                this.authService.setUser(this.user);
                this.snackBarService.showUsualMessage('Successfully updated');
                this.loading = false;
            },
            (error) => this.snackBarService.showErrorMessage(error)
        );
    }

    public handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.snackBarService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => (this.user.avatar = reader.result as string));
        reader.readAsDataURL(this.imageFile);
    }

    public goBack = () => this.location.back();
}
