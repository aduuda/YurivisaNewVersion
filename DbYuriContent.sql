USE [newDS]
GO
ALTER TABLE [dbo].[YuriContent] DROP CONSTRAINT [DF_YuriContent_ViewCount]
GO
ALTER TABLE [dbo].[YuriContent] DROP CONSTRAINT [DF_YuriContent_Status]
GO
ALTER TABLE [dbo].[YuriContent] DROP CONSTRAINT [DF_YuriContent_CreatedDate]
GO
/****** Object:  Table [dbo].[YuriContent]    Script Date: 3/12/2019 10:10:24 AM ******/
DROP TABLE [dbo].[YuriContent]
GO
/****** Object:  Table [dbo].[YuriContent]    Script Date: 3/12/2019 10:10:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YuriContent](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](250) NULL,
	[CategoryID] [bigint] NULL,
	[Detail] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nchar](10) NULL,
	[Status] [bit] NULL,
	[ViewCount] [nchar](10) NULL,
 CONSTRAINT [PK_YuriContent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[YuriContent] ON 

INSERT [dbo].[YuriContent] ([ID], [Name], [MetaTitle], [Description], [Image], [CategoryID], [Detail], [CreatedDate], [CreatedBy], [Status], [ViewCount]) VALUES (1, N'Bài viết 1', N'hi-hi', N'<p>DSDSDS</p><p><img alt="" src="/Areas/Admin/Content/images/ChucTet_VietHan1.jpg" style="height:68px; width:120px" /></p>', N'/Areas/Admin/Content/images/ChucTet_VietHan1.jpg', NULL, NULL, NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[YuriContent] OFF
ALTER TABLE [dbo].[YuriContent] ADD  CONSTRAINT [DF_YuriContent_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[YuriContent] ADD  CONSTRAINT [DF_YuriContent_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[YuriContent] ADD  CONSTRAINT [DF_YuriContent_ViewCount]  DEFAULT ((0)) FOR [ViewCount]
GO
