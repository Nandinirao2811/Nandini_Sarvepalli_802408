import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Mentor} from '../Models/mentor';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MentorServiceService {

  path: String = "http://localhost:50168/Mentor"
  constructor(private _client : HttpClient) { }
  public GetAllMentors():Observable<Mentor[]>
  {
    return this._client.get<Mentor[]>(this.path+'/GetAllMentors');
  }
  public AddMentor(item:Mentor):Observable<string>
  {
    return this._client.post<string>(this.path+'/AddMentor', item);
  }
  public GetMentorById(id:number): Observable<Mentor>
  {
    return this._client.get<Mentor>(this.path+'/GetMentorById/'+id);
  }
  public UpdateMentorPassword(email,pwd)
  {
    return this._client.put(this.path+'/UpdateMentorPassword/'+email+'/'+pwd, email,pwd);

  }
  public DeleteMentor(id:number)
  {
    return this._client.delete(this.path+'/DeleteMentor/'+id);
  }
  public BlockMentor(id:number)
  {
    return this._client.put(this.path+'/BlockMentor/'+id, id);
  }
}
