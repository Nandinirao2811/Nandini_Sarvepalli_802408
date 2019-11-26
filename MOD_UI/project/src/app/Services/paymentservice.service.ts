import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { Payment } from '../Models/payment';

@Injectable({
  providedIn: 'root'
})
export class PaymentserviceService {
  path: String = "http://localhost:50168/Payment"
  constructor(private _client : HttpClient) { }
  public GetAllPayments():Observable<Payment[]>
  {
    return this._client.get<Payment[]>(this.path+'/GetAllPayments');
  }
  public AddMentor(item:Payment):Observable<string>
  {
    return this._client.post<string>(this.path+'/AddPayment', item);
  }
}
