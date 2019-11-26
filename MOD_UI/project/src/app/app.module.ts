import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserlogComponent } from './user/userlog/userlog.component';
import { UsersignupComponent } from './user/usersignup/usersignup.component';
import { MentorsignupComponent } from './mentor/mentorsignup/mentorsignup.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { EmailValidatorDirective } from './email-validator.directive';
import { PasswordValidatorDirective } from './password-validator.directive';
import { UserdashComponent } from './user/userdash/userdash.component';
import { UserServiceService } from './Services/user-service.service';
import { MentorServiceService } from './Services/mentor-service.service';
import { LoginServiceService } from './Services/login-service.service';
import { AdmindashComponent } from './admin/admindash/admindash.component';
import { SearchComponent } from './search/search/search.component';
import { SearchserviceService } from './Services/searchservice.service';
import { TrainingserviceService } from './Services/trainingservice.service';
import { PaymentserviceService } from './Services/paymentservice.service';
import { TechnologyserviceService } from './Services/technologyservice.service';
import { MentordashComponent } from './mentor/mentordash/mentordash.component';



@NgModule({
  declarations: [
    AppComponent,
   UserlogComponent,
   UsersignupComponent,
    MentorsignupComponent,
    EmailValidatorDirective,
    PasswordValidatorDirective,
   UserdashComponent,
   AdmindashComponent,
    SearchComponent,
    MentordashComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [UserServiceService, MentorServiceService, LoginServiceService, SearchserviceService, 
    TrainingserviceService, PaymentserviceService, TechnologyserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
