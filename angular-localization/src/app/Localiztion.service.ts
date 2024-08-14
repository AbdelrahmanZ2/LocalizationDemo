import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LocaliztionService {

constructor(private http: HttpClient) { }
baseUrl: string = 'http://localhost:5029/Page';

getLayout(){
    return this.http.get<any>(this.baseUrl + `?PageId=1&Language=JP`);
  }

  getlabelsByKeys(keys:string[]){
    return this.http.post<any>(this.baseUrl + `/GetValuesByKeys`,keys);
  }

}
