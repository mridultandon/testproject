import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class AppUrlService {
  public getApiUrl(): string {
    return environment.baseUrl;
}
  constructor() { }
}



