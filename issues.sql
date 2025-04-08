USE [Kütüphane_Yönetim]
GO

/****** Object:  Table [dbo].[issues]    Script Date: 8.04.2025 17:04:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[issues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[issue_id] [nvarchar](50) NOT NULL,
	[full_name] [nvarchar](255) NOT NULL,
	[contact] [nvarchar](50) NULL,
	[email] [nvarchar](255) NULL,
	[book_title] [nvarchar](255) NOT NULL,
	[author] [nvarchar](255) NOT NULL,
	[issue_date] [date] NOT NULL,
	[return_date] [date] NULL,
	[status] [nvarchar](50) NULL,
	[date_insert] [datetime] NULL,
	[date_update] [datetime] NULL,
	[date_delete] [datetime] NULL,
	[book_type] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[issue_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[issues] ADD  DEFAULT ('Not Return') FOR [status]
GO

ALTER TABLE [dbo].[issues] ADD  DEFAULT (getdate()) FOR [date_insert]
GO

