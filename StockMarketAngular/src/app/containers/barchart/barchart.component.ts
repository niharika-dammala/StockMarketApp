import { Component, OnInit } from '@angular/core';
import { Time } from "@angular/common";
import { Stockprice } from "src/app/models/stockprice";
import { StockpriceService } from "src/app/services/stockprice.service";
import { Router } from "@angular/router";

@Component({
  selector: 'app-barchart',
  templateUrl: './barchart.component.html',
  styleUrls: ['./barchart.component.css']
})

export class BarchartComponent implements OnInit {
  stockpriceObject: Stockprice;
  stockpriceList:Array<any>;

  stockpriceList2 = [{"stockpriceId":1,"companyCode":500113,"stockExchangeId":1,"currentPrice":256.23,"date":"2019-06-08T00:00:00","time":{"ticks":378000000000,"days":0,"hours":10,"milliseconds":0,"minutes":30,"seconds":0,"totalDays":0.4375,"totalHours":10.5,"totalMilliseconds":37800000,"totalMinutes":630,"totalSeconds":37800},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":3,"companyCode":500113,"stockExchangeId":1,"currentPrice":261.31,"date":"2019-06-08T00:00:00","time":{"ticks":381000000000,"days":0,"hours":10,"milliseconds":0,"minutes":35,"seconds":0,"totalDays":0.4409722222222222,"totalHours":10.583333333333334,"totalMilliseconds":38100000,"totalMinutes":635,"totalSeconds":38100},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":4,"companyCode":500113,"stockExchangeId":1,"currentPrice":258.12,"date":"2019-06-08T00:00:00","time":{"ticks":384000000000,"days":0,"hours":10,"milliseconds":0,"minutes":40,"seconds":0,"totalDays":0.4444444444444444,"totalHours":10.666666666666666,"totalMilliseconds":38400000,"totalMinutes":640,"totalSeconds":38400},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":5,"companyCode":500112,"stockExchangeId":1,"currentPrice":356.23,"date":"2019-06-08T00:00:00","time":{"ticks":378000000000,"days":0,"hours":10,"milliseconds":0,"minutes":30,"seconds":0,"totalDays":0.4375,"totalHours":10.5,"totalMilliseconds":37800000,"totalMinutes":630,"totalSeconds":37800},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":6,"companyCode":500112,"stockExchangeId":1,"currentPrice":361.31,"date":"2019-06-08T00:00:00","time":{"ticks":381000000000,"days":0,"hours":10,"milliseconds":0,"minutes":35,"seconds":0,"totalDays":0.4409722222222222,"totalHours":10.583333333333334,"totalMilliseconds":38100000,"totalMinutes":635,"totalSeconds":38100},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":7,"companyCode":500112,"stockExchangeId":1,"currentPrice":358.12,"date":"2019-06-08T00:00:00","time":{"ticks":384000000000,"days":0,"hours":10,"milliseconds":0,"minutes":40,"seconds":0,"totalDays":0.4444444444444444,"totalHours":10.666666666666666,"totalMilliseconds":38400000,"totalMinutes":640,"totalSeconds":38400},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":8,"companyCode":500112,"stockExchangeId":1,"currentPrice":357.09,"date":"2019-06-08T00:00:00","time":{"ticks":387000000000,"days":0,"hours":10,"milliseconds":0,"minutes":45,"seconds":0,"totalDays":0.4479166666666667,"totalHours":10.75,"totalMilliseconds":38700000,"totalMinutes":645,"totalSeconds":38700},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":9,"companyCode":500112,"stockExchangeId":1,"currentPrice":353.62,"date":"2019-06-08T00:00:00","time":{"ticks":390000000000,"days":0,"hours":10,"milliseconds":0,"minutes":50,"seconds":0,"totalDays":0.4513888888888889,"totalHours":10.833333333333334,"totalMilliseconds":39000000,"totalMinutes":650,"totalSeconds":39000},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":10,"companyCode":500112,"stockExchangeId":1,"currentPrice":349.56,"date":"2019-06-08T00:00:00","time":{"ticks":393000000000,"days":0,"hours":10,"milliseconds":0,"minutes":55,"seconds":0,"totalDays":0.4548611111111111,"totalHours":10.916666666666666,"totalMilliseconds":39300000,"totalMinutes":655,"totalSeconds":39300},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":11,"companyCode":500112,"stockExchangeId":1,"currentPrice":351.43,"date":"2019-06-08T00:00:00","time":{"ticks":396000000000,"days":0,"hours":11,"milliseconds":0,"minutes":0,"seconds":0,"totalDays":0.4583333333333333,"totalHours":11,"totalMilliseconds":39600000,"totalMinutes":660,"totalSeconds":39600},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":12,"companyCode":500112,"stockExchangeId":1,"currentPrice":350.12,"date":"2019-06-08T00:00:00","time":{"ticks":399000000000,"days":0,"hours":11,"milliseconds":0,"minutes":5,"seconds":0,"totalDays":0.4618055555555556,"totalHours":11.083333333333334,"totalMilliseconds":39900000,"totalMinutes":665,"totalSeconds":39900},"companyCodeNavigation":null,"stockExchange":null},{"stockpriceId":13,"companyCode":500112,"stockExchangeId":1,"currentPrice":348.91,"date":"2019-06-08T00:00:00","time":{"ticks":402000000000,"days":0,"hours":11,"milliseconds":0,"minutes":10,"seconds":0,"totalDays":0.4652777777777778,"totalHours":11.166666666666666,"totalMilliseconds":40200000,"totalMinutes":670,"totalSeconds":40200},"companyCodeNavigation":null,"stockExchange":null}];

