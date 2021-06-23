import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaderResponse } from "@angular/common/http";
import { BehaviorSubject, Observable } from "rxjs";
import { Company } from '../models/company';
import { Sector } from '../models/Sector';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  path: string = "https://localhost:44391/api/Company/";
  //path: string = "http://localhost:8090/api/Company/";
  path2:string="https://localhost:44386/api/Sector/";

  constructor(private http: HttpClient) { }


  public GetCompanies(): Observable<Company[]>
  {
    //console.log("service call1");
    //console.log(this.http.get<Company[]>("http://localhost:44391/api/Company/GetCompanies"));
    return this.http.get<Company[]>(this.path+"GetCompanies");
  }
  
  public GetCompanyDetails(id:number): Observable<any>
  {
    console.log(id);
    return this.http.get<any>(this.path+'GetCompanyDetails/'+id)
  }
public GetSectorNames():Observable<Sector[]>
{
  return this.http.get<Sector[]>(this.path2+"GetSectors");
}
  public AddCompany(item:Company)
  {
    console.log(item);
    return this.http.post(this.path+"Add/",item);
  }
  
  public EditCompany(item:Company):Observable<any>
  {
    console.log(item);
    return this.http.put<any>(this.path+"EditCompany/",item);
  }

  public DeleteCompany(id:number):Observable<any>
  {
    console.log(id);
    return this.http.delete<any>(this.path+'DeleteCompany/'+id)
  }
}
