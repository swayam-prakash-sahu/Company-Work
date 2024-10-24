USE [MoviesDatabase]
GO
/****** Object:  Table [dbo].[UserInteraction]    Script Date: 28-03-2024 12:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInteraction](
	[UserID] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[Watchlist] [bit] NOT NULL,
	[Favorite] [bit] NOT NULL,
	[Views] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserInteraction]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[UserInteraction]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
