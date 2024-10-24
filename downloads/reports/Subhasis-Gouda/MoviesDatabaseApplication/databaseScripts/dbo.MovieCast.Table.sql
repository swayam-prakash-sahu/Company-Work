USE [MoviesDatabase]
GO
/****** Object:  Table [dbo].[MovieCast]    Script Date: 28-03-2024 12:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieCast](
	[MoviecastID] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[CastID] [int] NOT NULL,
	[Role] [varchar](255) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MoviecastID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MovieCast]  WITH CHECK ADD FOREIGN KEY([CastID])
REFERENCES [dbo].[Castcrew] ([CastID])
GO
ALTER TABLE [dbo].[MovieCast]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
