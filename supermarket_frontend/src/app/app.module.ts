import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminHeaderComponent } from './Layouts/Admin/admin-header/admin-header.component';
import { AdminMainComponent } from './Layouts/Admin/admin-main/admin-main.component';
import { AdminFooterComponent } from './Layouts/Admin/admin-footer/admin-footer.component';
import { CustomerHeaderComponent } from './Layouts/Customer/customer-header/customer-header.component';
import { CustomerMainComponent } from './Layouts/Customer/customer-main/customer-main.component';
import { CustomerFooterComponent } from './Layouts/Customer/customer-footer/customer-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminHeaderComponent,
    AdminMainComponent,
    AdminFooterComponent,
    CustomerHeaderComponent,
    CustomerMainComponent,
    CustomerFooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
