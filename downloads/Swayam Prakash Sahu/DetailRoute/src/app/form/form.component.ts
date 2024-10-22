
import { Component } from '@angular/core';
import { FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

import { CommonModule } from '@angular/common';
import { DetailComponent } from '../detail/detail.component';


@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule,DetailComponent],
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent {
  formData: any = {};
  submitted: boolean = false;
  nameWarning: string = '';
  emailWarning: string = '';
  phoneWarning: string = '';
  darkMode: boolean = false;
  

  constructor(private router: Router) {}

  submitForm(form: NgForm) {
    this.nameWarning = '';
    this.emailWarning = '';
    this.phoneWarning = '';
    this.submitted = true;

    if (form.valid) {
      if (this.formData.gender) {
      //this.submitted = true;
      //this.detailComponent.addRecord(this.formData);
      this.router.navigate(['/detail'], { state: { data: this.formData } });
      }
    } else {
      if (form.controls['name'].hasError('required')) {
        this.nameWarning = 'Name is required.';
      }
      if (form.controls['email'].hasError('required')) {
        this.emailWarning = 'Email is required.';
      } else if (form.controls['email'].hasError('pattern')) {
        this.emailWarning = 'Invalid email format.';
      }
      if (form.controls['phone'].hasError('required')) {
        this.phoneWarning = 'Phone number is required.';
      } else if (form.controls['phone'].hasError('pattern')) {
        this.phoneWarning = 'Phone number must be 10 digits.';
      }
    }
  }

  resetForm(form: NgForm) {
    form.resetForm();
    this.formData = {};
  }

  toggleMode() {
    this.darkMode = !this.darkMode;
  }

  toggleLightMode() {
    document.body.classList.remove('dark-mode');
  }

  // Method to toggle dark mode
  toggleDarkMode() {
    document.body.classList.add('dark-mode');
  }
}




