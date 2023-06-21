import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class DataService {
searchid:number=0;
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
  GetUserbyid(id:number|null){
    return this.http.get<any>('https://localhost:7050/api/UserInfo/getbyid/'+id)
  }
  GetAllUser(firstName:any):Observable<any>{
    return this.http.get<any>('${https://localhost:7050/api/UserInfo/GetAllUsers/'+firstName)
  }
  GetAllUser2(){
    return this.http.get<any>('https://localhost:7050/api/UserInfo/GetAllUsers')
  }
  UserInfo(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/Login',model)
  }
  Addfile(model:any){
    return this.http.post<any>('https://localhost:7050/api/Auth/Add_File',model)
  }
  UpdateUser(id:number,model:any){
    return this.http.put<any>('https://localhost:7050/api/UserInfo/'+id,model)
  }
  Getlocation(id:Number){
    return this.http.get<any>('https://localhost:7050/api/Location/'+id)
  }
  AddNewPost(id:Number|null,Model:any){
    return this.http.post<any>('https://localhost:7050/api/User_Post/'+id,Model)
  }
  GetPostsofuser(id:number|null){
    return this.http.get<any>('https://localhost:7050/api/User_Post/'+id)
  }




    getsearchid(id:number){
      this.searchid=id;
    }
}
