export interface postlikes{
  postLike_Id: number,
  user_Id: number,
  post_Id: number,
  createdById: number,
  createdByDate: string,
  modifiedById: number |null,
  modifiedByDate: string | null
}
