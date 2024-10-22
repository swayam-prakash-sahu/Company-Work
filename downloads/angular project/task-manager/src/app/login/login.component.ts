// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-login',
//   standalone: true,
//   imports: [],
//   templateUrl: './login.component.html',
//   styleUrl: './login.component.css'
// })
// export class LoginComponent {

// }

//login.component.ts

import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router'; 
import { routes } from '../app.routes';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  email: string = '';
  password: string = '';
  errorMessage: string = '';

  constructor(private router: Router) { }

  login() {
    // Dummy authentication logic
    if (this.email === 'user@example.com' && this.password === 'password') {
      // Successful login
      this.errorMessage = '';
      console.log('Login successful!');
      // Redirect to home page after successful login
      this.router.navigate(['/app']);
    } else {
      // Invalid credentials
      this.errorMessage = 'Invalid email or password';
    }
  }
}

