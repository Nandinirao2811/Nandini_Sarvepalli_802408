import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Mentor } from '../Models/mentor';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SearchserviceService {

  path: String = "http://localhost:50168/User"
  constructor(private _client : HttpClient) { }
  public SearchMentor(skill,fromTimeslot,toTimeslot): Observable<Mentor[]>
  {
    return this._client.get<Mentor[]>(this.path+'/GetMentorSearch/'+skill+'/'+fromTimeslot+'/'+toTimeslot);
  }
}
