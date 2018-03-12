
import { AbstractControl, ValidationErrors } from '@angular/forms';
import { reject, Promise, resolve } from 'q';



export class AppValidator {
    public static MatchPassword(AC: AbstractControl) {
        const password = AC.value; // to get value in input tag

        const confirmPassword = AC.root.get('password') // to get value in input tag

        if (!!confirmPassword && (password !== confirmPassword.value)) {
            return { 'mismatch': true }
        } else {
            return null
        }
    }

/*
  // simulation to server
        // assume username is dipendra or rajesh it is taken otherwise it should be unique
    public static shouldBeUnique( control: AbstractControl): Promise<ValidationErrors | null> {
        console.log('test');
      // tslint:disable-next-line:no-shadowed-variable
      return Promise((resolve, reject) => {
        setTimeout(() => {
          if (control.value === 'dipendra123p@yahoo.com') {
            return resolve({shouldBeUnique: true });
          } else {
                resolve (null);
            }
          }, 2000);


      });
    }
    */

    static isEmailValid(control) {
      // tslint:disable-next-line:no-shadowed-variable
      return control => {
        const regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
        return regex.test(control.value) ? null : { invalidEmail: true };
      }
    }

    // validates the australian phone numbers only with these formats
    /**  // Valid
        var phoneNumber1 = "0411 234 567";
        var phoneNumber2 = "(02) 3892 1111";
        var phoneNumber3 = "38921111";
        var phoneNumber4 = "0411234567";

 */
    static isValidPhoneNumber(control) {
      const phoneNumber = control. value;
      const regex = /^\({0,1}((0|\+61)(2|4|3|7|8)){0,1}\){0,1}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{1}(\ |-){0,1}[0-9]{3}$/;
      return ( regex.test(phoneNumber)) ? null : { isValidPhoneNumber: true}


    }

  }

