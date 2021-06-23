import { Component, OnInit } from '@angular/core';
import { Stockexchange } from 'src/app/models/stockexchange';
import { StockexchangeService } from 'src/app/services/stockexchange.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-stockexchange',
  templateUrl: './stockexchange.component.html',
  styleUrls: ['./stockexchange.component.css']
})
export class StockexchangeComponent implements OnInit {
  
  stockexchangeList: Stockexchange[];
  stockexchangeObject: Stockexchange;

  stockExchangeId: number;
  stockExchangeName: string;
  brief: string;
  address: string;
  remarks: string;

  errormsg: string;

  constructor(private service: StockexchangeService, private router: Router) { 
    this.service.GetStockexchanges().subscribe(i => {
      this.stockexchangeList = i;
      console.log(this.stockexchangeList);
    })
  }

  ngOnInit(): void {
  }

  public GetStockexchangeDetails() {
    this.service.GetStockexchangeDetails(this.stockExchangeId).subscribe(item => {
      console.log(item);
      this.stockexchangeObject = item;
      this.stockExchangeName = this.stockexchangeObject.stockExchangeName;
      this.brief = this.stockexchangeObject.brief;
      this.address = this.stockexchangeObject.address;
      this.remarks = this.stockexchangeObject.remarks;
      this.errormsg = "";
    })
  }

  public AddStockexchange() {
    this.stockexchangeObject = new Stockexchange();
    this.stockexchangeObject.stockExchangeId = this.stockExchangeId;
    this.stockexchangeObject.stockExchangeName = this.stockExchangeName;
    this.stockexchangeObject.brief = this.brief;
    this.stockexchangeObject.address = this.address;
    this.stockexchangeObject.remarks = this.remarks;

    this.service.AddStockexchange(this.stockexchangeObject).subscribe(response => {}, err =>  {
      console.log(err);
      console.log(err.error.text);
    })
  }

}
