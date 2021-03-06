import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';


import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { CalculateComponent } from './calculate/calculate.component';
import { AuthService } from './_services/auth.service';


@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      CalculateComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [
      AuthService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
