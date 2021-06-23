import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaderResponse } from "@angular/common/http";
import { Observable } from "rxjs";
import { Stockexchange } from '../models/stockexchange';

@Injectable({
  providedIn: 'root'
})
export class StockexchangeService {
  path: string = "https://localhost:44340/api/Stockexchange/"

  constructor(private http: HttpClient) { }

  public GetStockexchanges(): Observable<Stockexchange[]>
  {
    return this.http.get<Stockexchange[]>(this.path+"GetStockexchanges")
  }
  
  public GetStockexchangeDetails(id:number): Observable<any>
  {
    console.log(id);
    return this.http.get<any>(this.path+'GetStockexchangeDetails/'+id)
  }

  public AddStockexchange(item:Stockexchange)
  {
    console.log(item);
    return this.http.post(this.path+"AddStockexchange/",item);
  }
}
