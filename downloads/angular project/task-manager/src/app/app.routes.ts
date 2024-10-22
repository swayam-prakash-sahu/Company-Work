import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';

export const routes: Routes = [
    { path: 'login', component: LoginComponent },
   // { path: 'app', component: AppComponent },
    { path: '**', redirectTo: '/login', pathMatch: 'full' },

];
