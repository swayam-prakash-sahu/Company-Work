// import { Component, Input } from '@angular/core';
// import { LoginComponent } from '../login/login.component';
// import { CommonModule } from '@angular/common';
// import { FormsModule } from '@angular/forms';

// @Component({
//   selector: 'app-form',
//   standalone: true,
//   imports: [LoginComponent,CommonModule,FormsModule],
//   templateUrl: './form.component.html',
//   styleUrl: './form.component.css'
// })
// export class FormComponent {
//   @Input() userData: any[] = [];
// }

import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-form',
  standalone:true,
  imports:[CommonModule,HttpClientModule,FormsModule],
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  users: any[] = [];
  

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
    this.http.get<any[]>('http://localhost:8081/users').subscribe((data) => {
      this.users = data;
    });
  }

  verifyUser(user: any) {
    this.http.post<any>('http://localhost:8081/verifyuser', { userid: user.userid, email: user.email, username: user.username, password: user.password })
      .subscribe({
        next: (response) => {
          if (response.msg === 'Email sent') {
            alert('User verified successfully!');
            
            user.verify = true;
          } else {
            alert('Failed to verify user.');
          }
        },
        error: (error) => {
          console.error('Error verifying user:', error);
          alert('An error occurred while verifying user.');
        }
      });
  }
  

  logout() {
 
    this.router.navigate(['']);
  }
}


