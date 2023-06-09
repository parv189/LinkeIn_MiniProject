import { Component,OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
import { faArrowLeft } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit{
  Email:string|null = localStorage.getItem('Email')
  id:number|null = Number(localStorage.getItem('User_Id'));
  userData: any;
  userPost:Array<any> = [];

  faArrowLeft=faArrowLeft
  constructor(private data:DataService, private router:Router){}

ngOnInit(): void {
  this.loaddata();
}

loaddata(){
  this.data.GetUser(this.Email).subscribe({
    next : (res)=>{
    this.userData = res;
    console.log(res);

    }
  });
  this.data.GetPostsofuser(this.id).subscribe({
    next : (res)=>{
      this.userPost = res;
      console.log(this.userPost);


    }
  })

}
onBack(){
  this.router.navigate(['/home'])
}
onShowAllPosts(){
  this.router.navigate(['/ShowAllposts'])
}
}
