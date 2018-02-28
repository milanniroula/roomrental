import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs/Subject';

@Component({
  selector: 'top-menu',
  templateUrl: './top-menu.component.html',
  styleUrls: ['./top-menu.component.scss']
})
export class TopMenuComponent implements OnInit {

  public onLogin: Subject<boolean> = new Subject<boolean>();

  constructor() { }

  ngOnInit() {
  }

  onLoginClick() {
    this.onLogin.next(true);
  }

}
