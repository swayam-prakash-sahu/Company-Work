import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-data-display',
  standalone: true,
  imports: [],
  templateUrl: './form-data-display.component.html',
  styleUrl: './form-data-display.component.css'
})
export class FormDataDisplayComponent implements OnInit {

  formData:any;
  constructor(){}

  ngOnInit(): void {
    this.formData=history.state.data;
  }
  
}
