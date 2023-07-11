import { like } from './../Models/PostLikes.model';
import { map } from 'rxjs/operators';
import { createReducer, on } from '@ngrx/store';
import { checklike, ownposts, posts } from '../Models/PostLikes.model';
import { AddPostLikeSuccess, DeletePostLike, DeletePostLikeSuccess, GetPostsSuccess} from './action';


export const initialStateofPosts1 : Array<posts> = [];
export const initialStateofPosts2 : Array<posts> = [];
export const initialStateofOwnPosts : Array<ownposts> = [];
export const initialStateofCheckLike : Array<checklike> = [];


export const GetPosts1Reducer = createReducer(
  initialStateofPosts1,
  on(GetPostsSuccess, (state,{posts}) => posts),
  //On(AddPostLikeSuccess,(state,{like}) => state.map(x=>{if(x.post_Id==like.Post_Id){return{...x,status:'Liked/'+like.PostLike_Id}}{return x}})),
  //on(AddPostLikeSuccess,(state,{like}) => {
  //   let post = state.find(x=>x.post_Id==like.Post_Id)
  //   if(post!=undefined){
  //     post.likeCounts=post.likeCounts+1;
  //     post.status = 'Liked/'+like.PostLike_Id;
  //   }
  //   return ({...state,posts:[...state.map(x=>x.post_Id==like.Post_Id?post:x)]})

  // }),
  //on(DeletePostLikeSuccess,(state,{like}) => state.map(x=>{if(x.status.substring(6)==String(like.PostLike_Id)){return{...x,status:'notLiked'}}return x}))
//   mutableOn(DeletePostLikeSuccess,(state,{like}) => {
//     const post = state.find(x=>x.status.substring(6)==String(like.PostLike_Id))
//     if(post){

//     }

//    }),
 )

// export const GetPosts2Reducer = createReducer(
//   initialStateofPosts2,
//   on(GetPostsSuccess2, (state,{posts}) => posts),
// )
// export const GetOwnPostsReducer = createReducer(
//   initialStateofOwnPosts,
//   on(GetOwnPostsSuccess, (state,{ownposts}) => ownposts),
// )
// export const GetCheckLikeReducer = createReducer(
//   initialStateofCheckLike,
//   on(GetCheckLikeSuccess, (state,{checklike}) => checklike),
// )
