import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  username: string = '';
  email: string = '';
  password: string = '';

  constructor(private http: HttpClient) {}

  onRegister() {
    this.http
      .post<any>('http://localhost:8081/saveuser', {
        username: this.username,
        email: this.email,
        password: this.password,
      })
      .subscribe(data => {
        console.log(data);
      });
  }
}
