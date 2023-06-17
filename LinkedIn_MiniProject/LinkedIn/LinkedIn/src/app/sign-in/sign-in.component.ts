import { Component,OnInit } from '@angular/core';
import { FormControl,FormGroup } from '@angular/forms';
import { DataService } from '../Services/data.service';
import { Router } from '@angular/router';
import { JwtService } from '../Services/jwt.service';
@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent {
UserId:number = 0;
  constructor(private DataService:DataService,
    private router:Router,
    private jwtService: JwtService
    ){}
  LoginForm = new FormGroup({
    EmailPhoneNumber : new FormControl(''),
    Password : new FormControl('')
  })

  onLogin(){
    this.DataService.LoginUser(this.LoginForm.value).subscribe({
      next:(res) =>{
        console.log(res);
        alert(res.status)
        console.log("Login Successful");
        let _token = this.jwtService.decodeToken(res.token);
        console.log(_token);

        //this.jwtService.decodeToken(res.token.split('.')[1])
        //const userEmail = this.jwtService.getClaim(_token, 'unique_name');
        //const FirstName = this.jwtService.getClaim(_token, 'email');
                     //console.log('User Email:', userEmail);
                     //console.log('User First Name:', FirstName);
         //let decodedJWT = JSON.parse(window.atob(token.split('.')[1]));
         //console.log("decodedJWT"+decodedJWT[0]);

         console.log('User_Id: ' + _token.unique_name);
         localStorage.setItem('User_Id',_token.unique_name)
         console.log('Email: ' + _token.email);
         localStorage.setItem('Email',_token.email)
         this.router.navigate(['/home'])

      },
      error: (err) => {
        console.log(err);
        if(err.status != 200){
          alert(err.error)
          this.router.navigate(['/SignIn'])
        }
        // else{
        //   console.log(err);
        //   alert(err.error.text)
        //   this.router.navigate(['/home'])
        // }
      }

    })

    }
  }

