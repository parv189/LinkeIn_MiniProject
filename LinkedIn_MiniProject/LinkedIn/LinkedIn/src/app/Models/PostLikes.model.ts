export interface posts{
  post_Id: number,
  userConnection_Id: number,
  user_ID: number,
  connectedUser_ID: number,
  photo_Url: string,
  content: string,
  createdById: number,
  createdByDate: string,
  firstName: string,
  lastName: string,
  user_Profile_photo: string,
  likeCounts: 0,
  status: string
}
export interface ownposts{
  post_Id: number,
  user_ID: number,
  photo_Url: string,
  content: string,
  createdByDate: string,
  firstName: string,
  lastName: string,
  user_Profile_photo: string,
  likeCounts: 0,
  status: string
}

export interface checklike{
  post_Id: number,
  postby: number,
  mylikes: number,
  status: string
}

