import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';



import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { PersonModule } from './person/person.module';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PersonModule,
    BrowserAnimationsModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
