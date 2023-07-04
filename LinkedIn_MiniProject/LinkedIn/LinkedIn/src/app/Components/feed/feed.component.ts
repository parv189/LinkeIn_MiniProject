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
  postlikescount:Array<any> = [];
  postlikes:Array<any> = [];
  userlikedPosts:Array<any> = [];
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
            this.data.GetOwnPosts(this.id).subscribe({
              next:(res)=>{
                var temp = res;
                for(let i=0; i<temp.length ; i++){
                  this.userPosts.push(temp[i])
                }
                this.userPosts.sort((a,b)=>b.post_Id-a.post_Id)
                console.log(this.userPosts);
                // for(let i=0 ; i<this.userPosts.length; i++){
                //   this.data.GetPostLikes(this.userPosts[i].post_Id).subscribe({
                //     next:(res)=>{
                //       var temp = res
                //       if(temp.length != 0){
                //         this.postlikes.push(temp)
                //       }
                //       var templikes = res.length
                //       this.postlikescount.push(templikes)
                //     }
                //   });
                // }
                // console.log("postlikes",this.postlikes);
                // console.log("postlikescount",this.postlikescount);

                // this.userlikedPosts = this.postlikes.filter(x=>x.user_Id == this.id)
                // console.log("userlikedPosts",this.userlikedPosts);
              }
            });
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
    // for(let i=0 ; i<this.userPosts.length; i++){
    //   this.data.GetPostLikes(this.userPosts[i].post_Id).subscribe({
    //     next:(res)=>{
    //       this.postlikes = res
    //       var templikes = res.length
    //       this.postlikescount.push(templikes)
    //     }
    //   });
    // }
    // this.userlikedPosts = this.postlikes.filter(x=>x.user_ID == this.id)
    // console.log("userlikedPosts",this.userlikedPosts);
  }
  ondisLike(){
    this.status1 = !this.status1
  }
}
