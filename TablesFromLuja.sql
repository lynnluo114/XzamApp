USE [xzamdb]
GO

/****** Object:  Table [dbo].[Options]    Script Date: 4/17/2016 8:31:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Options](
	[oid] [int] IDENTITY(1,1) NOT NULL,
	[qid] [int] NULL,
	[code] [char](1) NULL,
	[optiontext] [nvarchar](200) NULL,
 CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED 
(
	[oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
 
GO

/****** Object:  Table [dbo].[QuestionBank]    Script Date: 4/17/2016 8:32:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QuestionBank](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[backtrack] [bit] NULL,
	[shufflequestions] [bit] NULL,
 CONSTRAINT [PK_QuestionBankk_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO




GO

/****** Object:  Table [dbo].[Questions]    Script Date: 4/17/2016 8:32:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Questions](
	[qid] [int] IDENTITY(1,1) NOT NULL,
	[correctoption] [nchar](1) NULL,
	[title] [nvarchar](200) NULL,
	[shuffleoptions] [bit] NULL CONSTRAINT [DF_Questions_shuffleoptions]  DEFAULT ((0)),
	[gradepoint] [numeric](5, 2) NULL CONSTRAINT [DF_Questions_gradepoint]  DEFAULT ((1)),
	[qbankid] [int] NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[qid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Questions]  WITH CHECK ADD FOREIGN KEY([qbankid])
REFERENCES [dbo].[QuestionBank] ([id])
GO

 
GO

/****** Object:  Table [dbo].[QuestionBankQuestions]    Script Date: 4/17/2016 8:33:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QuestionBankQuestions](
	[qbid] [int] NULL,
	[qid] [int] NULL
) ON [PRIMARY]

GO

