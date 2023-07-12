import { checklike } from './../../Models/PostLikes.model';
import {
  AddPostLike,
  DeletePostLike,
  GetPosts,
  GetPostsSuccess,
} from './../../Store/action';
import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
import { faRepeat } from '@fortawesome/free-solid-svg-icons';
import {
  faThumbsUp,
  faComments,
  faPaperPlane,
  faImage,
  faNewspaper
} from '@fortawesome/free-regular-svg-icons';
import {
  faThumbsUp as SolidTU,
  faComments as SolidC,
  faCalendarWeek
} from '@fortawesome/free-solid-svg-icons';
import { faYoutube } from '@fortawesome/free-brands-svg-icons';
import { Store } from '@ngrx/store';
import { posts } from 'src/app/Models/PostLikes.model';
import { selectposts } from 'src/app/Store/selecter';
@Component({
  selector: 'app-feed',
  templateUrl: './feed.component.html',
  styleUrls: ['./feed.component.css'],
})
export class FeedComponent implements OnInit {
  id: number | null = Number(localStorage.getItem('User_Id'));
  UserData: any;
  constructor(
    private data: DataService,
    private router: Router,
    private store: Store
  ) {}
  ngOnInit(): void {
    this.loaddata();
  }
  status1: Boolean = false;
  status2: Boolean = false;
  userPosts: Array<posts> = [];
  // checkLikes: Array<checklike> = [];
  // postCounts: Array<any> = [];
  // Combine: Array<any> = [];
  //postlikescount:Array<any> = [];
  //postlikes:Array<any> = [];
  //userlikedPosts:Array<any> = [];
  faRepeat = faRepeat;
  faThumbsUp = faThumbsUp;
  faComments = faComments;
  faPaperPlane = faPaperPlane;
  faImage=faImage;
  faYoutube = faYoutube;
  faNewspaper=faNewspaper;
  SolidTU = SolidTU;
  SolidC = SolidC;
  faCalendarWeek=faCalendarWeek;

  loaddata() {
    this.store.dispatch(GetPosts());
    this.store.select(selectposts).subscribe({
      next: (res) => {
        this.userPosts = res;
      },
    });
    this.data.GetUserbyid(this.id).subscribe({
      next: (res) => {
        this.UserData = res;
      },
    });
    // this.store.dispatch(GetPosts2());
    // this.store.dispatch(GetOwnPosts());
    // this.store.dispatch(GetCheckLike());
    // this.store.select(selectAllPosts).subscribe({
    //   next: (res) => {
    //     this.userPosts = res;
    //     this.userPosts.sort((a, b) => b.post_Id - a.post_Id);
    //     console.log("post",this.userPosts);
    //   },
    // });
    // this.store.select(selectchecklike).subscribe({
    //   next: (res) => {
    //     this.checkLikes = res;
    //     console.log("check",this.checkLikes);
    //   },
    // });
    // for (let i = 0; i < this.userPosts.length; i++) {
    //   for (let j = 0; j < this.checkLikes.length; j++) {
    //     if (this.userPosts[i].post_Id == this.checkLikes[j].post_Id) {
    //       this.userPosts[i].status = this.checkLikes[j].status;
    //       console.log("ff");

    //     }
    //   }
    // }
    // console.log("sdfgsdf");

    // this.store.select(selectposts2).subscribe({
    //   next:(res)=>{
    //     //var temp = res;
    //     for (let i = 0; i < res.length; i++) {
    //        this.userPosts.push(res[i]);
    //     }
    //   }
    // })

    // this.data.GetConnectionsPost1(this.id).subscribe({
    //   next: (res) => {
    //     this.userPosts = res;
    //     console.log("userpost1",this.userPosts);
    //     this.data.GetConnectionsPost2(this.id).subscribe({
    //       next: (res) => {
    //         var temp = res;
    //         for (let i = 0; i < temp.length; i++) {
    //           this.userPosts.push(temp[i]);
    //         }
    //         console.log("userpost2",this.userPosts);
    //         this.data.GetOwnPosts(this.id).subscribe({
    //           next: (res) => {
    //             var temp = res;
    //             for (let i = 0; i < temp.length; i++) {
    //               this.userPosts.push(temp[i]);
    //             }
    //             this.userPosts.sort((a, b) => b.post_Id - a.post_Id);
    //             console.log("finaluser",this.userPosts);
    //             for(let i=0 ; i<this.userPosts.length ;i++){
    //               this.data.GetLikesCount(this.userPosts[i].post_Id).subscribe({
    //                 next:(res)=>{
    //                   let temp = res
    //                   if(temp[0].post_Id > 0){
    //                     this.postCounts.push(temp[0])
    //                     this.userPosts[i].likeCounts = temp[0].likeCounts
    //                   }
    //                 }
    //               })
    //             }
    //             console.log("Count",this.postCounts);
    //             for(let i=0 ; i<this.userPosts.length ;i++){
    //               for(let j=0 ; j<this.checkLikes.length ;j++){
    //                 if(this.userPosts[i].post_Id == this.checkLikes[j].post_Id){
    //                   this.userPosts[i].status = this.checkLikes[j].status
    //                 }
    //               }
    //             }
    //             console.log("updated fineluser",this.userPosts);
    //           },
    //         });
    //       },
    //     });
    //   },
    // });
    // ===========================================================================================================
    // this.data.GetCheckLike1(this.id).subscribe({
    //   next:(res)=>{
    //     this.checkLikes = res
    //     console.log("checkLike1",this.checkLikes);
    //     this.data.GetCheckLike2(this.id).subscribe({
    //       next:(res)=>{
    //         var temp = res;
    //         for(let i = 0; i<temp.length; i++){
    //           this.checkLikes.push(temp[i]);
    //         }
    //         console.log("checkLike2",this.checkLikes);
    //       }
    //     })
    //   }
    // })

    // for(let i = 0 ; i<this.userPosts.length; i++){
    //   this.Combine.push('{'+this.userPosts[i]+','+this.checkLikes[i]+'}')
    //   console.log("combine",this.Combine);

    // }
    // ================================================================================================================
    // this.data.GetCheckOwnPostLike(this.id).subscribe({
    //   next:(res)=>{
    //       this.checkLikes = res
    //     console.log("finalcheck",this.checkLikes);
    //   }
    // })
  }
  // onLike(postid: number, status: string) {
  //   if (status.substring(0, 5) == 'Liked') {
  //     this.data.DeletePostLikes(Number(status.substring(6))).subscribe({
  //       next: (res) => {
  //         window.location.reload();
  //       },
  //     });
  //   } else {
  //     this.data.AddPostLikes(postid, this.UserData).subscribe({
  //       next: (res) => {
  //         console.log(res);
  //         window.location.reload();
  //       },
  //     });
  //   }
  onLike(postid: number, status: string) {
    if (status.substring(0, 5) == 'Liked') {
      this.store.dispatch(DeletePostLike({ id: Number(status.substring(6)) }));
      // this.store.dispatch(GetPosts());
      // this.store.select(selectposts).subscribe({
      //   next: (res) => {
      //     this.userPosts = res;
      //   },
      // });
    } else {
      this.store.dispatch(AddPostLike({ id: postid, user: this.UserData }));
      // this.store.dispatch(GetPosts());
      // this.store.select(selectposts).subscribe({
      //   next: (res) => {
      //     this.userPosts = res;
      //   },
      // });
    }
  }

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
  //}
  // ondisLike(){
  //   this.status1 = !this.status1
  // }
}
