create or alter procedure usp_Invinations @id int
as
select uc.UserConnection_Id,uc.User_ID, uc.ConnectedUser_ID,uc.CreatedByDate,uc.status,ui.FirstName,ui.LastName,ui.User_Headline,ui.User_Profile_photo from UserConnections uc join UserInformation ui on uc.User_ID = ui.User_ID
where uc.ConnectedUser_ID = @id
go

exec usp_Invinations @id=14

go
create or alter procedure usp_MyNetwork @id int
as
select * from UserConnections uc join UserInformation ui on uc.User_ID = ui.User_ID
where uc.ConnectedUser_ID = @id

exec usp_MyNetwork @id=24