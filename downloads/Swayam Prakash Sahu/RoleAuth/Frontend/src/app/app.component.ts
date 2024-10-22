import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl,Validators,FormGroup } from '@angular/forms';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { LoginComponent } from './login/login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HttpClientModule,RouterLinkActive,RouterLink,LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'httpclient';
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http.get('http://localhost:8081/users').subscribe((data) => {
      console.log(data);
    });

    this.http
      .post('http://localhost:8081/saveuser', {
        username: 'username',
        email: 'email@dsf.df',
        password: 'password',
      })
      .subscribe((data) => {
        console.log(data);
      });
  }
}
