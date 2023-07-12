import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { user, ownposts, posts, like } from '../Models/PostLikes.model';
@Injectable({
  providedIn: 'root'
})
export class DataService {
searchid:number=0;
  constructor(private http:HttpClient) { }
  userData:Array<any>=[]
  baseURL = 'https://localhost:7050/api';


  AddUser(model:any){
    return this.http.post<any>(this.baseURL+'/Auth/register',model)
  }
  LoginUser(model:any){
    return this.http.post<any>(this.baseURL+'/Auth/Login',model)

  }
  GetUser(Email:string|null){
    return this.http.get<any>(this.baseURL+'/UserInfo/'+Email)
  }
  GetUserbyid(id:number|null){
    return this.http.get<any>(this.baseURL+'/UserInfo/getbyid/'+id)
  }
  // GetAllUser(firstName:any):Observable<any>{
  //   return this.http.get<any>(this.baseURL+'/UserInfo/GetAllUsers/'+firstName)
  // }
  GetAllUsers(){
    return this.http.get<any>(this.baseURL+'/UserInfo/GetAllUsers')
  }
  // UserInfo(model:any){
  //   return this.http.post<any>(this.baseURL+'/Auth/Login',model)
  // }
  Addfile(model:any){                                                                          //Subscribed in Post_Components/add-post/add-post.component.ts and Components/update-profile/update-profile.component.ts
    return this.http.post<any>(this.baseURL+'/Auth/Add_File',model)
  }
  UpdateUser(id:number,model:any){                                                             //Subscribed in Components/update-profile/update-profile.component.ts
    return this.http.put<any>(this.baseURL+'/UserInfo/'+id,model)
  }
  Getlocation(id:Number){                                                                      //Subscribed in Components/update-profile/update-profile.component.ts
    return this.http.get<any>(this.baseURL+'/Location/'+id)
  }
  AddNewPost(id:Number|null,Model:any){                                                        //Subscribed in Post_Components/add-post/add-post.component.ts
    return this.http.post<any>(this.baseURL+'/User_Post/'+id,Model)
  }
  GetPostsofuser(id:number|null){                                                              //Subscribed in otherUser/show-profile-of-other-user/show-profile-of-other-user.component.ts
    return this.http.get<any>(this.baseURL+'/User_Post/'+id)
  }
  GetConnections(){
    return this.http.get<any>(this.baseURL+'/Connections')
  }
  GetConnectionsById(id:number|null){
    return this.http.get<any>(this.baseURL+'/Connections/'+id)
  }
  UpdateConnectionsByConnId(id:number,model:any){                                                    //Subscribed in UserConnections/my-network/my-network.component.ts
    return this.http.put<any>(this.baseURL+'/Connections/UpdateConnections/'+id,model)
  }
  DeleteConnection(id:number){
    return this.http.delete<any>(this.baseURL+'/Connections/'+id)
  }
  AddInvitation(id:number|null,model:any){
    return this.http.post<any>(this.baseURL+'/Connections/addconnection/'+id,model)
  }
  GetInvitations(id:number|null){
    return this.http.get<any>(this.baseURL+'/Invitations/'+id)
  }
  GetConnectionsPost(id:number):Observable<Array<posts>>{
    return this.http.get<Array<posts>>(this.baseURL+'/ConnectionPost/'+id)
  }
  // GetConnectionsPost2(id:number):Observable<Array<posts>>{
  //   return this.http.get<Array<posts>>('https://localhost:7050/api/ConnectionPost/GetPosts2/'+id)
  // }
  // GetOwnPosts(id:number):Observable<Array<ownposts>>{
  //   return this.http.get<Array<ownposts>>('https://localhost:7050/api/ConnectionPost/GetOwnPosts/'+id)
  // }
  // GetCheckLike1(id:number|null){
  //   return this.http.get<any>('https://localhost:7050/api/ConnectionPost/GetLikes1/'+id)
  // }
  // GetCheckLike2(id:number|null){
  //   return this.http.get<any>('https://localhost:7050/api/ConnectionPost/GetLikes2/'+id)
  // }
  // GetCheckOwnPostLike(id:number|null){
  //   return this.http.get<any>('https://localhost:7050/api/ConnectionPost/CheckOwnPostLike/'+id)
  // }
  // GetLikesCount(id:number){
  //   return this.http.get<any>('https://localhost:7050/api/ConnectionPost/GetLikeCounts/'+id)
  // }
  GetPostLikes(id:number){
    return this.http.get<any>(this.baseURL+'/PostLikes/'+id)
  }
  AddPostLikes(id:number,user:user):Observable<like>{
    return this.http.post<like>(this.baseURL+'/PostLikes/'+id,user)

  }
  DeletePostLikes(id:number):Observable<like>{
    return this.http.delete<like>(this.baseURL+'/PostLikes/'+id)
  }
  GetMyNetwork(id:number|null){
    return this.http.get<Array<any>>(this.baseURL+'/MyNetwork/'+id)
  }





    getsearchid(id:number){
      this.searchid=id;
    }
}
