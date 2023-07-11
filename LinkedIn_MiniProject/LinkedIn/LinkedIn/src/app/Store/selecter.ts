import { checklike } from './../Models/PostLikes.model';
import { createSelector, createFeatureSelector } from '@ngrx/store';
import { posts } from '../Models/PostLikes.model';

export const selectposts = createFeatureSelector<Array<posts>>('posts');
// export const selectposts2 = createFeatureSelector<Array<posts>>('posts2');
// export const selectownposts = createFeatureSelector<Array<posts>>('ownposts');
// export const selectchecklike = createFeatureSelector<Array<checklike>>('checklike');

// export const selectAllPosts = createSelector(
//   selectposts,
//   (sp)=>sp.sort((a,b)=>b.post_Id-a.post_Id)
// )



