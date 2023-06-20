import { faThumbsUp, faComments,faPaperPlane} from '@fortawesome/free-regular-svg-icons';
import { Component,OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { faHeart, faRepeat} from '@fortawesome/free-solid-svg-icons';
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

constructor(private data:DataService){}
  ngOnInit(): void {
    this.loaddata();
  }
  loaddata(){
    this.data.GetPostsofuser(this.id).subscribe({
      next:(res)=>{
        this.userPosts = res;
      }
    });
    this.data.GetUser(this.Email).subscribe({
      next:(res)=>{
        console.log(res);

        this.userData = res;
      }
    })
  }
}
