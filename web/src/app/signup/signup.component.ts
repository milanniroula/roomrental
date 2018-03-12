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

      userName: ['', [Validators.required]],
      phoneNumber: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.minLength(4)]],
      confirmPassword: ['', [Validators.required]]

    });
  }


  public signup(form) {
    let url = "srv/api/rooms";
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
