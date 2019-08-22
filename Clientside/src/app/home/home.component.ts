import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AppUrlService } from '../shared/service/app-url.service';
import { LoginService } from '../login/login.service';
import { Path } from '../shared/path';
import { RequestModel } from '../models/request';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  userType: string;
  requestModel: RequestModel = {};
  requestList: RequestModel[] = [];
  userId: number;
  constructor(private route: Router, private appurl: AppUrlService, private loginService: LoginService) {
  }

  ngOnInit() {
    this.userId = Number(localStorage.getItem('userId'));
    this.userType = localStorage.getItem('userType');
    this.GetReqList();
  }

  GetReqList() {
    this.loginService.Get(this.appurl.getApiUrl() + Path.API_GetList).subscribe(data => {
      this.requestList = data;
      console.log(data);
    }, err => {
      console.log(err);
    });
  }
  addRequest() {
    this.requestModel.isApproved = false;
    this.requestModel.UserId = this.userId;
    this.loginService.Post(this.appurl.getApiUrl() + Path.API_ADDREQUEST, this.requestModel).subscribe(res => {
      console.log(res);
      this.requestList.unshift(this.requestModel);
      this.requestModel = {};
    });
  }
  updateRequest(id, type) {
    this.requestModel.requestId = id;
    if (type === 0) {
      this.requestModel.isApproved = false;
    } else {
      this.requestModel.isApproved = true;
    }
    this.loginService.Post(this.appurl.getApiUrl() + Path.API_UPDATEREQUEST, this.requestModel).subscribe(res => {
      console.log(res);
      const index = this.requestList.findIndex(x => x.requestId === id);
      this.requestList[index].isApproved = res.isApproved;
    });
  }

  Logout() {
    this.route.navigate(['/login']);
  }

}
