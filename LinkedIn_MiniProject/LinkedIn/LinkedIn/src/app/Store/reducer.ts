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
  on(AddPostLikeSuccess, (state,{like}) => {
    const newpostlike = state.map((x)=>{
      const lc = x.likeCounts;
      if(x.post_Id === like.post_Id){
        return {...x,status:'Liked/'+like.postLike_Id,likeCounts:lc+1}
      }
      return x;
    })
    console.log("2",newpostlike);
    return newpostlike
  }),
  on(DeletePostLikeSuccess, (state,{like}) => {
    const newpostdislike = state.map((x)=>{
      const lc = x.likeCounts;
      if(x.post_Id === like.post_Id){
        return {...x,status:'notLiked',likeCounts:lc-1}
      }
      return x;
    })
    console.log("2",newpostdislike);
    return newpostdislike
  }))
  //On(AddPostLikeSuccess,(state,{like}) => state.map(x=>{if(x.post_Id==like.Post_Id){return{...x,status:'Liked/'+like.PostLike_Id}}{return x}})),
  //on(AddPostLikeSuccess,(state,{like}) => {

    // const post = state.find(x=>x.post_Id===like.post_Id)
    // console.log("1",post);
    // if(post!=undefined){
    //   post.likeCounts=post.likeCounts+1;
    //   post.status = 'Liked/'+like.postLike_Id;
    //   console.log("2",post);
    //   return ([...state.map(x=>x.post_Id==like.post_Id?post:x)])
    // }
    // console.log("3",post);
    // return [...state]

  //}),
  //on(DeletePostLikeSuccess,(state,{like}) => state.map(x=>{if(x.status.substring(6)==String(like.PostLike_Id)){return{...x,status:'notLiked'}}return x}))
//   on(DeletePostLikeSuccess,(state,{like}) => {
//     const post = state.find(x=>x.post_Id==like.post_Id)
//     console.log("1",post);
//     if(post!=undefined){
//       post.likeCounts=post.likeCounts-1;
//       post.status = 'notliked';
//       console.log("2",post);
//       return ([...state.map(x=>x.post_Id==like.post_Id?post:x)])
//     }
//     console.log("3",post);
//     return [...state]
//     }
//  ))

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
