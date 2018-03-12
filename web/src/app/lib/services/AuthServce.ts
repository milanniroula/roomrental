import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

@Injectable()
export class AuthService{

/**
 *
 */
constructor(private http:HttpClient) {
    
}

signup(url:string,model):Observable<any>{
    return this.http.post(url,model);
}

getRooms(url:string):Observable<any>{
    return this.http.get<any>(url,{ responseType: 'json' });
}

}