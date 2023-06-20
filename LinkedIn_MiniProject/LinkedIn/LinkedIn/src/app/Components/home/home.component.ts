import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
userData:any;
Email:string|null = localStorage.getItem("Email")
  searchTerm = '';
  userdata:Array<any> = [];
  alluserdata:Array<any> = [];
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
this.userdata = this.alluserdata.filter((val)=>val.firstName.toLowerCase().includes(value));
this.data.GetAllUser2().subscribe({
  next:(res)=>{
    this.userdata = res;
    this.alluserdata = this.userdata;
    console.log(res);

  }
});
}
}
