create or alter procedure usp_Invinations @id int
as
select uc.UserConnection_Id,uc.User_ID, uc.ConnectedUser_ID,uc.CreatedByDate,uc.status,ui.FirstName,ui.LastName,ui.User_Headline,ui.User_Profile_photo 
from UserConnections uc join UserInformation ui on uc.User_ID = ui.User_ID
where uc.ConnectedUser_ID = @id
go

exec usp_Invinations @id=24

go
create or alter procedure usp_MyNetwork1 @id int
as
select uc.UserConnection_Id ,uc.ConnectedUser_ID as me,uc.User_ID as connection,uc.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo
from UserConnections uc join UserInformation ui on uc.User_ID = ui.User_ID
where uc.ConnectedUser_ID = @id and uc.status = 'accepted'

exec usp_MyNetwork1 @id=24

go
create or alter procedure usp_MyNetwork2 @id int
as
select uc.UserConnection_Id,uc.ConnectedUser_ID as connection,uc.User_ID as me,uc.CreatedByDate,ui.FirstName,ui.LastName,ui.User_Profile_photo
from UserConnections uc join UserInformation ui on uc.ConnectedUser_ID = ui.User_ID
where uc.User_ID = @id and uc.status = 'accepted'

exec usp_MyNetwork2 @id=24