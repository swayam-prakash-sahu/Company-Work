// import { Component } from '@angular/core';
// import { HttpClient } from '@angular/common/http';
// import { FormsModule } from '@angular/forms';
// import { CommonModule } from '@angular/common';
// import { NgForm } from '@angular/forms';

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

//   ngOnInit() {
//     this.getBlockedTimeSlots();
//   }

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
//           this.getBlockedTimeSlots();
          
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

// appointment.component.ts
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


@Component({
  selector: 'app-appointment',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './appointment.component.html',
  styleUrls: ['./appointment.component.css']
})
export class AppointmentComponent {
  date: Date = new Date();
  timeSlots: string[] = ['9:00 AM', '10:00 AM', '11:00 AM', '12:00 PM', '1:00 PM'];
  phoneNumber: string = '';
  selectedTimeSlot: string = '';

  constructor(private http: HttpClient) {}

  getBlockedTimeSlots(): void {
    const formattedDate = this.formatDate(this.date);
    this.http.get<string[]>(`http://localhost:8081/api/appointment/blocked-slots?date=${formattedDate}`)
      .subscribe({
        next: (response) => {
          this.timeSlots = response;
        },
        error: (error) => {
          console.error('Error fetching blocked time slots:', error);
        }
      });
  }

  // scheduleAppointment(): void {
  //   const formattedDate = this.formatDate(this.date);
  //   const appointmentData = {
  //     date: formattedDate,
  //     timeSlot: this.selectedTimeSlot,
  //     phoneNumber: this.phoneNumber
  //   };

  scheduleAppointment(): void {
    if (!this.isValidDate(this.date)) {
      console.error('Invalid date:', this.date);
      return;
    }
    
    console.log('Date before formatting:', this.date);

    const formattedDate = this.formatDate(this.date);
    console.log('Formatted date:', formattedDate);

    const appointmentData = {
      date: formattedDate,
      timeSlot: this.selectedTimeSlot,
      phoneNumber: this.phoneNumber
    };

    this.http.post<any>('http://localhost:8081/api/appointment/block', appointmentData)
      .subscribe({
        next: (response) => {
          console.log('Appointment scheduled successfully:', response);
        },
        error: (error) => {
          console.error('Error scheduling appointment:', error);
        }
      });
  }

  // formatDate(date: Date): string {
  //   if (!(date instanceof Date) || isNaN(date.getTime())) {
  //     // Handle invalid date
  //     console.error('Invalid date:', date);
  //     return '';
  //   }
  //   const year = date.getFullYear();
  //   const month = date.getMonth() + 1;
  //   const day = date.getDate();
  //   return `${year}-${month < 10 ? '0' + month : month}-${day < 10 ? '0' + day : day}`;
  // }

  formatDate(date: Date): string {
  const year = date.getFullYear();
  const month = ('0' + (date.getMonth() + 1)).slice(-2); // Ensure month is two digits
  const day = ('0' + date.getDate()).slice(-2); // Ensure day is two digits
  return `${year}-${month}-${day}`;
}

  isValidDate(date: any): boolean {
    return date instanceof Date && !isNaN(date.getTime());
  }
  
}
