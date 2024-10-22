// import { Component } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { FormsModule } from '@angular/forms';
// import { CommonModule } from '@angular/common';

// @Component({
//   selector: 'app-appointment',
//   standalone: true,
//    imports: [FormsModule, CommonModule],
//   templateUrl: './appointment.component.html',
//   styleUrls: ['./appointment.component.css']
// })
// export class AppointmentComponent {
//   date: Date = new Date();
//   timeSlots: string[] = [];
//   phoneNumber: any;
//   selectedTimeSlot: string = ''; 

//   constructor(private http: HttpClient) {}

//   getBlockedTimeSlots(): void {
//     const formattedDate = this.formatDate(this.date);
//     this.http.get<string[]>(`http://localhost:8081/api/appointments/blocked-slots?date=${formattedDate}`)
//       .subscribe({
//         next: (response) => {
//           this.timeSlots = response;
//         },
//         error: (error) => {
//           console.error('Error fetching blocked time slots:', error);
//         }
//       });
//   }

//   scheduleAppointment(): void {
//     const formattedDate = this.formatDate(this.date);
//     const appointmentData = {
//       date: formattedDate,
//       timeSlot: this.selectedTimeSlot,
//       phoneNumber: this.phoneNumber
//     };
  
//     this.http.post<any>('http://localhost:8081/api/appointments/schedule', appointmentData)
//       .subscribe({
//         next: (response) => {
//           console.log('Appointment scheduled successfully:', response);
          
//         },
//         error: (error) => {
//           console.error('Error scheduling appointment:', error);
          
//         }
//       });
//   }
  
//   formatDate(date: Date): string {
//     const year = date.getFullYear();
//     const month = date.getMonth() + 1;
//     const day = date.getDate();
//     return `${year}-${month < 10 ? '0' + month : month}-${day < 10 ? '0' + day : day}`;
//   }
  
// }


import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router,ActivatedRoute } from '@angular/router';
 
@Component({
  selector: 'app-userview',
  standalone: true,
  imports: [CommonModule,FormsModule,HttpClientModule],
  templateUrl: './appointment.component.html',
  styleUrl: './appointment.component.css'
})
export class AppointmentComponent implements OnInit {
  username: string ='';
  password: string ='';
  receivedData: any;
  dated: string = '';
  contact: string = '';
  timeslot: string = '';
  constructor(private router: Router, private http: HttpClient,private route:ActivatedRoute) { }
 
  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.receivedData = params['userName'];
    });
  }
 
  logout() {
    localStorage.removeItem('username');
    this.router.navigate(['']);
  }
  onSubmit() {
    const appointmentData = {
      username: this.username,
      dated: this.dated,
      contact: this.contact,
      timeslot: this.timeslot
    };
 
    this.http.post<any>('http://localhost:8081/saveappointment', appointmentData).subscribe({
      next: (response) => {
        if (response.success) {
          console.log('Appointment saved successfully');
         
          this.router.navigate(['/']);
        } else {
          console.error('Failed to save appointment:', response.message);
         
        }
      },
      error: (error) => {
        console.error('An error occurred:', error);
       
      }
    });
  }
 
}