import { AccountPreferencesComponent } from './Components/account-preferences/account-preferences.component';
import { UpdateProfileComponent } from './Components/update-profile/update-profile.component';
import { SettingsComponent } from './Components/settings/settings.component';
import { AppComponent } from './app.component';
import { ChatComponent } from './Components/chat/chat.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { HomeComponent } from './Components/home/home.component';
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
  {path:'UpdateProfile',component:UpdateProfileComponent},
  {path:'AccountPref',component:AccountPreferencesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes),RouterModule.forChild(routes1)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
