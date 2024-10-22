// import { CommonModule } from '@angular/common';
// import { Component, OnInit } from '@angular/core';
// import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// import { RegisterComponent } from '../register/register.component';
// import { RouterLink, RouterLinkActive } from '@angular/router';
// import { Router } from '@angular/router';
// import { FormComponent } from '../form/form.component';

// @Component({
//   selector: 'app-login',
//   standalone: true,
//   imports: [CommonModule,FormsModule,RouterLinkActive,RouterLink,FormComponent,ReactiveFormsModule],
//   templateUrl: './login.component.html',
//   styleUrl: './login.component.css'
// })
// export class LoginComponent implements OnInit{

//   constructor(private router: Router) { }

//   ngOnInit(): void {
//   }

//   onLogin(): void {
//     // Redirect to the form page
//     this.router.navigateByUrl('/form');
//   }

// }


// import { Component } from '@angular/core';
// import {FormControl, Validators, FormsModule,ReactiveFormsModule} from '@angular/forms';
// import { Router, RouterLink } from '@angular/router';
// import { FormComponent } from '../form/form.component';
// import { CommonModule } from '@angular/common';
// import { HttpClient, HttpClientModule } from '@angular/common/http';
 
// @Component({
//   selector: 'app-login',
//   standalone: true,
//   imports: [FormsModule,CommonModule,ReactiveFormsModule,RouterLink,HttpClientModule],
//   templateUrl: './login.component.html',
//   styleUrl: './login.component.css'
// })
// export class LoginComponent
// {
//   username = new FormControl('', [Validators.required]);
//   password = new FormControl('', [Validators.required]);
//   constructor(private router: Router) {}
 
// onSubmit(){
//   if(this.username.valid && this.password.valid){
//     const formData={
//       username: this.username.value,
//       password: this.password.value
//     };
 
//   this.router.navigate(['/form'],{state:{data:formData}});
//     } else {
//       console.log('Invalid Entry, Kindly Check the username and password');
//     }
// }
// }


// import { Component } from '@angular/core';
// import { HttpClient, HttpClientModule } from '@angular/common/http';
// import { FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';
// import { CommonModule } from '@angular/common';
// import { RouterLink,Router } from '@angular/router';

// @Component({
//   selector: 'app-login',
//   standalone: true,
//   imports: [FormsModule,CommonModule,ReactiveFormsModule,RouterLink,HttpClientModule],
//   templateUrl: './login.component.html',
//   styleUrls: ['./login.component.css']
// })
// export class LoginComponent {

//   username: string = ''; // Define username property
//   password: string = ''; // Define password property
//   errorMessage: string = ''; // Define error message property

//   constructor(private http: HttpClient,private router: Router ) {}

//   onSubmit(form: NgForm) {
//     if (form.invalid) {
//       return;
//     }
    
//     // Send login request to backend
//     this.http.post<any>('http://localhost:8081/login', form.value)
//       .subscribe({
//         next: (response) => {
//           // Check if login was successful
//           if (response && response.length > 0) {
//             // Login successful, do something (e.g., redirect to dashboard)
          
//             this.router.navigate(['/form'], { state: { data: form.value } });
//             // You can redirect to another page or perform other actions upon successful login
//           } else {
//             this.errorMessage = 'Invalid username or password.';
//           }
//         },
//         error: (error) => {
//           console.error('An error occurred:', error);
//           this.errorMessage = 'An error occurred while processing your request.';
//         }
//       });
//   }
// }

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
              
              this.router.navigate(['/form']);
            } else {
              
              this.router.navigate(['/profile'],{ queryParams: { userName: this.username }});
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








