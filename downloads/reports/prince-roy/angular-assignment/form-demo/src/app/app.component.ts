import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import {
  FormGroup,
  ReactiveFormsModule,
  FormControl,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ReactiveFormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent {
  title = 'form-demo';

  constructor() {}

  genderOptions = ['Male', 'Female', 'Other'];
  skillsOptions = [
    'HTML',
    'CSS',
    'JavaScript',
    'Angular',
    'React',
    'Vue',
    '.NET',
    'ASP.NET Web API',
  ];

  applyForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(20),
    ]),
    email: new FormControl('', [Validators.required, Validators.email]),
    phoneNum: new FormControl('', [Validators.required]),
    gender: new FormControl('', Validators.required),
    skills: new FormControl('', Validators.required),
  });
}
