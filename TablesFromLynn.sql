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
    [scheduleid]  INT           NULL,
    [grade]       DECIMAL (18)  NULL,
    [userid]      INT           NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([studentid]),
    CONSTRAINT [FK_Student_User_Table] FOREIGN KEY ([scheduleid]) REFERENCES [dbo].[ExamSchedule] ([scheduleid]),
    CONSTRAINT [FK_Student_User_Table] FOREIGN KEY ([userid]) REFERENCES [dbo].[User_Table] ([id])
);

