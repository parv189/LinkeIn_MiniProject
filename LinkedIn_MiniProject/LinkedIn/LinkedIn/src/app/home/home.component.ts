import { Component } from '@angular/core';
import { DataService } from '../Services/data.service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

constructor(private data:DataService){}
 
}
