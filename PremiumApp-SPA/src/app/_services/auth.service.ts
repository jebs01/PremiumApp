import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = 'http://localhost:5000/api/auth/';

  constructor(private http: HttpClient) {}

 

  calculate(model: any) {
    return this.http.post(this.baseUrl + 'calculate', model).pipe(
      map((response: any) => {
        const user = response;
       // response.
        if (user) {
          return user;
        }
      })
    );
  }
   /*
  calculate(model: any) {
    return this.http.post(this.baseUrl + 'calculate', model);
  }
  */
}
