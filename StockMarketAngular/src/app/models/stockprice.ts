import { Time } from '@angular/common';
import { Timestamp } from 'rxjs';

export class Stockprice {
    stockPriceId: number=0;
    companyCode: number=0;
    stockExchangeId: number=0;
    currentPrice: number=0;
    date: Date;
    time: Date;
}
