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
  myArray1: Array<string> = [];
  myArray2: Array<string> = [];
  selectedCity: string = '';
  selectedState: string = '';
  selectedCountry: string = '';
  imgFile!: File;
  filename!:string;
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
        this.myArray1 = this.userData.user_Location.split(', ');
        console.log(this.myArray1);

        this.selectedCountry = this.myArray1[2];
        this.selectedState = this.myArray1[1];
        this.selectedCity = this.myArray1[0];
        this.myArray2 = this.userData.user_Profile_photo.split('/');
        this.filename = this.myArray2[4]
        this.filename = this.filename.substring(0,this.filename.length-19);
        console.log((this.filename));
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
    const form = new FormData();
    form.append('file', this.imgFile as File);
    this.data.Addfile(form).subscribe({
      next:(res)=>{
        console.log(res);
        let url : string = res.url;
        // if(res.url == null){
        //   this.userData.user_Profile_photo
        // }
        this.userData.user_Profile_photo = url;
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
              this.router.navigate(['/profile']);
            },
          });
      },
      error:(err)=>{
        console.log(err.error.status == 400);
        if(err.error.status == 400){
          this.userData.user_Profile_photo = this.userData.user_Profile_photo
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
              this.router.navigate(['/profile']);
            },
          });
        }
      }
    })
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
