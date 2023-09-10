import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class HttpService {
  apiUrl = "/mailinglist";
  constructor(private httpClient: HttpClient) { }

  get() {
    this.httpClient.get<string>(this.apiUrl).subscribe(result => {
      console.log(result);
    })
  }
  sendPostRequest(data: Object): Observable<Object> {
    return this.httpClient.post(this.apiUrl, data)
  }
}
