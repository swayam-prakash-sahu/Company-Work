import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginComponent } from '../login/login.component';
import { CommonModule, NgIf } from '@angular/common';
import * as XLSX from 'xlsx';
@Component({
  selector: 'app-admin-dashboard',
  standalone: true,
  imports: [LoginComponent, CommonModule],
  providers: [NgIf],
  templateUrl: './admin-dashboard.component.html',
  styleUrl: './admin-dashboard.component.css'
})
export class AdminDashboardComponent {
  users: any[] = [];
  appointments: any[] = [];
  title = 'httpclient';
  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
    const userDetailsString = sessionStorage.getItem('userDetails');
    if (userDetailsString == null) {
      this.router.navigate(['']);
    } else {
      const userDetailsArray = JSON.parse(userDetailsString);
      const userDetails = userDetailsArray[0];
      console.log(userDetails);
      console.log(userDetails.username, userDetails.password);
      if (userDetails.username == "admin" && userDetails.password == "admin") {
        this.router.navigate(['/admindashboard']);
      } else {
        this.router.navigate(['userdashboard']);
      }
    }

    this.getUsers();
    this.getAppointment();
  }
  getAppointment() {
    this.http.get<any[]>('http://localhost:8081/get-appointments').subscribe(
      (data) => {
        this.appointments = data;
        console.log(this.appointments);
      },
      (error) => {
        console.error('Error fetching users:', error);
      }
    );
  }
  getUsers() {
    this.http.get<any[]>('http://localhost:8081/users').subscribe(
      (data) => {
        this.users = data;
      },
      (error) => {
        console.error('Error fetching users:', error);
      }
    );
  }
  logout() {
    sessionStorage.removeItem('userDetails');
    this.router.navigate(['']);
  }
  verifyUser(userId: number, userEmail: string, userName: string, password: string) {
    this.http.post<any>('http://localhost:8081/verifyuser', { userid: userId, email: userEmail, username: userName, password: password }).subscribe(
      (response) => {
        console.log('Verification successful:', response);
        this.getUsers();
      },
      (error) => {
        console.error('Verification failed:', error);
      }
    );
  }
  AcceptAppointment(appointmentId: number, userEmail: string, userName: string, appointmentTime: string) {
    console.log(appointmentTime);
    this.http.post<any>('http://localhost:8081/acceptAppointment', { appointmentId: appointmentId, email: userEmail, username: userName, appointmenttime: appointmentTime }).subscribe(
      (response) => {
        console.log('Verification successful:', response);
        this.getUsers();
      },
      (error) => {
        console.error('Verification failed:', error);
      }
    );
  }
  downloadExcel() {
    const data: any[] = [];
    const headers = ['Username', 'Email', 'Verify', 'Password'];
    data.push(headers);
    this.users.forEach(user => {
      const row = [user.username, user.email, user.verify, user.password];
      data.push(row);
    });
    const ws: XLSX.WorkSheet = XLSX.utils.aoa_to_sheet(data);
    const wb: XLSX.WorkBook = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Users');
    XLSX.writeFile(wb, 'user_records.xlsx');
  }


}
