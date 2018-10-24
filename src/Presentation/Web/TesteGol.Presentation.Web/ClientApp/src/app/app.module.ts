import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from "@angular/forms";
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { AirplaneComponent } from './list-airplane/list-airplane.component';
import { AirplaneService } from '../services/airplaneservice';
import { AddAirplaneComponent } from './add-airplane/add-airplane.component';
import { EditAirplaneComponent } from './edit-airplane/edit-airplane.component';
import { NgxMaskModule } from 'ngx-mask';
import { MomentModule } from 'ngx-moment';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AirplaneComponent,
    AddAirplaneComponent,
    EditAirplaneComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MomentModule,
    NgxMaskModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'list-airplane', component: AirplaneComponent },
      { path: 'add-airplane', component: AddAirplaneComponent },
      { path: 'edit-airplane', component: EditAirplaneComponent },
    ])
  ],
  providers: [AirplaneService],
  bootstrap: [AppComponent]
})
export class AppModule { }
