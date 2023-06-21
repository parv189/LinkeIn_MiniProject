import { Component,OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Router } from '@angular/router';
import { faArrowLeft } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-show-profile-of-other-user',
  templateUrl: './show-profile-of-other-user.component.html',
  styleUrls: ['./show-profile-of-other-user.component.css']
})
export class ShowProfileOfOtherUserComponent implements OnInit{
  userData:any;
  searchid:number=0;
  userPost:Array<any> = [];
  faArrowLeft=faArrowLeft
  constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.searchid = this.data.searchid
    console.log(this.searchid);
    this.loaddata();
  }
  loaddata(){
    this.data.GetUserbyid(this.searchid).subscribe({
      next : (res)=>{
      this.userData = res;
      console.log(res);

      }
    });
    this.data.GetPostsofuser(this.searchid).subscribe({
      next : (res)=>{
        this.userPost = res;
        console.log(this.userPost);
      }
    })
  }
  onShowAllPosts(){
this.router.navigate(['/ShowAllposts'])
  }
  onBack(){
    this.router.navigate(['/home'])
  }
}
