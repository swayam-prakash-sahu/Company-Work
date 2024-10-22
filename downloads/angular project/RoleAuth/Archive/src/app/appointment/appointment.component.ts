// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-appointment',
//   standalone: true,
//   imports: [],
//   templateUrl: './appointment.component.html',
//   styleUrl: './appointment.component.css'
// })
// export class AppointmentComponent {

// }

// appointment.component.ts
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-appointment',
  standalone: true,
   imports: [FormsModule,CommonModule],
  templateUrl: './appointment.component.html',
  styleUrls: ['./appointment.component.css']
})
export class AppointmentComponent {
  date: Date = new Date();
  timeSlots: string[] = [];

  constructor(private http: HttpClient) {}

  getBlockedTimeSlots(): void {
    const formattedDate = this.formatDate(this.date);
    this.http.get<string[]>(`http://localhost:8081/api/appointments/blocked-slots?date=${formattedDate}`)
      .subscribe({
        next: (response) => {
          this.timeSlots = response;
        },
        error: (error) => {
          console.error('Error fetching blocked time slots:', error);
        }
      });
  }

  scheduleAppointment(timeSlot: string): void {
    // Implement scheduling logic
  }

  formatDate(date: Date): string {
    // Implement date formatting logic
    return '';
  }
}
