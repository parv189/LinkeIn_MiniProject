import { Router } from '@angular/router';
import { Component,OnInit } from '@angular/core';
import { faCircleXmark, faCircleCheck } from '@fortawesome/free-regular-svg-icons';
import { DataService } from 'src/app/Services/data.service';

@Component({
  selector: 'app-my-network',
  templateUrl: './my-network.component.html',
  styleUrls: ['./my-network.component.css']
})
export class MyNetworkComponent implements OnInit{
id:number|null = Number(localStorage.getItem('User_Id'));
AllConnections:Array<any>=[];
MyConnections:Array<any>=[];
Invitations:Array<any>=[];
Accepted:Array<any>=[];
Rejected:Array<any>=[];
faCircleXmark=faCircleXmark;
faCircleCheck=faCircleCheck;
  constructor(private data:DataService, private router:Router){}
  ngOnInit(): void {
    this.loaddata();
  }

  loaddata(){
    this.data.GetInvitations(this.id).subscribe({
      next:(res)=>{
        this.Invitations = res;
        this.Invitations.sort((a,b)=>b.userConnection_Id - a.userConnection_Id)
        console.log(res);
      }
    })
    this.data.GetConnectionsById(this.id).subscribe({
      next:(res)=>{
        this.AllConnections = res;
        console.log(res);
      }
    });
    this.data.GetMyNetwork(this.id).subscribe({
      next:(res)=>{
        this.MyConnections = res
        this.MyConnections.sort((a,b)=>b.userConnection_Id-a.userConnection_Id)
        console.log(this.MyConnections);

      }
    })
  };
  onReject(connid:number){
    // this.Rejected = this.Invitations.filter(x => x.userConnection_Id == userConnection_Id);
    // var connid = this.Rejected[0].userConnection_Id
    // this.Rejected[0].status = "rejected"
    this.data.DeleteConnection(connid).subscribe({
      next:(res)=>{
        console.log(res);
      }
    })
  }
  onAccept(connid:number){
    console.log(connid);
    this.Accepted = this.Invitations.filter(x => x.userConnection_Id == connid);
    console.log("c-1",this.Accepted);
    this.Accepted[0].status = "accepted"
    console.log("c-2",this.Accepted);
    this.data.UpdateConnectionsByConnId(connid,this.Accepted[0]).subscribe({
      next:(res)=>{
        console.log(res);
      }
    });
  }
  onManageNet(){
    this.router.navigate(['/ManageMyNetwork'])
  }
  onViewProfile(conn:number){
    localStorage.setItem('SearchId',conn.toString())
    console.log(conn);

    this.router.navigate(['/ShowOtherUserProfile'])

  }
}
