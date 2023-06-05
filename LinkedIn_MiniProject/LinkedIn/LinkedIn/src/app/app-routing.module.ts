import { ChatComponent } from './chat/chat.component';
import { ProfileComponent } from './profile/profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'home',component:HomeComponent,
   children:[{path:'',component:HomeComponent},
             {path:'profile',component:ProfileComponent},
             {path:'chat',component:ChatComponent}]},
  {path:'',component:SignUpComponent},
  {path:'SignUp',component:SignUpComponent},
  {path:'SignIn',component:SignInComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
