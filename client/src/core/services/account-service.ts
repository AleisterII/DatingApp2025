import { HttpClient } from '@angular/common/http';
import { inject, signal } from '@angular/core';
import { Injectable } from '@angular/core';
import { User } from '../../types/user';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private http = inject(HttpClient);
  currentUser = signal<User | null>(null);
  baseUrl = 'https://localhost:5001/api/';

  login(creds: any) {
    return this.http.post<User>(this.baseUrl + "account/login", creds).pipe(
      tap(user => {
        if (user){
          localStorage.setItem("user", JSON.stringify(user))
          this.currentUser.set(user);
        }
      })
    );
  }

  logout() {
    localStorage.removeItem("user");
    this.currentUser.set(null);
  }
}