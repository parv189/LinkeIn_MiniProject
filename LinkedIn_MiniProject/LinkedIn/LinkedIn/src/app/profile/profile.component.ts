import { Component,OnInit } from '@angular/core';
import { DataService } from '../Services/data.service';
import { user } from '../model';
@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit{
  Email:string|null = localStorage.getItem('Email')
  userData: any;
  constructor(private data:DataService){}

ngOnInit(): void {
  this.loaddata();
}

loaddata(){
  this.data.GetUser(this.Email).subscribe({
    next : (res)=>{
    this.userData = res;
    console.log(res);

    }
  })
}
}
