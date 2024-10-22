import { Routes } from '@angular/router';
import { FormDataDisplayComponent } from './form-data-display/form-data-display.component';
import { FormComponent } from './form/form.component';

export const routes: Routes = [
    { path: '', component: FormComponent },
    { path: 'form-data-display', component: FormDataDisplayComponent }
];
