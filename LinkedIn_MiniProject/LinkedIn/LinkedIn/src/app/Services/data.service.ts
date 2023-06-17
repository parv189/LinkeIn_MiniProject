import { Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http';
import { OnInit } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http:HttpClient) { }
  userData:Array<any>=[]


  AddUser(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/register',model)
  }
  LoginUser(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/Login',model)

  }
  GetUser(Email:string|null){
    return this.http.get<any>('https://localhost:7050/api/UserInfo/'+Email)
  }
  UserInfo(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/Login',model)
  }
  UpdateUser(id:number,model:any){
    return this.http.put<any>('https://localhost:7050/api/UserInfo/'+id,model)
  }
}
