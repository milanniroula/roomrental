import { Component, OnInit, Output } from '@angular/core';
import { Subject } from 'rxjs/Subject';
import { Router } from '@angular/router';

@Component({
  selector: 'top-menu',
  templateUrl: './top-menu.component.html',
  styleUrls: ['./top-menu.component.scss']
})
export class TopMenuComponent implements OnInit {

  @Output() public onLogin: Subject<boolean> = new Subject<boolean>();

  constructor(private router: Router) { }

  ngOnInit() {
  }

  public onLoginClick() {


    this.onLogin.next(true);
  }

  public navigate(url) {
    console.log(url)
    this.router.navigateByUrl(url)

  }

}
