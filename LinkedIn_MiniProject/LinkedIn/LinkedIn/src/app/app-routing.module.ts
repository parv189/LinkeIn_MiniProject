import { FeedComponent } from './Components/feed/feed.component';
import { ManageMyNetworkComponent } from './UserConnections/manage-my-network/manage-my-network.component';
import { MyNetworkComponent } from './UserConnections/my-network/my-network.component';
import { ShowOtherAllPostsComponent } from './otherUser/show-other-all-posts/show-other-all-posts.component';
import { ShowProfileOfOtherUserComponent } from './otherUser/show-profile-of-other-user/show-profile-of-other-user.component';
import { ShowAllPostsComponent } from './Post_Components/show-all-posts/show-all-posts.component';
import { AddPostComponent } from './Post_Components/add-post/add-post.component';
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
  {path:'SignUp',component:SignUpComponent},
  {path:'SignIn',component:SignInComponent},
];
const routes1: Routes = [
  {path:'home',component:HomeComponent,
   children:[{path:'',component:FeedComponent},
             {path:'profile',component:ProfileComponent},
             {path:'MyNetwork',component:MyNetworkComponent},
             {path:'feed',component:FeedComponent},
             {path:'chat',component:ChatComponent}]},
  {path:'Settings',component:SettingsComponent},
  {path:'UpdateProfile',component:UpdateProfileComponent},
  {path:'AccountPref',component:AccountPreferencesComponent},
  {path:'Addpost',component:AddPostComponent},
  {path:'ShowAllposts',component:ShowAllPostsComponent},
  {path:'ShowOtherUserProfile',component:ShowProfileOfOtherUserComponent},
  {path:'ShowOtherUserPosts',component:ShowOtherAllPostsComponent},
  {path:'ManageMyNetwork',component:ManageMyNetworkComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes),RouterModule.forChild(routes1)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
