CREATE PROCEDURE [dbo].[proc_getExams]
AS
BEGIN
	SELECT examcode, examtitle FROM Exam
END


CREATE PROCEDURE [dbo].[proc_getStudents]
AS
BEGIN
	SELECT studentid, studentname FROM Student
END

create procedure [dbo].[proc_saveExam] @examcode nvarchar(20), 
		@examtitle nvarchar(50)
as
begin
	insert into Exam(examcode,examtitle) 
		values(@examcode, @examtitle)
end

CREATE procedure [dbo].[proc_saveExamSchedule](@examcode nvarchar(20),@qbankid int,@scheduledate date, @starttime time,@endtime time,@scheduleid int output)  
as
begin 
	insert into ExamSchedule(examcode,qbankid,scheduledate,starttime,endtime) 
	values(@examcode,@qbankid,@scheduledate,@starttime,@endtime);
	
    SELECT @scheduleid = SCOPE_IDENTITY()
end

CREATE procedure [dbo].[proc_saveStduentGrade] @scheduleid int,  @studentid nvarchar(10),@grade decimal
as
begin
	update Student set grade=@grade
	where scheduleid =@scheduleid and studentid =@studentid 
end

CREATE procedure [dbo].[proc_saveStduentSchedule] @scheduleid int,  @studentid nvarchar(10)
as
begin
	update Student set scheduleid =@scheduleid
	where studentid =@studentid
end

CREATE procedure [dbo].[proc_getStudentSchedule] @userid int
as
begin
	select ExamSchedule.scheduleid as scheduleid,Exam.examcode as examcode,Exam.examtitle as examtitle,scheduledate,starttime,endtime from Exam,ExamSchedule,Student,User_Table
	where Exam.examcode = ExamSchedule.examcode 
	and ExamSchedule.scheduleid = Student.scheduleid 
	and Student.userid = User_Table.id
	and User_Table.id = @userid;
end
GO
