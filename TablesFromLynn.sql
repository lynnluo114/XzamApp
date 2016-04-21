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

CREATE TABLE [dbo].[Student] (
    [studentid]   NVARCHAR (10) NOT NULL,
    [studentname] NVARCHAR (30) NOT NULL,
    [username]    NVARCHAR (20) NOT NULL,
    [password]    NVARCHAR (20) NOT NULL,
    [userid]      INT           NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([studentid])
);

CREATE TABLE [dbo].[StudentSchedule] (
    [studentid]   NVARCHAR (10) NOT NULL,
    [scheduleid]  INT NOT NULL,
    [grade]       decimal NOT NULL,
    CONSTRAINT [PK_StudentSchedule] PRIMARY KEY ([studentid],[scheduleid]), 
    CONSTRAINT [FK_StudentSchedule_Student] FOREIGN KEY ([studentid]) REFERENCES [Student]([studentid]), 
    CONSTRAINT [FK_StudentSchedule_ExamSchedule] FOREIGN KEY ([scheduleid]) REFERENCES [ExamSchedule]([scheduleid])
);

CREATE TABLE [dbo].[StudentGrade] (
    [studentId]   NVARCHAR (10) NOT NULL,
    [examcode]    NVARCHAR (20) NOT NULL,
    [gradepoints] DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_StudentGrade] PRIMARY KEY CLUSTERED ([studentId] ASC, [examcode] ASC),
    CONSTRAINT [FK_StudentGrade_Student] FOREIGN KEY ([studentId]) REFERENCES [dbo].[Student] ([studentid]),
    CONSTRAINT [FK_StudentGrade_Exam] FOREIGN KEY ([examcode]) REFERENCES [dbo].[Exam] ([examcode])
);





