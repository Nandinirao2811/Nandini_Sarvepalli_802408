import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { LoginServiceService } from 'src/app/Services/login-service.service';
import { Router } from '@angular/router';
import { User } from 'src/app/Models/user';



@Component({
  selector: 'app-userlog',
  templateUrl: './userlog.component.html',
  styleUrls: ['./userlog.component.css']
})
export class UserlogComponent implements OnInit {
  [x: string]: any;
  email;
  pwd;
  msg:string;
  userList : User[]=[];

  constructor(private http:HttpClient,private router:Router,private _service: LoginServiceService) { }

  ngOnInit() {
  }
  public Login()
  {
    this._service.Login(this.email,this.pwd).subscribe(data=>{
      console.log(data)
      if(data.message=='User')
      {
        console.log("HAHAHAHHAHAHA");
     //  console.log(data.token);
       //console.log(data.message);
       localStorage.setItem('token',data.token);
        this.router.navigate(['userdash'],{relativeTo:this._activatedRoute});
       
      }
      else if(data.message=='Mentor')
      {
        localStorage.setItem('token',data.token);
        this.router.navigate(['mentordash'],{relativeTo:this._activatedRoute});
        
        
      }
      else if(data.message =='Admin')
      {
        localStorage.setItem('token',data.token);
        this.router.navigate(['admindash'],{ relativeTo:this._activatedRoute});
      }
      else
      {
        console.log("Nothing found");
        this.msg ="Invalid data";
      }

    },
    err=>{
       console.log("subscribe err");
    });
  }

  
}

