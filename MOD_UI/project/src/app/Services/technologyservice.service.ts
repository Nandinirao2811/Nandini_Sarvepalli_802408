import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { Technology } from '../Models/technology';


@Injectable({
  providedIn: 'root'
})
export class TechnologyserviceService {
  path: String = "http://localhost:50168/Technology"
  constructor(private _client : HttpClient) { }
  public GetAllTechnology():Observable<Technology[]>
  {
    return this._client.get<Technology[]>(this.path+'/GetAllTechnology');
  }
  public DeleteTechnology(id:number)
  {
    return this._client.delete(this.path+'/DeleteTechnology/'+id);
  }
  public AddTechnology(item:Technology):Observable<string>
  {
    return this._client.post<string>(this.path+'/AddTechnology',item);
  }
}
