USE [Kütüphane_Yönetim]
GO

/****** Object:  Table [dbo].[books]    Script Date: 8.04.2025 17:04:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[book_title] [nvarchar](255) NOT NULL,
	[author] [nvarchar](255) NOT NULL,
	[published_date] [date] NULL,
	[image] [nvarchar](max) NULL,
	[status] [nvarchar](50) NULL,
	[date_insert] [datetime] NULL,
	[date_update] [datetime] NULL,
	[date_delete] [datetime] NULL,
	[book_type] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[books] ADD  DEFAULT (getdate()) FOR [date_insert]
GO

