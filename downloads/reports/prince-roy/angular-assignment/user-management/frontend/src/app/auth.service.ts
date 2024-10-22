import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  loggedIn: boolean = false;
  username: string = '';
  loggedOut: boolean = true;

  constructor() {}

  toggleLogin() {
    this.loggedIn = !this.loggedIn;
    this.loggedOut = !this.loggedOut;
  }

  isLoggedIn() {
    return this.loggedIn;
  }

  isLoggedOut() {
    return this.loggedOut;
  }

  getCurrentUser() {
    return this.username;
  }

  setCurrentUser(username: string) {
    this.username = username;
  }
}
