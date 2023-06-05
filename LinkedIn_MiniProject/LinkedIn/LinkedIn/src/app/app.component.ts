import { Component } from '@angular/core';
//import { JwtService } from './Services/jwt.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'LinkedIn';
  constructor(
    //private jwtService: JwtService
    )
    {
    const token = 'your_jwt_token_here';
    //const userEmail = this.jwtService.getClaim(token, 'email');
    //console.log('User Email:', userEmail);
}
}
