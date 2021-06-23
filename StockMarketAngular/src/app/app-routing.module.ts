import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserloginComponent } from './containers/userlogin/userlogin.component';
import { AppComponent } from './app.component';
import { ManageCompaniesComponent } from './containers/manage-companies/manage-companies.component';
import { StockexchangeComponent } from './containers/stockexchange/stockexchange.component';
import { SignupComponent } from './containers/signup/signup.component';
import { BarchartComponent } from './containers/barchart/barchart.component';
import { AdminloginComponent } from './containers/adminlogin/adminlogin.component';
import { UserviewCompaniesComponent } from './containers/userview-companies/userview-companies.component';
import { AppbaseComponent } from './containers/appbase/appbase.component';
import { AdminappComponent } from './containers/adminapp/adminapp.component';
import { UserappComponent } from './containers/userapp/userapp.component';
import { ImportDataComponent } from './containers/import-data/import-data.component';


const routes: Routes = [
  {path:'', component: AppbaseComponent},
  {path:'userlogin', component: UserloginComponent},
  {path:'signup', component: SignupComponent},
  {path:'managecompany', component: ManageCompaniesComponent},
  {path:'stockexchange', component: StockexchangeComponent},
  {path:'barchart', component: BarchartComponent},
  {path:'adminlogin', component: AdminloginComponent},
  {path:'userviewcompany', component: UserviewCompaniesComponent},
  {path:'appbase', component: AppbaseComponent},
  {path:'adminapp', component: AdminappComponent},
  {path:'userapp', component: UserappComponent},
  {path:'importdata',component:ImportDataComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
