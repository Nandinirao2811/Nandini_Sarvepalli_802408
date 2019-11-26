import { Component, OnInit } from '@angular/core';
import {User} from 'src/app/Models/user';
import { UserServiceService } from 'src/app/Services/user-service.service';

@Component({
  selector: 'app-usersignup',
  templateUrl: './usersignup.component.html',
  styleUrls: ['./usersignup.component.css']
})
export class UsersignupComponent implements OnInit  {
  item:User;
  list:User[];
  msg:string;
  
  constructor(private _service : UserServiceService) {
    this.item= new User();
    this._service.GetAllUsers().subscribe(k => this.list =k)
   }
 
    ngOnInit() {
    }
    public Add()
    {
      this.item.user_Active=true;
      this._service.AddUser(this.item).subscribe(k=>this.msg=k);
      //console.log(this.msg);
    }
       
  
  
  
 
}
