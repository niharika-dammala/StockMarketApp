import { Component, OnInit } from '@angular/core';
import {ImportexcelService  } from 'src/app/services/importexcel.service';
import { StockpriceService } from 'src/app/services/stockprice.service';
import { Stockprice } from 'src/app/models/stockprice';
import { Router } from '@angular/router';
@Component({
  selector: 'app-import-data',
  templateUrl: './import-data.component.html',
  styleUrls: ['./import-data.component.css']
})
export class ImportDataComponent implements OnInit {
  shortLink: string = "";
  loading: boolean = false; // Flag variable
  file: File ; // Variable to store file
stockList:Stockprice[];
  // Inject service 
  constructor(private importexcelService: ImportexcelService, private service:StockpriceService) { 
    this.service.GetStockprices().subscribe(i => {
        this.stockList = i;
        console.log(this.stockList);
  })
}

  ngOnInit(): void {
  }

  public ImportExcel()
  {
      
      this.importexcelService.ImportStock("hi");
  }
  // On file Select
  onChange(event:any) {
      this.file = event.target.files[0];
  }
  onUpload() {
    this.loading = !this.loading;
    console.log(this.file);
    this.importexcelService.upload(this.file).subscribe(
        (event: any) => {
            if (typeof (event) === 'object') {

                // Short link via api response
                this.shortLink = event.link;

                this.loading = false; // Flag variable 
            }
        }
    );
}
 

 

}
