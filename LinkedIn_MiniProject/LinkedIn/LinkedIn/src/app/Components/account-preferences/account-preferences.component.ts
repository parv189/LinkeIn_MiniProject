import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-account-preferences',
  templateUrl: './account-preferences.component.html',
  styleUrls: ['./account-preferences.component.css']
})
export class AccountPreferencesComponent {

  constructor(private router:Router){}
  onUpdate(){
    this.router.navigate(['/UpdateProfile'])
  }
  OnBack(){
    this.router.navigate(['/home/profile'])
  }
}
