import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UsersignupComponent } from './user/usersignup/usersignup.component';
import { MentorsignupComponent } from './mentor/mentorsignup/mentorsignup.component';
import { UserlogComponent } from './user/userlog/userlog.component';
import { UserdashComponent } from './user/userdash/userdash.component';
import { MentordashComponent } from './mentor/mentordash/mentordash.component';
import { AdmindashComponent } from './admin/admindash/admindash.component';
import { SearchComponent } from './search/search/search.component';






const routes: Routes = [
  {path:'login', component:UserlogComponent},
  {path:'usersignup',component:UsersignupComponent},  
   {path: 'mentorsignup', component:MentorsignupComponent},
   { path:'userdash', component:UserdashComponent},
   {path:'mentordash', component:MentordashComponent},
   {path:'admindash', component: AdmindashComponent},
   {path:'search', component:SearchComponent}
 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
