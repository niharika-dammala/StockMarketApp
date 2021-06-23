import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ChartsModule } from "ng2-charts";

import { UserloginComponent } from './containers/userlogin/userlogin.component';
import { ManageCompaniesComponent } from './containers/manage-companies/manage-companies.component';
import { CompanyService } from './services/company.service';
import { StockexchangeComponent } from './containers/stockexchange/stockexchange.component';
import { StockexchangeService } from './services/stockexchange.service';
import { StockpriceService } from './services/stockprice.service';
import { ComparisonService } from './services/comparison.service';
import { UserService } from './services/user.service';
import { SignupComponent } from './containers/signup/signup.component';
import { BarchartComponent } from './containers/barchart/barchart.component';
import { AdminloginComponent } from './containers/adminlogin/adminlogin.component';
import { UserviewCompaniesComponent } from './containers/userview-companies/userview-companies.component';
import { AppbaseComponent } from './containers/appbase/appbase.component';
import { AdminappComponent } from './containers/adminapp/adminapp.component';
import { UserappComponent } from './containers/userapp/userapp.component';
import { NgApexchartsModule } from "ng-apexcharts";
import { ImportDataComponent } from './containers/import-data/import-data.component';
import { ImportexcelService } from './services/importexcel.service';
@NgModule({
  declarations: [
    AppComponent,
   UserloginComponent,
    ManageCompaniesComponent,
    StockexchangeComponent,
    SignupComponent,
    BarchartComponent,
    AdminloginComponent,
    UserviewCompaniesComponent,
    AppbaseComponent,
    AdminappComponent,
    UserappComponent,
    ImportDataComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ChartsModule,
    NgApexchartsModule
  ],
  providers: [CompanyService,StockexchangeService,StockpriceService,UserService,ComparisonService,UserService,ImportexcelService],
  //providers: [CompanyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
