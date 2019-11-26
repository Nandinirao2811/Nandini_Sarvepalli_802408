import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule} from '@angular/forms';
import { MentorsignupComponent } from './mentorsignup/mentorsignup.component';
import { RouterModule} from '@angular/router';
import { MentordashComponent } from './mentordash/mentordash.component';


@NgModule({
  declarations: [MentorsignupComponent ,MentordashComponent],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
      {path:'mentorsignup', component:MentorsignupComponent},
      {path: 'mentordash', component:MentordashComponent}
    ])

  ]
})
export class MentorModule { }
