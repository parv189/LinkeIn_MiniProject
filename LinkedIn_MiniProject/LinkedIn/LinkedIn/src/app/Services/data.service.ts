import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class DataService {
  constructor(private http:HttpClient) { }



  AddUser(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/register',model)
  }
  LoginUser(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/Login',model)
  }
}
