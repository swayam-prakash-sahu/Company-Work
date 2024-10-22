USE [master]
GO
/****** Object:  Database [FitnessTracker]    Script Date: 27-03-2024 14:18:36 ******/
CREATE DATABASE [FitnessTracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FitnessTracker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FitnessTracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FitnessTracker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FitnessTracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FitnessTracker] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FitnessTracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FitnessTracker] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FitnessTracker] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FitnessTracker] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FitnessTracker] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FitnessTracker] SET ARITHABORT OFF 
GO
ALTER DATABASE [FitnessTracker] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FitnessTracker] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FitnessTracker] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FitnessTracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FitnessTracker] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FitnessTracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FitnessTracker] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FitnessTracker] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FitnessTracker] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FitnessTracker] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FitnessTracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FitnessTracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FitnessTracker] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FitnessTracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FitnessTracker] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FitnessTracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FitnessTracker] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FitnessTracker] SET RECOVERY FULL 
GO
ALTER DATABASE [FitnessTracker] SET  MULTI_USER 
GO
ALTER DATABASE [FitnessTracker] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FitnessTracker] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FitnessTracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FitnessTracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FitnessTracker] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FitnessTracker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FitnessTracker', N'ON'
GO
ALTER DATABASE [FitnessTracker] SET QUERY_STORE = ON
GO
ALTER DATABASE [FitnessTracker] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FitnessTracker]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[UserId] [int] NULL,
	[StepsTaken] [int] NULL,
	[CaloriesBurned] [int] NULL,
	[DistanceCovered] [numeric](18, 0) NULL,
	[ActiveMinutes] [numeric](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goal]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goal](
	[UserId] [int] NULL,
	[WeightLoss] [numeric](18, 0) NULL,
	[MuscleGain] [numeric](18, 0) NULL,
	[EnduranceMovement] [numeric](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nutrition]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nutrition](
	[UserId] [int] NULL,
	[Calories] [numeric](18, 0) NULL,
	[Carbohydrates] [numeric](18, 0) NULL,
	[Proteins] [numeric](18, 0) NULL,
	[Fats] [numeric](18, 0) NULL,
	[Micronutrients] [numeric](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCredential]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCredential](
	[UserId] [int] NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserEmail] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Active] [varchar](50) NULL,
 CONSTRAINT [PK_UserCredential] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UserId] [int] NULL,
	[Age] [int] NULL,
	[Gender] [varchar](50) NULL,
	[Weight] [numeric](18, 0) NULL,
	[Height] [numeric](18, 0) NULL,
	[FitnessGoals] [varchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workouts]    Script Date: 27-03-2024 14:18:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workouts](
	[UserId] [int] NULL,
	[ExerciseId] [int] NULL,
	[ExerciseType] [varchar](50) NULL,
	[Duration] [numeric](18, 0) NULL,
	[Intensity] [numeric](18, 0) NULL,
	[Sets] [numeric](18, 0) NULL,
	[Repeatitions] [numeric](18, 0) NULL,
	[Notes] [varchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_UserCredential] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_UserCredential]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_UserCredential1] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_UserCredential1]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_UserCredential2] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_UserCredential2]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_UserCredential] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_UserCredential]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_UserCredential1] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_UserCredential1]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_UserCredential2] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_UserCredential2]
GO
ALTER TABLE [dbo].[Nutrition]  WITH CHECK ADD  CONSTRAINT [FK_Nutrition_UserCredential] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Nutrition] CHECK CONSTRAINT [FK_Nutrition_UserCredential]
GO
ALTER TABLE [dbo].[Nutrition]  WITH CHECK ADD  CONSTRAINT [FK_Nutrition_UserCredential1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Nutrition] CHECK CONSTRAINT [FK_Nutrition_UserCredential1]
GO
ALTER TABLE [dbo].[Nutrition]  WITH CHECK ADD  CONSTRAINT [FK_Nutrition_UserCredential2] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Nutrition] CHECK CONSTRAINT [FK_Nutrition_UserCredential2]
GO
ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD  CONSTRAINT [FK_UserDetails_UserCredential] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[UserDetails] CHECK CONSTRAINT [FK_UserDetails_UserCredential]
GO
ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD  CONSTRAINT [FK_UserDetails_UserCredential1] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[UserDetails] CHECK CONSTRAINT [FK_UserDetails_UserCredential1]
GO
ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD  CONSTRAINT [FK_UserDetails_UserCredential2] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[UserDetails] CHECK CONSTRAINT [FK_UserDetails_UserCredential2]
GO
ALTER TABLE [dbo].[Workouts]  WITH CHECK ADD  CONSTRAINT [FK_Workouts_UserCredential] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Workouts] CHECK CONSTRAINT [FK_Workouts_UserCredential]
GO
ALTER TABLE [dbo].[Workouts]  WITH CHECK ADD  CONSTRAINT [FK_Workouts_UserCredential1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Workouts] CHECK CONSTRAINT [FK_Workouts_UserCredential1]
GO
ALTER TABLE [dbo].[Workouts]  WITH CHECK ADD  CONSTRAINT [FK_Workouts_UserCredential2] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[UserCredential] ([UserId])
GO
ALTER TABLE [dbo].[Workouts] CHECK CONSTRAINT [FK_Workouts_UserCredential2]
GO
USE [master]
GO
ALTER DATABASE [FitnessTracker] SET  READ_WRITE 
GO
