import { AbstractControl } from '@angular/forms';


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

    public static PhoneNumber(AC: AbstractControl) {
        const phoneNumber = AC.value;
        const regex = new RegExp('[0-9]{10}');
        return (regex.test(phoneNumber)) ? null : { validPhoneNumber: false };

    }
}

