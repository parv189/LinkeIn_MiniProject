import { Component,OnInit } from '@angular/core';
import { FormGroup,FormControl} from '@angular/forms';
import { DataService } from '../Services/data.service';

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
  constructor(private DataService:DataService){}
  onRegister(){
   this.DataService.AddUser(this.RegisterForm.value).subscribe({
    next:(res) =>{
      console.log(res);

    }
   })
  }
}
