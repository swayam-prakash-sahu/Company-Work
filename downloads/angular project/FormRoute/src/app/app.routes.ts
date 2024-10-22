import { Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { DetailComponent } from './detail/detail.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
    { path: 'form', component: FormComponent },
    { path: 'detail', component: DetailComponent }
];
