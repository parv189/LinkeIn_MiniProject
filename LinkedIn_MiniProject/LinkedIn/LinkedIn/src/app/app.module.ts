import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Components/home/home.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ReactiveFormsModule } from '@angular/forms';
import { ChatComponent } from './Components/chat/chat.component';
import { FormsModule } from '@angular/forms';
import { SettingsComponent } from './Components/settings/settings.component';
import { UpdateProfileComponent } from './Components/update-profile/update-profile.component';
import { AccountPreferencesComponent } from './Components/account-preferences/account-preferences.component';
import { AddPostComponent } from './Post_Components/add-post/add-post.component';
import { ShowAllPostsComponent } from './Post_Components/show-all-posts/show-all-posts.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SearchFilterPipe } from './Pipes/search-filter.pipe';
import { ShowProfileOfOtherUserComponent } from './otherUser/show-profile-of-other-user/show-profile-of-other-user.component';
import { ShowOtherAllPostsComponent } from './otherUser/show-other-all-posts/show-other-all-posts.component';
import { MyNetworkComponent } from './UserConnections/my-network/my-network.component';
import { ManageMyNetworkComponent } from './UserConnections/manage-my-network/manage-my-network.component';
import { FeedComponent } from './Components/feed/feed.component';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { GetCheckLikeReducer, GetOwnPostsReducer, GetPosts1Reducer, GetPosts2Reducer } from './Store/reducer';
import { PostEffects } from './Store/effects';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SignUpComponent,
    SignInComponent,
    ProfileComponent,
    ChatComponent,
    SettingsComponent,
    UpdateProfileComponent,
    AccountPreferencesComponent,
    AddPostComponent,
    ShowAllPostsComponent,
    SearchFilterPipe,
    ShowProfileOfOtherUserComponent,
    ShowOtherAllPostsComponent,
    MyNetworkComponent,
    ManageMyNetworkComponent,
    FeedComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    FontAwesomeModule,
    StoreModule.forRoot({posts1:GetPosts1Reducer,posts2:GetPosts2Reducer,ownposts:GetOwnPostsReducer,checklike:GetCheckLikeReducer}, {}),
    EffectsModule.forRoot([PostEffects]),
    StoreDevtoolsModule.instrument({name:'linkedin'})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
