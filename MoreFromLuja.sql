alter procedure proc_saveQuestionBank(@name nvarchar(50), @backtrack bit,@shufflequestions bit)
as
begin 
	insert into QuestionBank output inserted.id (name,backtrack,shufflequestions) values(@name, @backtrack, @shufflequestions);

end
create procedure proc_updateQuestionBank(@id int,@name nvarchar(50), @backtrack bit,@shufflequestions bit)
as
begin 
	update QuestionBank set name =@name, backtrack =@backtrack, shufflequestions =@shufflequestions where id=@id;
	
end
create procedure proc_getQuestionBank @id int
as
begin
	if @id=0 
	begin
		select * from QuestionBank;
	end
	else
	begin
		select * from questionbank where id=@id;
	end
end
--exec saveData @name='QBank Midterm', @backtrack=1,@shuffleoptions=0