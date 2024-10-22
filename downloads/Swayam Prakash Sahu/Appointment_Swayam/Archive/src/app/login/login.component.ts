
import { Component } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule,RouterLink,HttpClientModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  username: string = '';
  password: string = ''; 
  errorMessage: string = ''; 

  constructor(private http: HttpClient, private router: Router) { }

  onSubmit(form: NgForm) {
    if (form.invalid) {
      return;
    }

    
    this.http.post<any>('http://localhost:8081/login', form.value)
      .subscribe({
        next: (response) => {
          
          if (response && response.length > 0) {
            
            const user = response[0];
            if (user.password === 'admin') {
              
              //this.router.navigate(['/form']);
              this.router.navigate(['/admin']);
            } else {
              
              this.router.navigate(['/appointment'],{ queryParams: { userName: this.username }});
            }
          } else {
            this.errorMessage = 'Invalid username or password.';
          }
        },
        error: (error) => {
          console.error('An error occurred:', error);
          this.errorMessage = 'An error occurred while processing your request.';
        }
      });
  }
}








