
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppValidator } from '../lib/helpers/Validators';
import { AuthService } from '../lib/services/AuthServce';

@Component({
  selector: 'signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  public user: IUserRegistrationModel = { userName: '', password: '', phoneNumber: '', confirmPassword: '' };
  public userRegistrationForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private auth: AuthService) { }

  ngOnInit() {
    this.userRegistrationForm = this.formBuilder.group({

      userName: ['', [Validators.required, AppValidator.isEmailValid('Email') ]],
      phoneNumber: ['', [Validators.required, AppValidator.isValidPhoneNumber ]],
      password: ['', [Validators.required, Validators.pattern('((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})')]],
      confirmPassword: ['', [Validators.required, AppValidator.MatchPassword]]

    });
  }


  public signup(form) {
    const url = 'srv/api/rooms';
    this.auth.getRooms(url).subscribe(res => {
      console.log(res);
    });

  }

}

export interface IUserRegistrationModel {

  userName: string;
  phoneNumber: string;
  password: string;
  confirmPassword: string;
}
