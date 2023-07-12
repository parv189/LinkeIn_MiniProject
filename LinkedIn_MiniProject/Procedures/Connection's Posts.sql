--in this procedure "User_ID" has sent request to "ConnectedUser_ID" and "ConnectedUser_ID" has made a post and "Status" is used to check, is user has liked or not
create or alter procedure usp_GetConnectionsPost1 @id int
as 
select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo,
case when(1=1) then 0 end as LikeCounts,case when(1=1) then 'notLiked' end as Status  from UserConnections uc 
join User_Post up on uc.ConnectedUser_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
--left join PostLikes pl on pl.Post_Id = up.Post_Id
where uc.User_ID = @id and uc.status = 'accepted' 
group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,up.Photo_Url,up.content,up.CreatedById,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo
--pl.PostLike_Id,pl.User_Id
order by Post_Id desc
go
--@id = x, is logedin user id
exec usp_GetConnectionsPost1 @id = 27
go

--in this procedure "User_ID" has sent request to "ConnectedUser_ID" and "ConnectedUser_ID" has made a post and "Status" is used to check, is user has liked or not
--create or alter procedure usp_CheckLike1 @id int
--as 
--select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id,
--case when(pl.User_Id = @id) then concat('Liked','/',pl.PostLike_Id) else 'notLiked' end as Status from UserConnections uc 
--join User_Post up on uc.ConnectedUser_ID = up.User_Id
--join UserInformation ui on up.CreatedById = ui.User_ID
--left join PostLikes pl on pl.Post_Id = up.Post_Id
--where uc.User_ID = @id and pl.User_ID = @id  and uc.status = 'accepted'
--group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,pl.PostLike_Id,pl.User_Id
--order by Post_Id desc
--go
--@id = x, is logedin user id
--exec usp_CheckLike1 @id = 24


--in this procedure "User_ID" has sent request to "ConnectedUser_ID" and "User_ID" has made a post and "Status" is used to check, is user has liked or not
go
create or alter procedure usp_GetConnectionsPost2 @id int
as 
select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo,
case when(1=1) then 0 end as LikeCounts, 
case when(1=1) then 'notLiked' end as Status from UserConnections uc 
join User_Post up on uc.User_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
--left join PostLikes pl on pl.Post_Id = up.Post_Id 
where uc.ConnectedUser_ID = @id and uc.status = 'accepted' 
group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,up.Photo_Url,up.content,up.CreatedById,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo
--, pl.PostLike_Id,pl.User_Id 
order by Post_Id desc
go
--@id = x, is logedin user id
exec usp_GetConnectionsPost2 @id = 24
go


--go
--create or alter procedure usp_CheckLike2 @id int
--as 
--select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, 
--case when(pl.User_Id = @id) then concat('Liked','/',pl.PostLike_Id) else 'notLiked' end as Status from UserConnections uc 
--join User_Post up on uc.User_ID = up.User_Id
--join UserInformation ui on up.CreatedById = ui.User_ID
--left join PostLikes pl on pl.User_Id = up.User_Id 
--where uc.ConnectedUser_ID = @id and pl.User_Id =@id and uc.status = 'accepted' 
--group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,pl.User_Id,pl.PostLike_Id 
--order by Post_Id desc
--go
--@id = x, is logedin user id
--exec usp_CheckLike2 @id = 24
--go




--in this procedure "User_ID" has made a post by him/her self and Liked his/her own post
go 
create or alter procedure usp_GetOwnPosts @id int
as
select DISTINCT case when(1=1) then 0 end as UserConnection_Id,case when(1=1) then 0 end as ConnectedUser_ID, up.Post_Id, up.Photo_Url,up.CreatedById, up.content, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo, ui.User_ID,
case when(1=1) then 0 end as LikeCounts,
case when(1=1) then 'notLiked' end as Status
from User_Post up 
join UserInformation ui on up.User_Id = ui.User_ID
--left join PostLikes pl on pl.Post_Id = up.Post_Id
where ui.User_ID = @id
group by up.Post_Id,up.Photo_Url,up.content,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo,ui.User_ID,up.User_Id,up.CreatedById
--@id = x, is logedin user id
exec usp_GetOwnPosts @id = 27


go 
create or alter procedure usp_CheckLike @id int
as
select up.User_Id as Postby, pl.User_Id Mylikes,pl.Post_Id,
case when(pl.User_Id = @id) then concat('Liked','/',pl.PostLike_Id) else 'notLiked' end as Status 
from User_Post up 
join UserInformation ui on up.User_Id = ui.User_ID
left join PostLikes pl on up.Post_Id = pl.Post_Id
where pl.User_ID = @id 
group by up.Post_Id,up.User_Id,
pl.PostLike_Id,
pl.User_Id,pl.Post_Id

--@id = x, is logedin user id
exec usp_CheckLike @id = 27

go
create or alter procedure usp_PostLikeCount @id int
as
select pl.Post_Id,count(pl.Post_Id)as LikeCounts from User_Post up join PostLikes pl on up.Post_Id = pl.Post_Id
where pl.Post_Id = @id
group by pl.Post_Id
exec usp_PostLikeCount @id = 10