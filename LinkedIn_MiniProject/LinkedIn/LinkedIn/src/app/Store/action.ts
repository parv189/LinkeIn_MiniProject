import { createAction, props } from "@ngrx/store";
import { checklike, ownposts, posts } from "../Models/PostLikes.model";


export const GetPosts1 = createAction('Get Posts1 Data')
export const GetPostsSuccess1 = createAction('Get Posts1 Data Success',props<{posts:Array<posts>}>())
export const GetPostsError1 = createAction('Get Posts1 Data Error')

export const GetPosts2 = createAction('Get Posts2 Data')
export const GetPostsSuccess2 = createAction('Get Posts2 Data Success',props<{posts:Array<posts>}>())
export const GetPostsError2 = createAction('Get Posts2 Data Error')

export const GetOwnPosts = createAction('Get Own Posts Data ')
export const GetOwnPostsSuccess = createAction('Get Own Posts Data Success',props<{ownposts:Array<ownposts>}>())
export const GetOwnPostsError = createAction('Get Own Posts Data Error')

export const GetCheckLike = createAction('Get Check Like')
export const GetCheckLikeSuccess = createAction('Get Check Like Data Success',props<{checklike:Array<checklike>}>())
export const GetCheckLikeErrer = createAction('Get Check Like Data Error')
