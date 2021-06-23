
USE [master]
GO


CREATE DATABASE [Pessoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pessoa', FILENAME = N'E:\BancoDeDadosProjetos\Data\Pessoa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pessoa_log', FILENAME = N'E:\BancoDeDadosProjetos\Data\Pessoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Pessoa] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pessoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Pessoa] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Pessoa] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Pessoa] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Pessoa] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Pessoa] SET ARITHABORT OFF 
GO

ALTER DATABASE [Pessoa] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Pessoa] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Pessoa] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Pessoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Pessoa] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Pessoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Pessoa] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Pessoa] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Pessoa] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Pessoa] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Pessoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Pessoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Pessoa] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Pessoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Pessoa] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Pessoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Pessoa] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Pessoa] SET RECOVERY FULL 
GO

ALTER DATABASE [Pessoa] SET  MULTI_USER 
GO

ALTER DATABASE [Pessoa] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Pessoa] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Pessoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Pessoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Pessoa] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Pessoa] SET QUERY_STORE = OFF
GO

USE [Pessoa]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Pessoa] SET  READ_WRITE 
GO


