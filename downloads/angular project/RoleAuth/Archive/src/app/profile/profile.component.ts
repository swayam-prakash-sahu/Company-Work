// import { Component } from '@angular/core';
// import { Router } from '@angular/router';

// @Component({
//   selector: 'app-profile',
//   standalone: true,
//   imports: [],
//   templateUrl: './profile.component.html',
//   styleUrl: './profile.component.css'
// })
// export class ProfileComponent {
//   username: string = '';

// }

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-profile',
  standalone: true,
   imports: [HttpClientModule,CommonModule,FormsModule],
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit{
  username: string = ''; 
  receivedData: any;

  constructor(private router: Router, private route:ActivatedRoute) {}

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.receivedData = params['userName'];
    });
  }

  logout() {
    
    sessionStorage.removeItem('username');
    localStorage.removeItem('username');
    
    this.router.navigate(['']);
  }
}

