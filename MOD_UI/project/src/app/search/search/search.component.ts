import { Component, OnInit } from '@angular/core';
import { SearchserviceService } from 'src/app/Services/searchservice.service';
import { Mentor } from 'src/app/Models/mentor';
import { HttpClient } from '@angular/common/http';
import { TrainingserviceService } from 'src/app/Services/trainingservice.service';
import { Training } from 'src/app/Models/training';
import { Technology } from 'src/app/Models/technology';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  item:Mentor;
  list:Mentor[];
  skill;
  fromTimeslot;
  toTimeslot;
  items:Training;
  lists:Training[];
  itemm:Technology;


  constructor(private _service : SearchserviceService, private http: HttpClient,
     private _TrService : TrainingserviceService, ) {
    
   }
 
  ngOnInit() {
  }
  public Search()
  {
    this._service.SearchMentor(this.skill,this.fromTimeslot,this.toTimeslot).subscribe(k=>this.list=k);
    console.log(this.item)

}
public subMentor(mentor_Id:number){
  this.items.user_Id= +localStorage.getItem("token");
  this.items.mentor_Id=mentor_Id;
  this.items.skill_Id=this.itemm.skill_Id;
//  this.items.training_StartDate= this.item.mentor_FromTimeSlot;
 // this.items.training_EndDate= this.item.mentor_ToTimeSlot;

this._TrService.AddTraining(this.items);
console.log("items");
}

}
