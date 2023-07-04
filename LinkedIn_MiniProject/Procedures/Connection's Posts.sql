--in this procedure "User_ID" has sent request to "ConnectedUser_ID" and "ConnectedUser_ID" has made a post and "LikedBy" have Liked the post
create or alter procedure usp_GetConnectionsPost1 @id int
as 
select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo,
COUNT(pl.User_Id)as LikeCounts from UserConnections uc 
join User_Post up on uc.ConnectedUser_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
left join PostLikes pl on pl.Post_Id = up.Post_Id
where uc.User_ID = @id and uc.status = 'accepted' 
group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,up.Photo_Url,up.content,up.CreatedById,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo
order by Post_Id desc
go
--@id = x, is logedin user id
exec usp_GetConnectionsPost1 @id = 24

--in this procedure "User_ID" has sent request to "ConnectedUser_ID" and "User_ID" has made a post and "LikedBy" have Liked the post
go
create or alter procedure usp_GetConnectionsPost2 @id int
as 
select DISTINCT uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo,
COUNT(pl.User_Id)as LikeCounts from UserConnections uc 
join User_Post up on uc.User_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
left join PostLikes pl on pl.Post_Id = up.Post_Id 
where uc.ConnectedUser_ID = @id and uc.status = 'accepted' 
group by uc.UserConnection_Id,uc.User_ID,uc.ConnectedUser_ID,up.Post_Id,up.Photo_Url,up.content,up.CreatedById,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo 
order by Post_Id desc
go
--@id = x, is logedin user id
exec usp_GetConnectionsPost2 @id = 24

--in this procedure "User_ID" has made a post by him/her self and Liked his/her own post
go 
create or alter procedure usp_GetOwnPosts @id int
as
select DISTINCT up.Post_Id, up.Photo_Url, up.content, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo, ui.User_ID, COUNT(pl.User_Id)as LikeCounts from User_Post up 
join UserInformation ui on up.User_Id = ui.User_ID
left join PostLikes pl on pl.Post_Id = up.Post_Id
where ui.User_ID = @id
group by up.Post_Id,up.Photo_Url,up.content,up.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo,ui.User_ID
--@id = x, is logedin user id
exec usp_GetOwnPosts @id = 24