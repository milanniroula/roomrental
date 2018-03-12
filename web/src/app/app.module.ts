import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

// components
import { AppComponent } from './app.component';
import { TopMenuComponent } from './components/top-menu/top-menu.component';
import { LoginComponent } from './login/login.component';


// services and misc
import { appRoutes } from './routes';


// third party

import {ButtonModule} from 'primeng/button';
import {DialogModule} from 'primeng/dialog';
import { SignupComponent } from './signup/signup.component';
import { PanelModule } from 'primeng/panel';
import {InputTextModule} from 'primeng/inputtext';




@NgModule({
  declarations: [
    AppComponent,
    TopMenuComponent,
    LoginComponent,
    SignupComponent,

  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],

  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    ButtonModule,
    DialogModule,
    PanelModule,
    InputTextModule,
    RouterModule.forRoot(
      appRoutes // <-- debugging purposes only
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
