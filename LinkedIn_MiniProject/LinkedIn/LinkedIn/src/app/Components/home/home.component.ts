import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
import { faPlus, faUserGroup, faHouse, faSuitcase, faMessage, faBell, faMagnifyingGlass} from '@fortawesome/free-solid-svg-icons';
import { faLinkedin } from '@fortawesome/free-brands-svg-icons';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
userData:any;
Email:string|null = localStorage.getItem("Email");
id:number|null = Number(localStorage.getItem("User_Id"));

  searchTerm = '';
  userdata1:Array<any> = [];
  userdata2:Array<any> = [];
  userdata:Array<any> = [];
  alluserdata:Array<any> = [];

  faPlus=faPlus;
  faUserGroup=faUserGroup;
  faHouse=faHouse;
  faSuitcase=faSuitcase;
  faMessage=faMessage;
  faBell=faBell;
  faLinkedin=faLinkedin;
  faMagnifyingGlass=faMagnifyingGlass;


constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.loaddata();
  }
loaddata(){
  this.data.GetUser(this.Email).subscribe({
    next:(res)=>{
      this.userData = res
      console.log(this.userData);
    }
  });
  // this.data.GetPostsofuser(this.id).subscribe({
  //   next:(res)=>{
  //     this.userPosts.push(res);
  //   }
  // });
  // this.data.GetConnectionsPost2(this.id).subscribe({
  //   next:(res)=>{
  //     this.userPosts.push(res);
  //   }
  // })
}
onAddPost(){
this.router.navigate(['/Addpost'])
}
search(value: string):void{
this.userdata1 = this.alluserdata.filter((val)=>val.firstName.toLowerCase().includes(value));
console.log("users1",this.userdata1);
this.userdata2 = this.alluserdata.filter((val)=>val.lastName.toLowerCase().includes(value));
console.log("users2",this.userdata2);
this.userdata = this.userdata1.concat(this.userdata2);
console.log("users",this.userdata);

this.data.GetAllUsers().subscribe({
  next:(res)=>{
    this.userdata = res;
    this.alluserdata = this.userdata;
    console.log(res);
  }
});
}
onSearch(id:number){
  console.log("id in home",id);
  //this.data.getsearchid(id);
  localStorage.setItem('SearchId',id.toString())
  console.log(this.data.searchid);
  this.router.navigate(['/ShowOtherUserProfile'])
}
onLogo(){
  window.location.reload();
}
}
