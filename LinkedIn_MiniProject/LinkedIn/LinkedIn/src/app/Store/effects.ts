import { DataService } from 'src/app/Services/data.service';
import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { EMPTY, of } from 'rxjs';
import { map, exhaustMap, catchError, mergeMap, switchMap } from 'rxjs/operators';
import { GetCheckLike, GetCheckLikeErrer, GetCheckLikeSuccess, GetOwnPosts, GetOwnPostsError, GetOwnPostsSuccess, GetPosts1, GetPosts2, GetPostsError1, GetPostsError2, GetPostsSuccess1, GetPostsSuccess2 } from './action';


@Injectable()
export class PostEffects {
  constructor(
    private actions$: Actions,
    private dataService: DataService
  ) {}

    getPosts1$ = createEffect(() => this.actions$.pipe(
      ofType(GetPosts1),
      exhaustMap(() => this.dataService.GetConnectionsPost1(Number(localStorage.getItem('User_Id')))
      .pipe(
        map(posts => GetPostsSuccess1({posts})),
        catchError(() => of(GetPostsError1()))
      ))
    ));
    getPosts2$ = createEffect(() => this.actions$.pipe(
      ofType(GetPosts2),
      exhaustMap(() => this.dataService.GetConnectionsPost2(Number(localStorage.getItem('User_Id')))
      .pipe(
        map(posts => GetPostsSuccess2({posts})),
        catchError(() => of(GetPostsError2()))
      ))
    ));
    getOwnPosts$ = createEffect(() => this.actions$.pipe(
      ofType(GetOwnPosts),
      exhaustMap(() => this.dataService.GetOwnPosts(Number(localStorage.getItem('User_Id')))
      .pipe(
        map(ownposts => GetOwnPostsSuccess({ownposts})),
        catchError(() => of(GetOwnPostsError()))
      ))
    ));
    getCheckLike$ = createEffect(() => this.actions$.pipe(
      ofType(GetCheckLike),
      exhaustMap(() => this.dataService.GetCheckOwnPostLike(Number(localStorage.getItem('User_Id')))
      .pipe(
        map(checklike => GetCheckLikeSuccess({checklike})),
        catchError(() => of(GetCheckLikeErrer()))
      ))
    ));

 }
