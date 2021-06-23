import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/models/company';
import { CompanyService } from 'src/app/services/company.service';
import { ComparisonService } from "src/app/services/comparison.service";
import { Router } from '@angular/router';

@Component({
  selector: 'app-userview-companies',
  templateUrl: './userview-companies.component.html',
  styleUrls: ['./userview-companies.component.css']
})
export class UserviewCompaniesComponent implements OnInit {
  companyList: Company[];
  companyObject: Company;
  companyWord: string;

  companyCode: number;
  companyName: string;
  turnover: number;
  ceo: string;
  sectorId: number;

  errormsg: string;

  constructor(private service: CompanyService, private serve: ComparisonService, private router: Router) { 
    this.service.GetCompanies().subscribe(i => {
      this.companyList = i;
      console.log(this.companyList);
    })
  }

  ngOnInit(): void {
  }

  public GetCompanies() {
    this.serve.GetMatchingCompanies(this.companyWord).subscribe(i => {
      this.companyList = i;
    })
  }

}
