import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ImportexcelService {
  baseApiUrl = "https://file.io"
  path2:string="https://localhost:44351/api/ImportExcel/"
  constructor(private http:HttpClient) { }
  upload(file:any):Observable<any> {
  
    // Create form data
    const formData = new FormData(); 
      
    // Store form name as "file" with file data
    formData.append("file", file, file.name);
      console.log(file.name);
      console.log(file);
    // Make http post request over api
    // with formData as req
    return this.http.post(this.baseApiUrl, formData)
}
public ImportStock(s:string)
  {
    return this.http.post(this.path2+"ImportStock/",s);
  }
}
