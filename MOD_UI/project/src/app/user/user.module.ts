import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserlogComponent } from './userlog/userlog.component';
import { FormsModule} from '@angular/forms';
import { UsersignupComponent } from './usersignup/usersignup.component';
import {RouterModule} from '@angular/router';
import { UserdashComponent } from './userdash/userdash.component';




@NgModule({
  declarations: [UserlogComponent, UsersignupComponent, UserdashComponent],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
    //  {path:'userlogin', component: UserlogComponent},
      {path:'usersignup', component:UsersignupComponent},
      { path:'userdash', component:UserdashComponent}
    ])
  ]
})
export class UserModule { }
