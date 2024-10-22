import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [HttpClientModule, CommonModule, FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  username: string = '';
  password: string = '';

  authService: AuthService = inject(AuthService);

  constructor(private router: Router, private http: HttpClient) {}

  onSubmit() {
    this.http
      .post<any>('http://localhost:8081/login', {
        username: this.username,
        password: this.password,
      })
      .subscribe(data => {
        if (data.length != 0) {
          const { username, password } = data[0];
          if (username === 'admin' && password === 'admin') {
            this.authService.toggleLogin();
            this.router.navigate(['/admin']);
          } else {
            this.authService.setCurrentUser(username);
            this.router.navigate(['/profile']);
          }
        } else {
          Swal.fire({
            title: 'Account Not Found',
            text: 'Invalid Credentials',
            icon: 'error',
          });
          console.log('Invalid Credentials.');
        }
      });
  }
}
