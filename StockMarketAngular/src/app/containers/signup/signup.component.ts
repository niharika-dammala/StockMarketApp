import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { UserService } from 'src/app/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  userObject: User;

  userId: number;
  username: string;
  password: string;
  userType: string;
  email: string;
  mobile: string;
  confirmed: string;

  errmsg: string = "";

  constructor(private service: UserService, private router: Router) { }

  ngOnInit(): void {
  }

  public Signup() {
    this.userObject = new User();
    this.userObject.userId = this.userId;
    this.userObject.username = this.username;
    this.userObject.password = this.password;
    this.userObject.userType = this.userType;
    this.userObject.email = this.email;
    this.userObject.mobile = this.mobile;
    this.userObject.confirmed = this.confirmed;

    this.service.Signup(this.userObject).subscribe(response => {
      this.router.navigate(['/userlogin']);
    }, err => {
      console.log(err);
    })
  }

}
