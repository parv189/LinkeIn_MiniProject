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
Invitations:Array<any>=[];
Accepted:Array<any>=[];
faCircleXmark=faCircleXmark;
faCircleCheck=faCircleCheck;
  constructor(private data:DataService){}
  ngOnInit(): void {
    this.loaddata();
  }

  loaddata(){
    this.data.GetConnectionsById(this.id).subscribe({
      next:(res)=>{
        this.AllConnections = res;
        console.log(res);

      }
    });
    this.data.GetInvitations(this.id).subscribe({
      next:(res)=>{
        this.Invitations = res;
        console.log(res);

      }
    })
  };
  onReject(connid:number){
    var connection = this.Invitations.find(x => x.UserConnection_Id == connid);
    connection.status = "rejected"
    this.data.UpdateConnectionsByConnId(connid,connection).subscribe({
      next:(res)=>{
        console.log(res);
      }
    });
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
}
