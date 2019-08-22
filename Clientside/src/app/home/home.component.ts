import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AppUrlService } from '../shared/service/app-url.service';
import { LoginService } from '../login/login.service';
import { Path } from '../shared/path';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  userType: string;
  userList: any[];
  constructor(private route: ActivatedRoute, private appurl: AppUrlService, private loginService: LoginService) {
    //this.userType = this.route.snapshot.paramMap.get('id');
    //console.log(this.userType);
  }

  ngOnInit() {
    var uId = localStorage.getItem('userId');
    this.userType = localStorage.getItem('userType');
    this.GetUserList();
  }

  GetUserList() {
    this.loginService.Get(this.appurl.getApiUrl() +Path.API_GetList).subscribe(data=>{
    this.userList = data;
    }, err=>{
      console.log(err);
    });
  }

}
