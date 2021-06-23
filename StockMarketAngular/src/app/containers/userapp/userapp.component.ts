import { Component, OnInit } from '@angular/core';
import { ComparisonService } from "src/app/services/comparison.service";
import { Router } from '@angular/router';

@Component({
  selector: 'app-userapp',
  templateUrl: './userapp.component.html',
  styleUrls: ['./userapp.component.css']
})
export class UserappComponent implements OnInit {

  constructor(public serve: ComparisonService, private router: Router) { }
message:string;
  public ExportStock()
  {
this.serve.ExportStock().subscribe(i=>{
  this.message=i;
})

window.alert(this.message);
  }
  ngOnInit(): void {
  }

}
