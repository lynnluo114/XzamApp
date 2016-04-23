CREATE TABLE [dbo].[Exam] (
    [examcode]  NVARCHAR (20) NOT NULL,
    [examtitle] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([examcode] ASC)
);



CREATE TABLE [dbo].[ExamSchedule] (
    [scheduleid]   INT           IDENTITY (1, 1) NOT NULL,
    [examcode]     NVARCHAR (20) NOT NULL,
    [qbankid]      INT           NOT NULL,
    [scheduledate] DATETIME      NOT NULL,
    [starttime]    TIME (7)      NOT NULL,
    [endtime]      TIME (7)      NOT NULL,
    PRIMARY KEY CLUSTERED ([scheduleid] ASC),
    CONSTRAINT [FK_ExamSchedule_Exam] FOREIGN KEY ([examcode]) REFERENCES [dbo].[Exam] ([examcode])
);

CREATE TABLE [dbo].[StudentSchedule] (
    [studentid]  VARCHAR (20) NOT NULL,
    [scheduleid] INT           NOT NULL,
    [grade]      DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_StudentSchedule] PRIMARY KEY CLUSTERED ([studentid] ASC, [scheduleid] ASC),
    CONSTRAINT [FK_StudentSchedule_ExamSchedule] FOREIGN KEY ([scheduleid]) REFERENCES [dbo].[ExamSchedule] ([scheduleid]), 
    CONSTRAINT [FK_StudentSchedule_USER_TABLE] FOREIGN KEY ([studentid]) REFERENCES [USER_TABLE]([Username])
);

CREATE TABLE [dbo].[StudentGrade] (
    [studentId]   VARCHAR(20) NOT NULL,
    [examcode]    NVARCHAR (20) NOT NULL,
    [gradepoints] DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_StudentGrade] PRIMARY KEY CLUSTERED ([studentId] ASC, [examcode] ASC),
    CONSTRAINT [FK_StudentGrade_Exam] FOREIGN KEY ([examcode]) REFERENCES [dbo].[Exam] ([examcode]), 
    CONSTRAINT [FK_StudentGrade_USER_TABLE] FOREIGN KEY ([studentid]) REFERENCES [USER_TABLE]([Username])
);





