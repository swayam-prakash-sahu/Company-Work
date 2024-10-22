import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { EmailValidator, FormsModule } from '@angular/forms';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-signup',
  standalone: true,
  imports: [RouterLink, RouterLinkActive, CommonModule, FormsModule],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {

  ngOnInit() {
    const userDetailsString = sessionStorage.getItem('userDetails');
    console.log(userDetailsString);
    if (userDetailsString == null) {
      this.router.navigate(['/signup']);
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
  email: string = "";


  title = 'httpclient';
  constructor(private http: HttpClient, private router: Router) { }

  createUser() {
    this.http.post('http://localhost:8081/saveuser', {
      username: this.username,
      email: this.email,
      password: this.password,
      verify: false
    }).subscribe(
      (data) => {
        console.log('User created successfully:', data);
        alert("user id created successfully");
        this.router.navigate(['']);
      },
      (error) => {
        console.error('User creation failed:', error);
      }
    );
  }
}
