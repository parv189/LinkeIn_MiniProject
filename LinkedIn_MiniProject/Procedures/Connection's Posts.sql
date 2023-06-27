create or alter procedure usp_GetConnectionsPost1 @id int
as 
select uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo from UserConnections uc join User_Post up on uc.ConnectedUser_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
where uc.User_ID = @id and uc.status = 'accepted' order by Post_Id desc
go

exec usp_GetConnectionsPost1 @id = 24

go
create or alter procedure usp_GetConnectionsPost2 @id int
as 
select uc.UserConnection_Id, uc.User_ID, uc.ConnectedUser_ID, up.Post_Id, up.Photo_Url, up.content, up.CreatedById, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo  from UserConnections uc join User_Post up on uc.User_ID = up.User_Id
join UserInformation ui on up.CreatedById = ui.User_ID
where uc.ConnectedUser_ID = @id and uc.status = 'accepted' order by Post_Id desc
go

exec usp_GetConnectionsPost2 @id = 23

go 
create or alter procedure usp_GetOwnPosts @id int
as
select up.Post_Id, up.Photo_Url, up.content, up.CreatedByDate,ui.FirstName, ui.LastName, ui.User_Profile_photo, ui.User_ID from User_Post up join UserInformation ui on up.User_Id = ui.User_ID
where ui.User_ID = @id
exec usp_GetOwnPosts @id = 24