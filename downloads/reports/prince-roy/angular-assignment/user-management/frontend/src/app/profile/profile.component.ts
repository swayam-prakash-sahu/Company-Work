import { Component, inject } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-profile',
  standalone: true,
  imports: [],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css',
})
export class ProfileComponent {
  currentUser: string = '';
  authService: AuthService = inject(AuthService);

  ngOnInit() {
    this.currentUser = this.authService.getCurrentUser();
  }
}
