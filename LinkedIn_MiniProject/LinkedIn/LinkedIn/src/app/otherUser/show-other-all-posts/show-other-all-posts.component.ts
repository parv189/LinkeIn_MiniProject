import { faThumbsUp, faComments,faPaperPlane} from '@fortawesome/free-regular-svg-icons';
import { Component,OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { faHeart, faRepeat,faArrowLeft} from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';
@Component({
  selector: 'app-show-other-all-posts',
  templateUrl: './show-other-all-posts.component.html',
  styleUrls: ['./show-other-all-posts.component.css']
})
export class ShowOtherAllPostsComponent implements OnInit{
  searchid:number=0;
userPosts:Array<any> = [];
userData:any;
faHeart = faHeart;
faComments = faComments;
faThumbsUp = faThumbsUp;
faRepeat = faRepeat;
faPaperPlane = faPaperPlane;
faArrowLeft=faArrowLeft;
constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.searchid = this.data.searchid
    console.log(this.searchid);
    this.loaddata();
  }
  loaddata(){
    this.data.GetPostsofuser(this.searchid).subscribe({
      next:(res)=>{
        this.userPosts = res.reverse();
      }
    });
    this.data.GetUserbyid(this.searchid).subscribe({
      next:(res)=>{
        console.log(res);

        this.userData = res;
        this.userData
      }
    })
  }
  onBack(){
    this.router.navigate(['/ShowOtherUserProfile'])
  }
}
