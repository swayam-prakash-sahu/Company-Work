import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
  Router,
} from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private auth: AuthService, private router: Router) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    if (this.auth.isLoggedIn() && !this.auth.isLoggedOut()) {
      return true;
    } else {
      Swal.fire({
        title: 'Access Denied',
        text: 'Not Authorized to access this endpoint',
        icon: 'error',
      });
      console.log('Not authorized');
      this.router.navigate(['/login']);
      return false;
    }
  }
}
