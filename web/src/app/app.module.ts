import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
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
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { SignupComponent } from './signup/signup.component';
import { PanelModule } from 'primeng/panel';




@NgModule({
  declarations: [
    AppComponent,
    TopMenuComponent,
    LoginComponent,
    SignupComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    ButtonModule,
    DialogModule,
    PanelModule,
    RouterModule.forRoot(
      appRoutes // <-- debugging purposes only
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
