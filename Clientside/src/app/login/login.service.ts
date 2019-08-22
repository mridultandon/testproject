import { Injectable } from '@angular/core';
import { GlobalService } from '../shared/service/global.service';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private globalService: GlobalService) { }

  Post(url: string, data) {
    return this.globalService.post(url, data);
  }

  Get(url): Observable<any> {
    return this.globalService.get(url);
  }
}
