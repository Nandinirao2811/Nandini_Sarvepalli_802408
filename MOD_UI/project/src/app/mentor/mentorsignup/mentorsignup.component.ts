import { Component, OnInit } from '@angular/core';
import {Mentor} from 'src/app/Models/mentor';
import { MentorServiceService } from 'src/app/Services/mentor-service.service';

@Component({
  selector: 'app-mentorsignup',
  templateUrl: './mentorsignup.component.html',
  styleUrls: ['./mentorsignup.component.css']
})
export class MentorsignupComponent implements OnInit {
  item:Mentor;
  list:Mentor[];
  msg:string;
  
  constructor(private _service : MentorServiceService) {
    this.item= new Mentor();
    this._service.GetAllMentors().subscribe(k=>this.list=k)
   }
  
  ngOnInit() {
  }
  public Add()
  {
    this.item.mentor_Active=true;
    this._service.AddMentor(this.item).subscribe(k=>this.msg=k);
  }
 
  
}
