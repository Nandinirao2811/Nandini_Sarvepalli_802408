import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { MentorServiceService } from 'src/app/Services/mentor-service.service';
import { TrainingserviceService } from 'src/app/Services/trainingservice.service';
import { Training } from 'src/app/Models/training';
import { User } from 'src/app/Models/user';
import { Mentor } from 'src/app/Models/mentor';

@Component({
  selector: 'app-mentordash',
  templateUrl: './mentordash.component.html',
  styleUrls: ['./mentordash.component.css']
})
export class MentordashComponent implements OnInit {
mentorName='';
  mentor_EmailId='';
  mentor_Password='';
  updatempassclick;
  curtrainingclick;
  lists:Training[];
  items:Training;
  item:Mentor;
  id:number;
  constructor(private router : Router, private http: HttpClient, private _Mservice : MentorServiceService,
   private _TrService : TrainingserviceService ) {
    this.id = +localStorage.getItem('token');
    this.updatempassclick=0; this.curtrainingclick=0;
    this.items = new Training();
    this.item = new Mentor();
    this.mentorName = this.item.mentor_FirstName,this.item.mentor_LastName;
    this._Mservice.GetMentorById(this.id).subscribe(k=>this.item=k);
   }

  ngOnInit() {
    if(localStorage.getItem('token')==null)
   {
          this.router.navigate(['login']);
   }
  }
  public UpdateMClick(){
    this.updatempassclick=1;
    this.curtrainingclick=0;
  }
  public UpdateMentor()
{
  this._Mservice.UpdateMentorPassword(this.mentor_EmailId, this.mentor_Password).subscribe();
}
public MentorCurTrainings()
{
  this._TrService.GetTrainingByMentorId(this.id).subscribe(k=>this.lists=k);
  this.curtrainingclick=1;
  this.updatempassclick=0;
}
  logout(){
    localStorage.removeItem('token');
    this.router.navigate(['login']);
  
    }

}
