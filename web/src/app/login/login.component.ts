import { NgModule, CUSTOM_ELEMENTS_SCHEMA, Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'login-dialog',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  public minHeight = 250;
  public width = 400;

  public loginForm: FormGroup;
  public displayLogin = false;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      username: [ '', Validators.required],
      password: ['', Validators.required]
    })



  }



    public  openLoginDialog() {
    console.log('test');
    this.displayLogin = true;
  }

  public test(){

    console.log('here');
    

  }

}


