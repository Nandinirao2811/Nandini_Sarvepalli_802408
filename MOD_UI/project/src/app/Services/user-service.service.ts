import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {User} from '../Models/user';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  path: String = "http://localhost:50168/User"
  constructor(private _client : HttpClient) { }
  public GetAllUsers():Observable<User[]>
  {
    return this._client.get<User[]>(this.path+'/GetAllUsers');
  }
  public GetUserById(id:number):Observable<User>
  {
    return this._client.get<User>(this.path+'/GetUserById/'+id)
  }
  public AddUser(item:User):Observable<string>
  {
    return this._client.post<string>(this.path+'/AddUser', item);
  }
  public UpdateUserPassword(email, pwd)
  {
    return this._client.put(this.path+'/UpdateUserPassword/'+email+'/'+pwd, email,pwd);
  }
  public DeleteUser(id:number)
  {
    return this._client.delete(this.path+'/DeleteUser/'+id);
  }
  public BlockUser(id:number)
  {
    return this._client.put(this.path+'/BlockUser/'+id, id);
  }
}
