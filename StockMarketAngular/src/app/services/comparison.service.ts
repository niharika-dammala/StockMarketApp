import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Company } from '../models/company';

@Injectable({
  providedIn: 'root'
})
export class ComparisonService {
  path: string = "https://localhost:44391/api/Company/";
  path2:string="https://localhost:44351/api/ImportExcel/"

  constructor(private http: HttpClient) { }

  public GetCompany(cmpname: string): Observable<Company>
  {
    return this.http.get<Company>(this.path+"GetCompanyDetailsByName/"+cmpname);
  }

  public GetMatchingCompanies(word: string): Observable<Company[]>
  {
    return this.http.get<Company[]>(this.path+"GetMatchingCompanies/"+word);
  }
  public ExportStock()
  {
    return this.http.get<string>(this.path2+"ExportStock");
  }
  
}
