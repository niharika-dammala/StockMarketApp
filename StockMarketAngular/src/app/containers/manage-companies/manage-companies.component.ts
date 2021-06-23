import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/models/company';
import { Sector } from 'src/app/models/Sector';
import { CompanyService } from 'src/app/services/company.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-manage-companies',
  templateUrl: './manage-companies.component.html',
  styleUrls: ['./manage-companies.component.css']
})
export class ManageCompaniesComponent implements OnInit {
  companyList: Company[];
  companyObject: Company;

  companyCode: number;
  companyName: string;
  turnover: number;
  ceo: string;
  boardDirector:string;
  sectorId: number;

  errormsg: string;

  SectorList:Sector[];
sectorName:string;
breif:string;
public SectorNamesList:string[][];
  constructor(private service: CompanyService, private router: Router) { 
    this.service.GetCompanies().subscribe(i => {
      this.companyList = i;
      console.log(this.companyList);
  })
  this.service.GetSectorNames().subscribe(j=>{
    this.SectorList=j;
  })
  }

  ngOnInit(): void {

   // window.alert(this.companyList);
    //console.log("hi"+this.companyList);
  
  }
  public GetSectorDetails()
  {
    

  }

  public GetCompanyDetails() {
    this.service.GetCompanyDetails(this.companyCode).subscribe(item => {
      console.log(item);
      this.companyObject = item;
      this.companyName = this.companyObject.companyName;
      this.turnover = this.companyObject.turnover;
      this.ceo = this.companyObject.ceo;
      this.boardDirector=this.companyObject.boardDirector;
      this.sectorId = this.companyObject.sectorId;
      this.errormsg = "";
    })
  }
  onDelete(id:number)
  {
    if(confirm("Are sure want to delete this record?"))
    {
      this.service.DeleteCompany(id)
      .subscribe(
        res=>{
          //this.toastr.error("Item Delted Successfully!","Company Detail Register")
          //this.service.refreshList()
        },
        err=>{
          console.log(err);
        }
      )
    }}
  public AddCompany() {
    this.companyObject = new Company();
    this.companyObject.companyCode = this.companyCode;
    this.companyObject.companyName = this.companyName;
    this.companyObject.turnover = this.turnover;
    this.companyObject.ceo = this.ceo;
    this.companyObject.boardDirector=this.boardDirector;
    this.companyObject.sectorId = this.sectorId;

    this.service.AddCompany(this.companyObject).subscribe(response => {}, err =>  {
      console.log(err);
      console.log(err.error.text);
    })
  }

  public EditCompany() {
    this.companyObject = new Company();
    this.companyObject.companyCode = this.companyCode;
    this.companyObject.companyName = this.companyName;
    this.companyObject.turnover = this.turnover;
    this.companyObject.ceo = this.ceo;
    this.companyObject.boardDirector=this.boardDirector;
    this.companyObject.sectorId = this.sectorId;

    this.service.EditCompany(this.companyObject).subscribe(i => {
      console.log(i);
    })
  }

  public DeleteCompany() {
    this.service.DeleteCompany(this.companyCode).subscribe(i => {
      console.log(i);
    })
  }

}
