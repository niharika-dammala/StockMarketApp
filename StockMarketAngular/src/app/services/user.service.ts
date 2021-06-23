import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  path1: string = "https://localhost:44301/api/authentication";
  path2: string = "https://localhost:44301/api/register";

  constructor(private http: HttpClient) { }

  public Login(uname: string, passwd: string): Observable<User>
  {
    return this.http.get<User>(this.path1+"/Login/"+uname+"/"+passwd);
  }

  public Signup(item: User)
  {
    return this.http.post(this.path2+"/Signup/",item);
  }
}
