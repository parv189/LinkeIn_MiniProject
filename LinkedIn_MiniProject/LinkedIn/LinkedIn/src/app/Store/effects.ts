import { DataService } from 'src/app/Services/data.service';
import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { EMPTY, of } from 'rxjs';
import { map, exhaustMap, catchError, mergeMap, switchMap } from 'rxjs/operators';
import { AddPostLike, AddPostLikeError, AddPostLikeSuccess, DeletePostLike, DeletePostLikeError, DeletePostLikeSuccess, GetPosts, GetPostsError, GetPostsSuccess } from './action';



@Injectable()
export class PostEffects {
  constructor(
    private actions$: Actions,
    private dataService: DataService
  ) {}

    getPosts1$ = createEffect(() => this.actions$.pipe(
      ofType(GetPosts),
      exhaustMap(() => this.dataService.GetConnectionsPost(Number(localStorage.getItem('User_Id')))
      .pipe(
        map(posts => GetPostsSuccess({posts})),
        catchError(() => of(GetPostsError()))
      ))
    ));
    addLike$=createEffect(()=> this.actions$.pipe(
        ofType(AddPostLike),
        mergeMap(({id,user})=>
        this.dataService.AddPostLikes(id,user).
        pipe(map((like)=> AddPostLikeSuccess({like})),
        catchError(()=>of(AddPostLikeError()))
     ))
    ));
    deleteLike$=createEffect(()=> this.actions$.pipe(
            ofType(DeletePostLike),
            mergeMap(({id})=>
            this.dataService.DeletePostLikes(id).
            pipe(map((like)=> DeletePostLikeSuccess({like})),
            catchError(()=>of(DeletePostLikeError()))
         ))
        ));


    // getPosts2$ = createEffect(() => this.actions$.pipe(
    //   ofType(GetPosts2),
    //   exhaustMap(() => this.dataService.GetConnectionsPost2(Number(localStorage.getItem('User_Id')))
    //   .pipe(
    //     map(posts => GetPostsSuccess2({posts})),
    //     catchError(() => of(GetPostsError2()))
    //   ))
    // ));
    // getOwnPosts$ = createEffect(() => this.actions$.pipe(
    //   ofType(GetOwnPosts),
    //   exhaustMap(() => this.dataService.GetOwnPosts(Number(localStorage.getItem('User_Id')))
    //   .pipe(
    //     map(ownposts => GetOwnPostsSuccess({ownposts})),
    //     catchError(() => of(GetOwnPostsError()))
    //   ))
    // ));
    // getCheckLike$ = createEffect(() => this.actions$.pipe(
    //   ofType(GetCheckLike),
    //   exhaustMap(() => this.dataService.GetCheckOwnPostLike(Number(localStorage.getItem('User_Id')))
    //   .pipe(
    //     map(checklike => GetCheckLikeSuccess({checklike})),
    //     catchError(() => of(GetCheckLikeErrer()))
    //   ))
    // ));

 }
