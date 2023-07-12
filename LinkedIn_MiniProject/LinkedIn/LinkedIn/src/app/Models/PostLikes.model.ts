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
  likeCounts: number,
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

export interface user{
  user_ID: number,
  firstName: string,
  lastName: string,
  email: string,
  phoneNumber: string,
  passwordHash: string,
  passwordSalt: string,
  user_Profile_photo: string,
  user_Background_photo: string,
  user_Headline: string,
  user_Current_position: string,
  user_Education: string,
  user_Location: string,
  user_Industry: string,
  user_Contact_Info: string,
  user_Summary: string,
  createdById: number,
  createdByDate: string,
  modifiedById: number,
  modifiedByDate: string
}
export interface like{
  postLike_Id:number
  user_Id : number
  post_Id : number
  createdById : number
  createdByDate : string
  modifiedById : number
  modifiedByDate : string
}
