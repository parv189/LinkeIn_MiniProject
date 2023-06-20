import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { DataService } from 'src/app/Services/data.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-add-post',
  templateUrl: './add-post.component.html',
  styleUrls: ['./add-post.component.css']
})
export class AddPostComponent {

imgFile!:File;
id:number|null = Number(localStorage.getItem("User_Id"));
constructor(private data:DataService, private router:Router){}
PostForm = new FormGroup({
  photo_Url : new FormControl(''),
  content : new FormControl(''),
});

onselected(e:any){
this.imgFile = e.target.files[0];
}

onAddPost(){
const form = new FormData();
form.append('file', this.imgFile as File);

this.data.Addfile(form).subscribe({
  next:(res)=>{
    console.log(res);
    let regdata = this.PostForm.value;
    let imgurl:string = res.url;
    regdata.photo_Url = imgurl;
    console.log(regdata);

    this.data.AddNewPost(this.id ,this.PostForm.value).subscribe({
      next:(res)=>{
        console.log(res);
        this.router.navigate(['/home/profile'])
      }
    })
  }
})
}

}
