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
import { PostService } from '../../services/post.service';
import { Post } from 'src/app/models/post/post';

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
    public posts: Post[];

    public latitudeMap: number = 50.488508343627736;
    public longitudeMap: number = 30.38167589418529;

    public chartOptions = {
        scaleShowVerticalLines: false,
        responsive: true
    };
    public chartLabels = [];
    public chartType = 'bar';
    public chartLegend = true;
    public chartData = [];
    public loadingChart = true;

    private unsubscribe$ = new Subject<void>();

    constructor(
        private postService: PostService,
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
            .subscribe((user) => {
                this.user = this.userService.copyUser(user);
                this.latitudeMap = !this.user.latitude ? this.latitudeMap : this.user.latitude;
                this.longitudeMap = !this.user.longitude ? this.longitudeMap : this.user.longitude;
                this.initializeChart();
            }, (error) => this.snackBarService.showErrorMessage(error));
        this.userService.getUsers().pipe(takeUntil(this.unsubscribe$)).subscribe(
            (users) => (
                this.users = users.body
            ), (error) => this.snackBarService.showErrorMessage(error));
    }

    public ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    public initializeChart() {
        this.postService
            .getPosts()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (resp) => {
                    let userPosts = resp.body.filter(post => post.isDeleted == false && post.author.id == this.user.id);
                    let createdDates = userPosts.map(post => post.createdAt);
                    let monthes = createdDates.map(date => new Date(date).getMonth() + 1);
                    let uniqueMonthes = Array.from(new Set(monthes));
                    let uniqueMonthesString = uniqueMonthes.map(month => { return month.toLocaleString() + ' month' });
                    this.chartLabels = uniqueMonthesString;
                    let data = {};
                    let previous;
                    monthes.forEach(month => {
                        if (month == previous) {
                            data[month] = data[month] + 1;
                        } else {
                            data[month] = 1;
                        }
                        previous = month;
                    });
                    let result = uniqueMonthes.map(month => {
                        return data[month];
                    });
                    result.push(0);
                    result.push(11);
                    this.chartData = [{
                        data: result, label: 'posts'
                    }];
                    this.loadingChart = false;
                },
                (error) => { }
            );
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
        this.user.latitude = this.latitudeMap;
        this.user.longitude = this.longitudeMap;

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

    public onChoseLocation(event) {
        this.latitudeMap = event.coords.lat;
        this.longitudeMap = event.coords.lng;
    }

    public goBack = () => this.location.back();
}