  priceList: number[] = [];
  timeList: string[] = [];

  stockPriceId: number=0;
  companyCode: number = 0;
  stockExchangeId: number=0;
  currentPrice: number=0;
  date: Date;
  time: Date;

  showGraph: boolean = false;
  errmsg: string = "";

  barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: true
  };

  barChartLabels = this.timeList;
  barChartType = 'bar';
  barChartLegend = true;
  barChartData = [
    {data: this.priceList, label: this.companyCode.toString()}
  ];

  // constructor(private service: StockpriceService, private router: Router) { 
  //   /*this.service.GetStockprices(this.companyCode).subscribe(i => {
  //     this.stockpriceList = i;
  //     console.log(this.stockpriceList);

  //     /*this.stockpriceList.forEach(element => {
  //       this.priceList.push(element.currentPrice);
  //       console.log(this.priceList);
  //       //this.timeList.push("A"); //element.time.getTime().toString());
  //         //this.timeList.push(element.date.getHours().toLocaleString()+":"+element.date.getMinutes().toLocaleString());
  //       this.timeList.push(element.time.hours.toString()+":"+element.time.minutes.toString()+":"+element.time.seconds.toString());
  //       console.log(this.timeList);
  //       });
  //   });*/
  // }

  ngOnInit() {  
  }

  // public GetGraph() {
  //   this.timeList = [];
  //   this.priceList = [];
    
  //   // this.service.GetStockprices(this.companyCode).subscribe(i => {
  //   //   this.stockpriceList = i;
  //   //   //console.log(this.stockpriceList);

  //   //   this.stockpriceList.forEach(element => {
  //   //     this.priceList.push(element.currentPrice);
  //   //     console.log(this.priceList);
  //   //     this.timeList.push(element.time.hours.toString()+":"+element.time.minutes.toString()+":"+element.time.seconds.toString());
  //   //     console.log(this.timeList);
  //   //   });
      
  //     //console.log(this.companyCode);
  //     //console.log(this.priceList);
  //     //console.log(this.timeList);
  
  //     this.barChartOptions = {
  //       scaleShowVerticalLines: false,
  //       responsive: true
  //     };
    
  //     this.barChartLabels = this.timeList;
  //     this.barChartType = 'bar';
  //     this.barChartLegend = true;
  //     this.barChartData = [
  //       {data: this.priceList, label: this.companyCode.toString()}
  //     ];
  
  //     this.showGraph = true;
  //   });    
  // }
}