import { Component } from '@angular/core';
import { FormControl,FormGroup } from '@angular/forms';
import { DataService } from '../Services/data.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent {

  constructor(private DataService:DataService,
    private router:Router
    ){}
  LoginForm = new FormGroup({
    EmailPhoneNumber : new FormControl(''),
    Password : new FormControl('')
  })
  onLogin(){
    this.DataService.AddUser(this.LoginForm.value).subscribe({
      next:(res) =>{
        console.log(res);

      }
     })
      this.router.navigate(['/home'])
    }
  }

