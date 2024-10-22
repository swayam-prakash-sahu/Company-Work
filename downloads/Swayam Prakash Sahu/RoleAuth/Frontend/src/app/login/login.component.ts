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


import { Component } from '@angular/core';
import {FormControl, Validators, FormsModule,ReactiveFormsModule} from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { FormComponent } from '../form/form.component';
import { CommonModule } from '@angular/common';
 
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormComponent,FormsModule,CommonModule,ReactiveFormsModule,RouterLink],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent
{
  username = new FormControl('', [Validators.required]);
  password = new FormControl('', [Validators.required]);
  constructor(private router: Router) {}
 
onSubmit(){
  if(this.username.valid && this.password.valid){
    const formData={
      username: this.username.value,
      password: this.password.value
    };
 
  this.router.navigate(['/form'],{state:{data:formData}});
    } else {
      console.log('Invalid Entry, Kindly Check the username and password');
    }
}
}