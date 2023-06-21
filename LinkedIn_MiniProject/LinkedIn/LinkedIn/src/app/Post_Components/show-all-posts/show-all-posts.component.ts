import { faThumbsUp, faComments,faPaperPlane} from '@fortawesome/free-regular-svg-icons';
import { Component,OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { faHeart, faRepeat,faArrowLeft} from '@fortawesome/free-solid-svg-icons';
import { Router } from '@angular/router';
@Component({
  selector: 'app-show-all-posts',
  templateUrl: './show-all-posts.component.html',
  styleUrls: ['./show-all-posts.component.css']
})
export class ShowAllPostsComponent implements OnInit{
id:number = Number(localStorage.getItem("User_Id"));
Email:string|null = localStorage.getItem("Email");
userPosts:Array<any> = [];
userData:any;
faHeart = faHeart;
faComments = faComments;
faThumbsUp = faThumbsUp;
faRepeat = faRepeat;
faPaperPlane = faPaperPlane;
faArrowLeft=faArrowLeft

constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.loaddata();
  }
  loaddata(){
    this.data.GetPostsofuser(this.id).subscribe({
      next:(res)=>{
        this.userPosts = res.reverse();
      }
    });
    this.data.GetUser(this.Email).subscribe({
      next:(res)=>{
        console.log(res);

        this.userData = res;
        this.userData
      }
    })
  }
  onBack(){
    this.router.navigate(['/profile'])
  }
}
