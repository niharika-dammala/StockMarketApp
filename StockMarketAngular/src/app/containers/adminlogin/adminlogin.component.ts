import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminlogin',
  templateUrl: './adminlogin.component.html',
  styleUrls: ['./adminlogin.component.css']
})
export class AdminloginComponent implements OnInit {
  admin: string='';
  password: string='';

  errmsg: string='';

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  public Login() {
    if (this.admin == "admin001" && this.password == "admin001") {
      this.errmsg = "valid";
      this.router.navigate(['/adminapp']);
    } else {
      this.errmsg = "invalid";
    }
  }

  public resetForm() {
    this.admin = "";
    this.password = "";
    this.errmsg = "";
  }

}
