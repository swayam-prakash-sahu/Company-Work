import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { User } from '../user';
import { CommonModule } from '@angular/common';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css',
})
export class AdminComponent {
  userData: User[] = [];

  authService: AuthService = inject(AuthService);

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http.get<User[]>('http://localhost:8081/users').subscribe(data => {
      this.userData = [...data];
    });
  }

  handleClick(user: User) {
    const index = this.userData.findIndex(u => u.userid === user.userid);

    if (index == 0) {
      console.log('Not Found');
      return;
    }

    this.userData[index].verify = 1;
    console.log(user.userid);
    this.http
      .post('http://localhost:8081/verifyuser', {
        userid: user.userid,
        email: user.email,
        username: user.username,
        password: user.password,
      })
      .subscribe(data => {
        console.log(data);
      });
  }

  handleLogout() {
    this.authService.loggedOut = true;
  }
}
