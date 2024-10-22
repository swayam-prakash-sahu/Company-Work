import { Component, NgModule } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { AdminDashboardComponent } from '../admin-dashboard/admin-dashboard.component';
import { FormsModule, NgForm } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  ngOnInit() {
    const userDetailsString = sessionStorage.getItem('userDetails');
    console.log(userDetailsString);
    if (userDetailsString == null) {
      this.router.navigate(['']);
    } else {
      const userDetailsArray = JSON.parse(userDetailsString);
      const userDetails = userDetailsArray[0];
      console.log(userDetails);
      console.log(userDetails.username, userDetails.password);
      if (userDetails.username == "admin" && userDetails.password == "admin") {
        this.router.navigate(['/admindashboard']);
      } else {
        this.router.navigate(['userdashboard']);
      }
    }
  }

  username: string = '';
  password: string = '';

  title = 'httpclient';
  constructor(private http: HttpClient, private router: Router) { }
  login() {
    this.http.post('http://localhost:8081/login', { username: this.username, password: this.password }).subscribe(
      (data) => {
        sessionStorage.setItem('userDetails', JSON.stringify(data));
        const userDetailsString = sessionStorage.getItem('userDetails');
        if (userDetailsString != null) {
          console.log('Login successful:', data);

          const userDetailsArray = JSON.parse(userDetailsString);
          const userDetail = userDetailsArray[0];
          if (this.username == "admin" && this.password === "admin") {
            this.router.navigate(['/admindashboard']);
          } else if (userDetail.verify == true) {
            this.router.navigate(['/userdashboard']);
          } else {
            alert("user is not verified");
            this.router.navigate(['']);
          }
        }
      },

      (error) => {
        console.error('Login failed:', error);
      }
    );
  }
}
