import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { FormDataDisplayComponent } from '../form-data-display/form-data-display.component';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule,FormDataDisplayComponent],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {

  name = new FormControl('',[Validators.required ,Validators.maxLength(30)]);
  email = new FormControl('',[Validators.required,Validators.email]);
  phone = new FormControl('',[Validators.required,Validators.pattern("[0-9]{10}")]);
  gender = new FormControl('',[Validators.required]);
  skills =new FormControl('',[Validators.required,Validators.maxLength(50)]);

  constructor(private router:Router){}

  onSubmit() {
    if (this.name.valid && this.email.valid && this.phone.valid && this.gender.valid && this.skills.valid) {
      
     const formData={
      name: this.name.value,
      email: this.email.value,
      phone: this.phone.value,
      gender: this.gender.value,
      skills: this.skills.value
     };

     this.router.navigate(['/form-data-display'],{state:{data:formData}});
    } else {
      console.log('Form is invalid. Please fill out all required fields correctly.');
    }
  }



}
