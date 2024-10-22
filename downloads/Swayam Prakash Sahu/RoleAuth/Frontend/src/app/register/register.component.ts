import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Router } from 'express';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-register',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  onSubmit(form: NgForm) {
    if (form.invalid) {
      return;
    }
    console.log("Form submitted successfully!");
    
  }

}
