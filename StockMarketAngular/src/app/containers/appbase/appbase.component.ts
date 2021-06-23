import { Component, OnInit } from '@angular/core';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-appbase',
  templateUrl: './appbase.component.html',
  styleUrls: ['./appbase.component.css']
})
export class AppbaseComponent implements OnInit {

  constructor(private s:CompanyService) { }
// public test2()
// {
//   this.s.test1();
// }
  ngOnInit(): void {
  }

}
