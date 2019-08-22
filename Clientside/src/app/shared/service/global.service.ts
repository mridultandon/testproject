import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/internal/operators/map';
import { finalize } from 'rxjs/internal/operators/finalize';

@Injectable({
  providedIn: 'root'
})
export class GlobalService {

  constructor(private http: HttpClient) { }

  post(url: string, data): Observable<any> {
    return this.http.post<any>(url, data).pipe(
      map((response) => response),
      finalize(() => {
      })
    );
  }

  get(url: string): Observable<any> {
    var headers = new HttpHeaders()
    headers.append("ContentType","application/json")
    return this.http.get<any>(url,{headers: headers});
  }

}
