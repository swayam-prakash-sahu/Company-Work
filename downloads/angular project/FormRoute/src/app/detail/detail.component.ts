// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-detail',
//   standalone: true,
//   imports: [],
//   templateUrl: './detail.component.html',
//   styleUrl: './detail.component.css'
// })
// export class DetailComponent {

// }

// detail.component.ts
// import { Component, OnInit } from '@angular/core';
// import { SharedService } from '../shared.service';
// import { FormsModule } from '@angular/forms';
// import { CommonModule } from '@angular/common';

// @Component({
//   selector: 'app-detail',
//   standalone: true,
//   imports: [FormsModule,CommonModule],
//   templateUrl: './detail.component.html',
//   styleUrl: './detail.component.css',
//   providers: [SharedService]
// })
// export class DetailComponent implements OnInit {
//   submittedData: any;

//   constructor(private sharedService: SharedService) {}

//   ngOnInit() {
//     this.sharedService.dataUpdated.subscribe(() => {
//       this.submittedData = this.sharedService.submittedData;
//     });
//   }
// }

import { Component, OnInit } from '@angular/core';
//import { FormDataService } from '../form-data.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-detail',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './detail.component.html',
  styleUrl: './detail.component.css'
})
export class DetailComponent implements OnInit{
  formData: any;

  constructor() { }

  ngOnInit(): void {
    this.formData = history.state.data;
  }
}

// import { CommonModule } from '@angular/common';
// import { Component, OnInit } from '@angular/core';
// import { FormsModule } from '@angular/forms';
// import { Router } from '@angular/router';


// import { ActivatedRoute } from '@angular/router';

// @Component({
//   selector: 'app-detail',
//   standalone: true,
//   imports: [],
//   templateUrl: './detail.component.html',
//   styleUrls: ['./detail.component.css']
// })
// export class DetailComponent implements OnInit {
//   records: any[] = [];

//   constructor(private route: ActivatedRoute) { }

//   ngOnInit() {
//     this.records = this.route.snapshot.data['records'];
//   }
// }