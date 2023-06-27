import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
import { faRepeat} from '@fortawesome/free-solid-svg-icons';
import { faThumbsUp, faComments,faPaperPlane} from '@fortawesome/free-regular-svg-icons';
import { faThumbsUp as SolidTU, faComments as SolidC } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-feed',
  templateUrl: './feed.component.html',
  styleUrls: ['./feed.component.css']
})
export class FeedComponent implements OnInit{
  id:number|null = Number(localStorage.getItem("User_Id"));
  UserData:any;
  constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.loaddata();
  }
  status1:Boolean=false;
  status2:Boolean=false;
  userPosts:Array<any> = [];
  faRepeat=faRepeat;
  faThumbsUp=faThumbsUp;
  faComments=faComments;
  faPaperPlane=faPaperPlane;
  SolidTU=SolidTU;
  SolidC=SolidC;

  loaddata(){
    this.data.GetConnectionsPost1(this.id).subscribe({
      next:(res)=>{
        this.userPosts = res
        console.log(this.userPosts);
        this.data.GetConnectionsPost2(this.id).subscribe({
          next:(res)=>{
            var temp = res;
            for(let i=0 ; i<temp.length ; i++){
              this.userPosts.push(temp[i])
            }
            console.log(this.userPosts);
          }
        });
        this.data.GetOwnPosts(this.id).subscribe({
          next:(res)=>{
            var temp = res;
            for(let i=0; i<temp.length ; i++){
              this.userPosts.push(temp[i])
            }
            this.userPosts.sort((a,b)=>b.post_Id-a.post_Id)
            console.log(this.userPosts);
          }
        });
        this.data.GetUserbyid(this.id).subscribe({
          next:(res)=>{
            this.UserData = res;
          }
        });
        
      }
    })
  }
  onLike(postid:number){
    this.data.AddPostLikes(postid,this.UserData).subscribe({
      next:(res)=>{
        console.log(res);
      }
    });
    this.status1 = !this.status1

  }
  ondisLike(){
    this.status1 = !this.status1
  }
}
