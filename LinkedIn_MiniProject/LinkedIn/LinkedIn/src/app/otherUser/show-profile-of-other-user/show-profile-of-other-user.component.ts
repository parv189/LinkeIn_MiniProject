import { Component,OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Router, TitleStrategy } from '@angular/router';
import { faArrowLeft } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-show-profile-of-other-user',
  templateUrl: './show-profile-of-other-user.component.html',
  styleUrls: ['./show-profile-of-other-user.component.css']
})
export class ShowProfileOfOtherUserComponent implements OnInit{
  id:number|null= Number(localStorage.getItem("User_Id"))
  userData:any;
  searchid:number=0;
  userPost:Array<any> = [];
  AllConnections:Array<any> = [];
  thisconnetion:any;
  status:string="None";
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
    });
    this.data.GetConnectionsById(this.id).subscribe({
      next:(res)=>{
        this.AllConnections = res;
        console.log("all",res);
        this.thisconnetion = this.AllConnections.filter(x=>x.connectedUser_ID == this.searchid);
        console.log("this",this.thisconnetion);
        this.status = this.thisconnetion[0].status;
        console.log(this.status);

      }
    })
  }
  onShowAllPosts(){
this.router.navigate(['/ShowOtherUserPosts'])
  }
  onConnect(){
    this.data.AddInvitation(this.id,this.searchid).subscribe({
      
    })
  }
  onBack(){
    this.router.navigate(['/home'])
  }
}
