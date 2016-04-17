USE [xzamdb]
GO

/****** Object:  StoredProcedure [dbo].[proc_deleteOptions]    Script Date: 4/17/2016 8:35:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_deleteOptions] @qid int
as
begin
	delete from options where qid = @qid
end
GO 

GO

 
 
GO

/****** Object:  StoredProcedure [dbo].[proc_deleteQuestionBank]    Script Date: 4/17/2016 8:35:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- exec proc_deletequestionbank 

alter procedure [dbo].[proc_deleteQuestionBank] @qbankid int
as
begin
	exec [proc_deleteQuestions] @qbankid
	delete from QuestionBank where  id = @qbankid
	delete from questionbankquestions where qbid=@qbankid
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_deleteQuestions]    Script Date: 4/17/2016 8:36:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

alter procedure [dbo].[proc_deleteQuestions] @qbankid int
as
begin
	delete from options where qid in (select qid from questions where qbankid =@qbankid)
	delete from Questions where qbankid = @qbankid
	delete from questionbankquestions where qbid = @qbankid
	
end
GO 

GO

/****** Object:  StoredProcedure [dbo].[proc_getOptions]    Script Date: 4/17/2016 8:36:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_getOptions] @questionid int
as
begin
	select oid,qid,code,optiontext
	 from options where qid =@questionid;
	 
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_getQuestionBank]    Script Date: 4/17/2016 8:36:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[proc_getQuestionBank] @id int=0
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
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_getQuestions]    Script Date: 4/17/2016 8:36:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_getQuestions] @qbankid int
as
begin
	select * from questions where qbankid=@qbankid;
	 
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_saveOptions]    Script Date: 4/17/2016 8:36:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_saveOptions] @qid int, 
		@code char(1),@optiontext nvarchar(200),
		@oid int output
as
begin
	insert into options (qid,code,optiontext) 
		values(@qid, @code,@optiontext)
		
    SELECT @oid = SCOPE_IDENTITY()
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_saveQuestion]    Script Date: 4/17/2016 8:36:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[proc_saveQuestion](@title nvarchar(50), @gradepoint int,@shuffleoptions bit=0,@correctoption char(1),@qbankid int, @qid int output)  
as
begin 
	insert into questions  (title,correctoption,shuffleoptions,gradepoint,qbankid) 
	values(@title,@correctoption,@shuffleoptions,@gradepoint,@qbankid);
	
    SELECT @qid = SCOPE_IDENTITY()
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_saveQuestionBank]    Script Date: 4/17/2016 8:37:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[proc_saveQuestionBank](@name nvarchar(50), @backtrack bit,@shufflequestions bit,@id int output)  
as
begin 
	insert into QuestionBank  (name,backtrack,shufflequestions) values(@name, @backtrack, @shufflequestions);
	
    SELECT @id = SCOPE_IDENTITY()
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_UpdateOptions]    Script Date: 4/17/2016 8:37:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_UpdateOptions] @qid int, @code char(1), @optiontext nvarchar(200), @oid int
as
begin
	update options set qid =@qid, code=@code, optiontext =@optiontext
	where oid =@oid
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_updateQuestion]    Script Date: 4/17/2016 8:37:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[proc_updateQuestion](@title nvarchar(50), @gradepoint int,@shuffleoptions bit=0,@correctoption char(1),@qbankid int, @qid int )
as
begin 
	update questions set title=@title, correctoption=@correctoption, shuffleoptions=@shuffleoptions,qbankid=@qbankid, gradepoint=@gradepoint 
	where qid=@qid
	
end
GO
 
GO

/****** Object:  StoredProcedure [dbo].[proc_updateQuestionBank]    Script Date: 4/17/2016 8:37:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_updateQuestionBank](@id int,@name nvarchar(50), @backtrack bit,@shufflequestions bit)
as
begin 
	update QuestionBank set name =@name, backtrack =@backtrack, shufflequestions =@shufflequestions where id=@id;
	
end
GO

