import { createAction, props } from "@ngrx/store";
import { checklike, user, ownposts, posts, like } from "../Models/PostLikes.model";


export const GetPosts = createAction('Get Posts Data')
export const GetPostsSuccess = createAction('Get Posts Data Success',props<{posts:Array<posts>}>())
export const GetPostsError = createAction('Get Posts Data Error')

export const AddPostLike = createAction('Add Post Like',props<{id:number,user:user}>())
export const AddPostLikeSuccess = createAction('Add Post Like Success',props<{like:like}>())
export const AddPostLikeError = createAction('Add Post Like Error')

export const DeletePostLike = createAction('Delete Post Like',props<{id:number}>())
export const DeletePostLikeSuccess = createAction('Delete Post Like Success',props<{like:like}>())
export const DeletePostLikeError = createAction('Delete Post Like Error')


// export const GetPosts2 = createAction('Get Posts2 Data')
// export const GetPostsSuccess2 = createAction('Get Posts2 Data Success',props<{posts:Array<posts>}>())
// export const GetPostsError2 = createAction('Get Posts2 Data Error')

// export const GetOwnPosts = createAction('Get Own Posts Data ')
// export const GetOwnPostsSuccess = createAction('Get Own Posts Data Success',props<{ownposts:Array<ownposts>}>())
// export const GetOwnPostsError = createAction('Get Own Posts Data Error')

// export const GetCheckLike = createAction('Get Check Like')
// export const GetCheckLikeSuccess = createAction('Get Check Like Data Success',props<{checklike:Array<checklike>}>())
// export const GetCheckLikeErrer = createAction('Get Check Like Data Error')
