import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'httpclient';
  constructor(private http: HttpClient) {}

  ngOnInit() {
    // this.http.get('http://localhost:8081/users').subscribe(data => {
    //   console.log(data);
    // });
    // this.http
    //   .post('http://localhost:8081/saveuser', {
    //     username: 'abhishek',
    //     email: 'kumarabhi67809@gmail.com',
    //     password: 'kumarabhi',
    //   })
    //   .subscribe(data => {
    //     console.log(data);
    //   });
  }
}
