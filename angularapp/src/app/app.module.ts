import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RoutingModule } from './routing/routing.module';
import { AppComponent } from './app.component';
import { ConfirmationComponent } from './confirmation/confirmation.component';
import { AddUsersComponent } from './addusers/addusers.component';

@NgModule({
  declarations: [
    AppComponent,
    ConfirmationComponent,
    AddUsersComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule, RoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
