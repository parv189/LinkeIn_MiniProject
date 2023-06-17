import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../Services/data.service';

@Component({
  selector: 'app-update-profile',
  templateUrl: './update-profile.component.html',
  styleUrls: ['./update-profile.component.css']
})
export class UpdateProfileComponent implements OnInit{
  userData:any;
  imgFile: any;
  Email:string|null = localStorage.getItem('Email')
  constructor(private data:DataService,private router:Router){}
    ngOnInit(): void {
      this.loaddata();
    }

  loaddata(){
  this.data.GetUser(this.Email).subscribe({
    next:(res)=>{
      this.userData = res;
    }
  })
  }
  onselected(event:any){
    this.imgFile = event.target.files[0];
  }
  onupdatebook(){
this.data.UpdateUser(Number(localStorage.getItem("User_Id")),this.userData).subscribe({
  next:(res)=>{
    console.log(res);
    this.router.navigate(['/Settings'])
  }
})
  }
}
