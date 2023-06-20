--Procedures
create or alter procedure get_Locations @i int
As
select ob.Object_Id as Id, ob.Object_Name as Location from Objects ob Join ObjectTypes obt on ob.ObjectType_Id = obt.ObjectType_Id
where obt.ObjectType_Id = @i

exec get_Locations @i=1
