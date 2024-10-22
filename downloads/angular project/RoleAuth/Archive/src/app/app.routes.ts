import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { FormComponent } from './form/form.component';
import { ProfileComponent } from './profile/profile.component';

export const routes: Routes = [
{ path: '', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  {path: 'form', component:FormComponent},
  { path: 'profile', component: ProfileComponent }
];
