import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Training} from '../Models/training';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TrainingserviceService {
  path: String = "http://localhost:50168/Training"
  constructor(private _client : HttpClient) { }
  public GetAllTraining():Observable<Training[]>
  {
    return this._client.get<Training[]>(this.path+'/GetAllTraining');
  }
  public AddTraining(item:Training):Observable<string>
  {
    return this._client.post<string>(this.path+'/AddTraining', item);
  }
  public UpdateTraining(item:Training)
  {
    return this._client.put(this.path+'/UpdateTraining', item);
  }
  public DeleteTraining(id:number)
  {
    return this._client.delete(this.path+'/DeleteTraining/'+id);
  }
  public GetTrainingByUserId(id:number):Observable<Training[]>
  {
   return this._client.get<Training[]>(this.path+'/GetTrainingByUserId/'+id);
  }
  public GetTrainingByMentorId(id:number):Observable<Training[]>
  {
    return this._client.get<Training[]>(this.path+'/GetTrainingByMentorId/'+id);
  }
}
