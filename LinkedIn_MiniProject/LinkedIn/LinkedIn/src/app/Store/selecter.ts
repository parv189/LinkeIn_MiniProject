import { checklike } from './../Models/PostLikes.model';
import { createSelector, createFeatureSelector } from '@ngrx/store';
import { posts } from '../Models/PostLikes.model';

export const selectposts1 = createFeatureSelector<Array<posts>>('posts1');
export const selectposts2 = createFeatureSelector<Array<posts>>('posts2');
export const selectownposts = createFeatureSelector<Array<posts>>('ownposts');
export const selectchecklike = createFeatureSelector<Array<checklike>>('checklike');

export const selectAllPosts = createSelector(
  selectposts1,
  selectposts2,
  selectownposts,
  (p1,p2,p3)=>p1.concat(p2).concat(p3)
)



