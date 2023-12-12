create table CourseDetail
(
[ID] [bigint] primary key identity (1,1),
[CourseName] [nvarchar](40) NOT NULL,
[Duration][datetime2](7) NOT Null,
[StartDate][datetime2](7) NOT Null,
[NumberOfStudents] [bigint] NOT NULL,
[ContactPerson] [nvarchar] (40) NOT NULL,

)
select * from CourseDetail
drop table CourseDetail 

--inserting--
 drop procedure CourseDetailInsert

create Procedure CourseDetailInsert
(
 @CourseName nvarchar(100), @Duration datetime2(7), @StartDate datetime2(7), @NumberOfStudents bigint ,  @contactPerson nvarchar(40) 
)
as
begin

insert into CourseDetail values ( @CourseName, @Duration, @StartDate, @NumberOfStudents, @contactPerson)

end

exec CourseDetailInsert 'FullStack','03-12-2023','11-11-2023',10,'Suresh'
exec CourseDetailInsert 'python', '02-12-2023','12-12-2023',20,'Rohit'

--updating--

drop procedure CourseDetailUpdate

create Procedure CourseDetailUpdate
(

@ID bigint,@CourseName nvarchar(100), @Duration datetime2(7), @StartDate datetime2(7), @NumberOfStudents bigint ,  @contactPerson nvarchar(40) 
)
as
begin

update CourseDetail set CourseName = @CourseName, Duration =@Duration ,@StartDate = @StartDate ,NumberOfStudents =@NumberOfStudents, ContactPerson = @ContactPerson where ID =@ID

end

exec CourseDetailUpdate 2,'Java','04-12-2023','12-12-2023',15,'Sastha'

--Read--
drop procedure CourseDetailRead
create Procedure CourseDetailRead
as 
begin
select * from CourseDetail

end

exec CourseDetailRead


--Deleting--
drop procedure CourseDetailDelete
create Procedure CourseDetailDelete
(@ID bigint)
as
begin

Delete from CourseDetail where ID =@ID

end

exec CourseDetailDelete 1 
