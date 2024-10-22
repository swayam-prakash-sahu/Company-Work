import { Component, ElementRef, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
declare var $: any;
@Component({
  selector: 'app-user-dashboard',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent {
  availableSlots: string[] = [];
  selectedSlot: string = "";
  timeSlots: string[] = [];
  currentDate: string = "";
  constructor(private router: Router, private formBuilder: FormBuilder, private http: HttpClient) {
    this.generateTimeSlots();
    this.currentDate = new Date().toISOString().split('T')[0];
  }

  generateTimeSlots() {
    const startTime = 9;
    const endTime = 18;

    for (let hour = startTime; hour <= endTime; hour++) {
      const slot = `${hour < 10 ? '0' + hour : hour}:00 - ${hour + 1}:00`;
      this.timeSlots.push(slot);
    }
  }

  selectSlot(slot: string) {
    console.log('Selected slot:', slot);
    console.log(this.currentDate);

  }
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
  }

  submitForm() {
    const selectedDateTime = this.currentDate + 'T' + this.selectedSlot.split(' - ')[0] + ':00.000Z';
    console.log(selectedDateTime);
    const userDetailsString = sessionStorage.getItem('userDetails');
    if (userDetailsString != null) {
      const userDetailsArray = JSON.parse(userDetailsString);
      const userDetails = userDetailsArray[0];
      const postData = {
        userID: userDetails.userid,
        appointmentTime: selectedDateTime,
      };

      this.http.post('http://localhost:8081/book-appointment', postData).subscribe(response => {
        console.log('Appointment booked successfully:', response);
        alert("Booked successfully");
      }, error => {
        console.error('Error booking appointment:', error);
      });
    }
  }

  logout() {
    sessionStorage.removeItem('userDetails');
    this.router.navigate(['']);
  }
}
