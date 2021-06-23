import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { User } from 'src/app/models/user';
import { UserService } from 'src/app/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userlogin',
  templateUrl: './userlogin.component.html',
  styleUrls: ['./userlogin.component.css']
})
export class UserloginComponent implements OnInit {
  userObject: User=new User();

  userId: number=0;
  username: string='';
  password: string='';
  userType: string='';
  email: string='';
  mobile: string='';
  confirmed: string='';

  errmsg: string = "";

  constructor(private service: UserService, private router: Router) { }

  ngOnInit(): void {
  }

  public Login() {
    // this.service.Login(this.username, this.password).subscribe(item => {
    //   this.userObject = item;
    //   this.userId = this.userObject.userId;
    //   this.username = this.userObject.username;
    //   this.password = this.userObject.password;
    //   this.userType = this.userObject.userType;
    //   this.email = this.userObject.email;
    //   this.mobile = this.userObject.mobile;
    //   this.confirmed = this.userObject.confirmed;
    //   this.errmsg = "Valid";
      if (this.username == this.userObject.username && this.password == this.userObject.password) {
        this.errmsg = "valid";
      this.router.navigate(['/userapp']);
    }
    //, err => {
    //   this.resetForm();
    //   this.errmsg = "Invalid"
    //   console.log(err);
    // })
  }

  public resetForm() {
    this.username = "";
    this.password = "";
    this.errmsg = "";
  }
}
