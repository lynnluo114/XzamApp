create procedure proc_saveData(@name nvarchar(50), @backtrack bit,@shuffleoptions bit)
as
begin
	

	insert into QuestionBank output inserted.id values(@name, @backtrack, @shuffleoptions);

end


--exec saveData @name='QBank Midterm', @backtrack=1,@shuffleoptions=0