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
Email:string|null = localStorage.getItem("Email")
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

this.data.GetAllUser2().subscribe({
  next:(res)=>{
    this.userdata = res;
    this.alluserdata = this.userdata;
    console.log(res);
  }
});
}
onSearch(id:number){
  console.log("id in home",id);
  this.data.getsearchid(id);
  console.log(this.data.searchid);
  this.router.navigate(['/ShowOtherUserProfile'])
}
onLogo(){
  window.location.reload();
}
}
