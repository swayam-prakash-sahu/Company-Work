import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-detail',
  standalone: true,
  imports: [],
  templateUrl: './detail.component.html',
  styleUrl: './detail.component.css'
})
export class DetailComponent implements OnInit{
  formData:any;
  constructor(){}

  ngOnInit(): void {
    this.formData=history.state.data;
  }

}



