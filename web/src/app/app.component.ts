import { Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  @ViewChild('loginDialog') public loginDialog;

  public activateLoginDialog() {
    this.loginDialog.openLoginDialog();
  }
}
