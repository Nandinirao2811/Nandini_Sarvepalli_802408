import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { UserServiceService } from 'src/app/Services/user-service.service';
import { User } from 'src/app/Models/user';
import { TrainingserviceService } from 'src/app/Services/trainingservice.service';
import { Training } from 'src/app/Models/training';

@Component({
    selector: 'app-userdash',
    templateUrl: './userdash.component.html',
    styleUrls: ['./userdash.component.css']
  })
  export class UserdashComponent implements OnInit {
Username='';
id:number;
item:User;
user_Email:'';
user_Password:'';
updatepassclick;
curtrainingclick;
items:Training;
lists:Training[];


  constructor(private http: HttpClient, private router : Router, private _service: UserServiceService,
    private _TrService : TrainingserviceService) { 
  this.updatepassclick=0; this.curtrainingclick=0;
    this.id = +localStorage.getItem('token');
    this.items = new Training();
    this.item = new User();
    this.Username = this.item.user_Name;
    this._service.GetUserById(this.id).subscribe(k=>this.item=k);
    
  }


  ngOnInit() {
   if(localStorage.getItem('token')==null)
   {
     this.router.navigate(['login']);
   }
}

public UserCurTrainings(){
  this._TrService.GetTrainingByUserId(this.id).subscribe(k=>this.lists=k);
  this.curtrainingclick=1;
  this.updatepassclick=0;
}

public UpdateClick(){
  this.updatepassclick=1;
  this.curtrainingclick=0;
}
public UpdateUser()
{
  this._service.UpdateUserPassword(this.user_Email, this.user_Password).subscribe();
}  

  logout(){
  localStorage.removeItem('token');
  this.router.navigate(['login']);

  }
  }