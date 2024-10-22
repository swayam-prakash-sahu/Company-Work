// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-admin',
//   standalone: true,
//   imports: [],
//   templateUrl: './admin.component.html',
//   styleUrl: './admin.component.css'
// })
// export class AdminComponent {

// }

import { Component, OnInit,ChangeDetectorRef } from '@angular/core';
import { CommonModule, Time } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';
interface User {
  userid: number;
  username: string;
  email: string;
  verify: number;
  password: string;
}
interface Appointment {
  userid: number;
  username: string;
  appointment_id: number;
  timeslot: string;
  dated: string;
  email: string;
}
@Component({
  selector: 'app-admin',
  standalone: true,
  imports: [CommonModule,HttpClientModule,RouterLink,RouterLinkActive],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css'
})
export class AdminComponent implements OnInit {
  userData: any[] = [];
  appointments:Appointment[]=[];
  constructor(private router: Router ,private http: HttpClient, private cdr: ChangeDetectorRef) { }
 
  ngOnInit(): void {
    this.fetchUserData();
    this.fetchAppointments();
  }
 
  fetchUserData(): void {
    this.http.get<any[]>('http://localhost:8081/users')
      .subscribe({
        next: (data) => {
          this.userData = data;
        },
        error: (error) => {
          console.error('Error fetching user data:', error);
        }
      });
  }
 
  fetchAppointments() {
    this.http.get<Appointment[]>('http://localhost:8081/appointments').subscribe({
      next: (response) => {
        this.appointments = response;
        this.cdr.detectChanges();
      },
      error: (error) => {
        console.error('Error fetching appointments:', error);
      }
    });
  }
 
  logout() {
    this.router.navigate(['']);
  }
  verifyUser(user: User) {
    const updatedUser = { ...user, verify: 1 };
    this.http.post<any>('http://localhost:8081/verifyuser', updatedUser).subscribe({
      next: (response) => {
        window.location.reload();
        if (response.success) {
          user.verify = 1;
        }
      },
      error: (error) => {
        console.error('An error occurred:', error);
      }
    });
  }
}


