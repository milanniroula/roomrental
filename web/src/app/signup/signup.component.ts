import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppValidator } from '../lib/helpers/Validators';

@Component({
  selector: 'signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  public user: IUserRegistrationModel = { userName: '', password: '', phoneNumber: '', confirmPassword: '' };
  public userRegistrationForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.userRegistrationForm = this.formBuilder.group({

      userName: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(10), AppValidator.PhoneNumber]],
      password: ['', [Validators.required, Validators.minLength(4)]],
      confirmPassword: ['', [Validators.required, Validators.minLength(4), AppValidator.MatchPassword]]

    });
  }


  public signup(form) {

  }

}

export interface IUserRegistrationModel {

  userName: string;
  phoneNumber: string;
  password: string;
  confirmPassword: string;
}
