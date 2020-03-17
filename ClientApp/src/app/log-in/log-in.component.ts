import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { UserInfo } from '../models/UserInfo.model';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  userInfo:UserInfo[]=[];
  constructor(private login: UserService) { }

  public ngOnInit(): void {
    this.login.fetchUserInfo(this.userInfo).subscribe((user:UserInfo[])=>{
      this.userInfo=user;
      console.log(this.userInfo);
    })
  }

}


