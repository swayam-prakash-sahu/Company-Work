// import { CommonModule } from '@angular/common';
// import { Component } from '@angular/core';
// //import { NgModule } from '@angular/core';
// import { FormsModule } from '@angular/forms';

// @Component({
//   selector: 'app-form',
//   standalone: true,
//   imports: [FormsModule,CommonModule],
//   templateUrl: './form.component.html',
//   styleUrl: './form.component.css'
// })
// export class FormComponent {
//   formData: any = {};
//   submitted: boolean = false;

//   submitForm(form: any) {
//     if (form.valid) {
//       this.submitted = true;
//       this.formData = { ...form.value };
//     }
//   }
// }


import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {
  formData: any = {};
  submitted: boolean = false;
  records: any[] = [];
  nameWarning: string = '';
  emailWarning: string = '';
  phoneWarning: string = '';
  editMode: boolean = false;
  editedIndex: number = -1;

  constructor(private router: Router) {}

  submitForm(form: any) {
    this.nameWarning = '';
    this.emailWarning = '';
    this.phoneWarning = '';

    if (form.valid) {
      this.submitted = true;
      if (this.editMode) {
        // Update existing record
        this.records[this.editedIndex] = { ...form.value };
        this.editMode = false;
      } else {
        // Add new record
        this.records.push({ ...form.value });
      }
      this.resetForm(form);

      // this.router.navigate(['/detail']);
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

  resetForm(form: any) {
    form.resetForm();
    this.formData = {};
  }

  editRecord(index: number) {
    // this.formData = { ...this.records[index] };
    // this.records.splice(index, 1);
    this.editMode = true;
    this.editedIndex = index;
    this.formData = { ...this.records[index] };
  }

  deleteRecord(index: number) {
    this.records.splice(index, 1);
  }

  selectGender(gender: string) {
    this.formData.gender = gender;
    
  }
  // saveChanges() {
  //   this.records.push({ ...this.formData });
  //   this.formData = {};
//   }
}







