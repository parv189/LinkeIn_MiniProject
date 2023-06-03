import { Component,OnInit } from '@angular/core';
import { FormGroup,FormControl} from '@angular/forms';
import { DataService } from '../Services/data.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent{
  RegisterForm = new FormGroup({
    firstName : new FormControl(''),
    lastName : new FormControl(''),
    email : new FormControl(''),
    phoneNumber : new FormControl(''),
    password : new FormControl('')
  })
  constructor(private DataService:DataService,
    private router:Router
    ){}
  onRegister(){
   this.DataService.AddUser(this.RegisterForm.value).subscribe({
    next:(res) =>{
      console.log(res);

    }
   })
    this.router.navigate(['/SignIn'])
  }
}
