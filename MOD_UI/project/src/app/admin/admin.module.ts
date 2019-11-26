import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FormsModule} from '@angular/forms';
import {RouterModule} from '@angular/router';
import { AdmindashComponent } from './admindash/admindash.component';



@NgModule({
  declarations: [ AdmindashComponent],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
     
      {path:'admindash', component: AdmindashComponent}
    ])
  ]
})
export class AdminModule { }
