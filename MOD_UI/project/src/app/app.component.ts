import { Component } from '@angular/core';
import { longStackSupport } from 'q';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'project';
  router: any;
  settok(){
    var set='';
    set=localStorage.getItem('token');
    if(set==null)
    {
      return 0;
    }
    else{
      return 1;
    }
  }
    logout(){
      localStorage.removeItem('token');
      this.router.navigate(['login']);
    }

    }

