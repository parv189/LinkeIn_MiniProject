import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Router, TitleStrategy } from '@angular/router';
import { faArrowLeft } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-show-profile-of-other-user',
  templateUrl: './show-profile-of-other-user.component.html',
  styleUrls: ['./show-profile-of-other-user.component.css'],
})
export class ShowProfileOfOtherUserComponent implements OnInit {
  id: number | null = Number(localStorage.getItem('User_Id'));
  userData: any;
  searchid: number = 0;
  SearchId:number|null = Number(localStorage.getItem('SearchId'));
  userPost: Array<any> = [];
  AllConnections: Array<any> = [];
  otheruserAllConnections: Array<any> = [];
  thisconnetion: any;
  otherthisconnetion: any;
  status: string = 'None';
  conn:any
  faArrowLeft = faArrowLeft;
  constructor(private data: DataService, private router: Router) {}
  ngOnInit(): void {
    this.searchid = this.data.searchid;
    console.log(this.searchid);
    this.loaddata();
  }
  loaddata() {
    this.data.GetUserbyid(this.SearchId).subscribe({
      next: (res) => {
        this.userData = res;
        console.log(res);
      },
    });
    this.data.GetPostsofuser(this.SearchId).subscribe({
      next: (res) => {
        this.userPost = res;
        console.log(this.userPost);
      },
    });
    this.data.GetConnectionsById(this.id).subscribe({
      next: (res) => {
        this.AllConnections = res;
        console.log('all', res);
        this.thisconnetion = this.AllConnections.filter(
          (x) => x.connectedUser_ID == this.SearchId
        );
        console.log('this', this.thisconnetion);
        this.status = this.thisconnetion[0].status;
        console.log(this.status);
      },
    });
    // this.data.GetConnectionsById(this.SearchId).subscribe({
    //   next:(res)=>{
    //     this.otheruserAllConnections = res
    //     this.otherthisconnetion = this.otheruserAllConnections.filter(
    //       (x)=>x.connectedUser_ID == this.id
    //       );
    //       this.status = this.otherthisconnetion[0].status;
    //       console.log(this.status);
    //   }
    // })
  }
  onShowAllPosts() {
    this.router.navigate(['/ShowOtherUserPosts']);
  }
  onConnect() {
    // this.data.GetConnectionsById(this.id).subscribe({
    //   next: (res) => {
    //     this.AllConnections = res;
    //     console.log('all', res);
    //     this.conn = this.AllConnections.filter(
    //       (x) => (x.connectedUser_ID == this.SearchId) || (x.user_ID == this.searchid)
    //     );
    //   },
    // });
    // if(this.conn.length != 0){


    // }
    if (this.status == 'None') {
      this.data.AddInvitation(this.id, this.userData).subscribe({
        next: (res) => {
          console.log(res);
          this.data.GetConnectionsById(this.id).subscribe({
            next: (res) => {
              this.AllConnections = res;
              console.log('all', res);
              this.thisconnetion = this.AllConnections.filter(
                (x) => x.connectedUser_ID == this.SearchId
                );
                console.log('this', this.thisconnetion);
                this.status = this.thisconnetion[0].status;
                console.log(this.status);
                window.location.reload();
            },
          });
        },
      });
    }
    else{
      this.data.GetConnectionsById(this.id).subscribe({
        next: (res) => {
          this.AllConnections = res;
          console.log('all', res);
          this.thisconnetion = this.AllConnections.filter(
            (x) => x.connectedUser_ID == this.SearchId
          );
          console.log('this', this.thisconnetion);
          this.status = this.thisconnetion[0].status;
          console.log(this.status);
          var connid = this.thisconnetion[0].userConnection_Id;
          this.data.DeleteConnection(connid).subscribe({
            next:(res)=>{
              console.log(res);
              window.location.reload();
            }
          })
        },
      });
    }
  }
  onBack() {
    this.router.navigate(['/home']);
  }
}
