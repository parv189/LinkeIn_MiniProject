import { createReducer, on } from '@ngrx/store';
import { checklike, ownposts, posts } from '../Models/PostLikes.model';
import { GetCheckLikeSuccess, GetOwnPostsSuccess, GetPostsSuccess1, GetPostsSuccess2 } from './action';


export const initialStateofPosts1 : Array<posts> = [];
export const initialStateofPosts2 : Array<posts> = [];
export const initialStateofOwnPosts : Array<ownposts> = [];
export const initialStateofCheckLike : Array<checklike> = [];


export const GetPosts1Reducer = createReducer(
  initialStateofPosts1,
  on(GetPostsSuccess1, (state,{posts}) => posts),
)
export const GetPosts2Reducer = createReducer(
  initialStateofPosts2,
  on(GetPostsSuccess2, (state,{posts}) => posts),
)
export const GetOwnPostsReducer = createReducer(
  initialStateofOwnPosts,
  on(GetOwnPostsSuccess, (state,{ownposts}) => ownposts),
)
export const GetCheckLikeReducer = createReducer(
  initialStateofCheckLike,
  on(GetCheckLikeSuccess, (state,{checklike}) => checklike),
)
