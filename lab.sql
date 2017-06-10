USE [master]
GO
/****** Object:  Database [lab]    Script Date: 10.06.2017 18:28:32 ******/
CREATE DATABASE [lab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'lab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\lab.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'lab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\lab_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [lab] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [lab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [lab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [lab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [lab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [lab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [lab] SET ARITHABORT OFF 
GO
ALTER DATABASE [lab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [lab] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [lab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [lab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [lab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [lab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [lab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [lab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [lab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [lab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [lab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [lab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [lab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [lab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [lab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [lab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [lab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [lab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [lab] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [lab] SET  MULTI_USER 
GO
ALTER DATABASE [lab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [lab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [lab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [lab] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [lab]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.06.2017 18:28:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](25) NOT NULL,
	[price] [money] NULL,
	[description] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 10.06.2017 18:28:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seller](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](25) NOT NULL,
	[surname] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [lab] SET  READ_WRITE 
GO
