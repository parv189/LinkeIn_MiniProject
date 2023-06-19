import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../Services/data.service';

@Component({
  selector: 'app-update-profile',
  templateUrl: './update-profile.component.html',
  styleUrls: ['./update-profile.component.css'],
})
export class UpdateProfileComponent implements OnInit {
  userData: any;
  country: any;
  stste: any;
  city: any;
  myArray: Array<string> = [];
  selectedCity: string = '';
  selectedState: string = '';
  selectedCountry: string = '';
  imgFile: any;
  Email: string | null = localStorage.getItem('Email');
  constructor(private data: DataService, private router: Router) {}
  ngOnInit(): void {
    this.loaddata();
  }

  loaddata() {
    this.data.GetUser(this.Email).subscribe({
      next: (res) => {
        this.userData = res;
        console.log(this.userData);
        this.myArray = this.userData.user_Location.split(', ');
        console.log(this.myArray);

        this.selectedCountry = this.myArray[2];
        this.selectedState = this.myArray[1];
        this.selectedCity = this.myArray[0];
      },
    });
    this.data.Getlocation(3).subscribe({
      next: (res) => {
        this.country = res;
        console.log(res);
      },
    });
    this.data.Getlocation(2).subscribe({
      next: (res) => {
        this.stste = res;
        console.log(res);
      },
    });
    this.data.Getlocation(1).subscribe({
      next: (res) => {
        this.city = res;
        console.log(res);
      },
    });
  }
  onselected(event: any) {
    this.imgFile = event.target.files[0];
  }
  onupdateuser() {
    this.userData.user_Location =
      this.selectedCity +
      ', ' +
      this.selectedState +
      ', ' +
      this.selectedCountry;
    this.data
      .UpdateUser(Number(localStorage.getItem('User_Id')), this.userData)
      .subscribe({
        next: (res) => {
          console.log(res);
          this.router.navigate(['/home/profile']);
        },
      });
  }
  onChange1(e: any) {
    this.selectedCountry = e.target.value;
  }
  onChange2(e: any) {
    this.selectedState = e.target.value;
  }
  onChange3(e: any) {
    this.selectedCity = e.target.value;
  }
}
