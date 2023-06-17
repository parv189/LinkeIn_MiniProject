import { UpdateProfileComponent } from './update-profile/update-profile.component';
import { SettingsComponent } from './settings/settings.component';
import { AppComponent } from './app.component';
import { ChatComponent } from './chat/chat.component';
import { ProfileComponent } from './profile/profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'', component:SignUpComponent, pathMatch: 'full'},
  {path:'home',component:HomeComponent},
  {path:'',component:SignUpComponent},
  {path:'SignUp',component:SignUpComponent},
  {path:'SignIn',component:SignInComponent},
];
const routes1: Routes = [
  {path:'', component:HomeComponent, pathMatch: 'full'},
  {path:'home',component:HomeComponent,
   children:[{path:'',component:HomeComponent},
             {path:'profile',component:ProfileComponent},
             {path:'chat',component:ChatComponent}]},
  {path:'Settings',component:SettingsComponent},
  {path:'UpdateProfile',component:UpdateProfileComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes),RouterModule.forChild(routes1)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
