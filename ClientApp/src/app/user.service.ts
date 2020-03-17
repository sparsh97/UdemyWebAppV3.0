import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
 
import { UserInfo } from '../app/models/UserInfo.model';

 
@Injectable({ providedIn: 'root' })

export class UserService {
   uri='https://localhost:44353/api';
   
constructor(private http: HttpClient) { }
 
public fetchUserInfo(userInf:UserInfo[]){
 return this.http.post('https://localhost:44353/api/UserInfoes', userInf)
}
register(user: UserInfo) {
return this.http.post(`auth/register`, user);
}
 

}