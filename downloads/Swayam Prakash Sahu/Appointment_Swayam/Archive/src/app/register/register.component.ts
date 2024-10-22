

import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule, NgForm } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
   imports: [RouterLink,FormsModule],
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  username: string = ''; 
  email: string = ''; 
  password: string = ''; 

  constructor(private http: HttpClient) {}

  onSubmit(form: any) {
    if (form.invalid) {
      return;
    }
    else{
      alert('Registration done');
    this.http.post('http://localhost:8081/saveuser', form.value)
      .subscribe((response) => {
        console.log(response);
        this.username = '';
        this.email = '';
        this.password = '';
      });}
  }
}




