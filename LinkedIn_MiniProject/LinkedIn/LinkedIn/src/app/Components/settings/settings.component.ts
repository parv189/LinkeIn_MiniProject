import { Component,OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent implements OnInit{

userData:any;
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
AccountPref(){
  this.router.navigate(['/AccountPref'])
}
OnBack(){
  this.router.navigate(['/home/profile'])
}
}
