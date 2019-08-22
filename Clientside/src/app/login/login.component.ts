import { Component, OnInit } from '@angular/core';
import { loginmodel } from './model/loginmodel';
import { LoginService } from './login.service';
import { Path } from '../shared/path';
import { AppUrlService } from '../shared/service/app-url.service';
import { RouterLink,RouterModule, Routes, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {
  loginForm: any;
  loginModel: loginmodel = {}
  constructor( private route: Router, private appurl: AppUrlService, private loginService: LoginService) { }

  ngOnInit() {
    this.initForm();
  }

  initForm() {
    this.loginForm = {
      userName: '',
      password: '',
      userType: 0
    };
  }
 
  login() {
    debugger
    this.loginModel.UserName = this.loginForm.userName;
    this.loginModel.Password = this.loginForm.password;    
    this.loginService.Post(this.appurl.getApiUrl() +Path.API_Login, this.loginModel).subscribe(data=>{
      localStorage.setItem('userId', data.userId);
      localStorage.setItem('userType', data.userType);
      this.route.navigate(['/home']);
      //this.loginForm.userType = data.userType;
     
    }, err=>{
      console.log(err);
    });
  }
 
}
