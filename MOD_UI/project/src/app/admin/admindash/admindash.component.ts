import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { UserServiceService } from 'src/app/Services/user-service.service';
import { User } from 'src/app/Models/user';
import { MentorServiceService } from 'src/app/Services/mentor-service.service';
import { Mentor } from 'src/app/Models/mentor';
import { TrainingserviceService } from 'src/app/Services/trainingservice.service';
import { Training } from 'src/app/Models/training';
import { PaymentserviceService } from 'src/app/Services/paymentservice.service';
import { Payment } from 'src/app/Models/payment';
import { TechnologyserviceService } from 'src/app/Services/technologyservice.service';
import { Technology } from 'src/app/Models/technology';

@Component({
  selector: 'app-admindash',
  templateUrl: './admindash.component.html',
  styleUrls: ['./admindash.component.css']
})
export class AdmindashComponent implements OnInit {
 //  router: any;
 list:User[];
  items:User;
 mlist:Mentor[];
 tlist:Training[];
 plist:Payment[];

 techlist: Technology[];
 item:Technology;
 msg:string;
 
 adminname='';
userclick;
mentorclick;
trainingclick;
technologyclick;
paymentclick;
addclick;
  constructor(private http: HttpClient, private router : Router,
     private _service: UserServiceService, private _Mservice : MentorServiceService, 
     private _Tservice : TrainingserviceService, private _Pservice : PaymentserviceService, 
     private _Techservice : TechnologyserviceService) { 
   this.adminname= localStorage.getItem('token');
   this.item= new Technology();
        this.userclick=0;
        this.mentorclick=0;
        this.addclick=0;
        this.trainingclick=0; this.technologyclick=0; this.paymentclick=0;
  }

  ngOnInit() {
    if(localStorage.getItem('token')==null)
   {
     this.router.navigate(['login']);
   }
  }
  public GetUser(){
    this._service.GetAllUsers().subscribe(k=>this.list=k);
    this.userclick=1;
    this.mentorclick=0;
    this.paymentclick=0;
    this.technologyclick=0;
    this.trainingclick=0;
  }
  public GetMentor(){
    this._Mservice.GetAllMentors().subscribe(k=>this.mlist=k);
    this.mentorclick=1;
    this.userclick=0;
    this.technologyclick=0;
    this.trainingclick=0;
    this.paymentclick=0;
  }
  public GetTraining(){
  this._Tservice.GetAllTraining().subscribe(k=>this.tlist=k)
  this.trainingclick=1;
  this.userclick=0;
  this.mentorclick=0;
  this.technologyclick=0;
  this.paymentclick=0;
  }
  public GetPayment() {
    this._Pservice.GetAllPayments().subscribe(k=>this.plist=k);
    this.paymentclick=1;
    this.userclick=0;
    this.mentorclick=0;
    this.technologyclick=0;
    this.trainingclick=0;

  }
  public GetTechnology(){
    this._Techservice.GetAllTechnology().subscribe(k=>this.techlist=k);
    this.technologyclick=1;
    this.userclick=0;
    this.mentorclick=0;
    this.trainingclick=0;
    this.paymentclick=0;

  }
  public AddClick()
  {
    this.addclick=1;
  }
  public AddTech(){
    this._Techservice.AddTechnology(this.item).subscribe(k=>this.msg=k);
 //  this.router.navigate(['adminlogin']);
  }

  public DelUser(id:number){
    this._service.DeleteUser(id).subscribe();
  }
  public DelMentor(id:number){
    this._Mservice.DeleteMentor(id).subscribe();
  }
  public DelTrain(id:number){
    this._Tservice.DeleteTraining(id).subscribe();
  }
  public DelTech(id:number){
    this._Techservice.DeleteTechnology(id).subscribe();
  }
  public BlockUser(id:number){
    this._service.BlockUser(id).subscribe();
  }
  public BlockMentor(id:number){
    this._Mservice.BlockMentor(id).subscribe();
  }
  logout(){
    localStorage.removeItem('token');
    this.router.navigate(['login']);
  
    }
  
}
