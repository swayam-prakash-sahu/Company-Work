USE [MoviesDatabase]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 28-03-2024 12:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] NOT NULL,
	[Title] [varchar](255) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[Genre] [varchar](255) NOT NULL,
	[PlotSynopsis] [varchar](max) NOT NULL,
	[Runtime] [time](7) NOT NULL,
	[PosterArt] [varchar](255) NOT NULL,
	[IsReleased] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
