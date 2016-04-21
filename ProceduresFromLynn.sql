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

CREATE procedure [dbo].[proc_saveStduentGrade] @studentid nvarchar(10),@examcode nvarchar(20),@grade decimal
as
begin
	insert into StudentGrade values(@studentid,@examcode,@grade);
end

CREATE procedure [dbo].[proc_saveStduentSchedule] @studentid nvarchar(10),@scheduleid int,@gradepoints decimal
as
begin
	insert into StudentSchedule values(@studentid,@scheduleid,@gradepoints);
end

CREATE procedure [dbo].[proc_getStudentSchedule]
as
begin
	select scheduleid as scheduleid,Exam.examcode as examcode,Exam.examtitle as examtitle,scheduledate,starttime,endtime from Exam,ExamSchedule
	where Exam.examcode = ExamSchedule.examcode 
end
GO
