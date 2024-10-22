import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { FormComponent } from './form/form.component';
import { FormDataDisplayComponent } from './form-data-display/form-data-display.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormComponent,RouterModule,FormDataDisplayComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Form-List';
}
