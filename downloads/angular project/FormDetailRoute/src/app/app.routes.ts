import { Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { DetailComponent } from './detail/detail.component';

export const routes: Routes = [
    { path: '', component: FormComponent },
    { path: 'detail', component: DetailComponent }
    
];
