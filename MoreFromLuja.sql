alter procedure proc_saveQuestionBank(@name nvarchar(50), @backtrack bit,@shufflequestions bit,@id int output)  
as
begin 
	insert into QuestionBank  (name,backtrack,shufflequestions) values(@name, @backtrack, @shufflequestions);
	
    SELECT @id = SCOPE_IDENTITY()
end
create procedure proc_updateQuestionBank(@id int,@name nvarchar(50), @backtrack bit,@shufflequestions bit)
as
begin 
	update QuestionBank set name =@name, backtrack =@backtrack, shufflequestions =@shufflequestions where id=@id;
	
end
alter procedure proc_getQuestionBank @id int=0
as
begin
	if @id=0 
	begin
		select id,name,backtrack,shufflequestions from QuestionBank;
	end
	else
	begin
		select id,name,backtrack,shufflequestions from questionbank where id=@id;
	end
end
--exec saveData @name='QBank Midterm', @backtrack=1,@shuffleoptions=0
-- select * from questions
alter procedure proc_saveQuestion(@title nvarchar(50), @gradepoint int,@shuffleoptions bit=0,@correctoption char(1),@qbankid int, @qid int output)  
as
begin 
	insert into questions  (title,correctoption,shuffleoptions,gradepoint,qbankid) 
	values(@title,@correctoption,@shuffleoptions,@gradepoint,@qbankid);
	
    SELECT @qid = SCOPE_IDENTITY()
end
alter procedure proc_updateQuestion(@title nvarchar(50), @gradepoint int,@shuffleoptions bit=0,@correctoption char(1),@qbankid int, @qid int )
as
begin 
	update questions set title=@title, correctoption=@correctoption, shuffleoptions=@shuffleoptions,qbankid=@qbankid, gradepoint=@gradepoint 
	where qid=@qid
	
end


create procedure proc_getQuestions @qbankid int
as
begin
	select qid,correctoption,title,shuffleoptions,gradepoint, qbankid
	 from questions where qbankid=@qbankid;
	 
end

create procedure proc_deleteQuestions @qbankid int
as
begin
	delete from Questions where qbankid = @qbankid
end


-- select * from options;
create procedure proc_saveOptions @qid int, 
		@code char(1),@optiontext nvarchar(200),
		@oid int output
as
begin
	insert into options (qid,code,optiontext) 
		values(@qid, @code,@optiontext)
		
    SELECT @oid = SCOPE_IDENTITY()
end
create procedure proc_deleteOptions @qid int
as
begin
	delete from options where qid = @qid
end

create procedure proc_UpdateOptions @qid int, @code char(1), @optiontext nvarchar(200), @oid int
as
begin
	update options set qid =@qid, code=@code, optiontext =@optiontext
	where oid =@oid
end

-- alter table questions add qbankid int foreign key references questionbank(id);

select * from options;

create procedure proc_getQuestions @qbankid int
as
begin
	select qid,correctoption,title,shuffleoptions,gradepoint, qbankid
	 from questions where qbankid=@qbankid;
	 
end