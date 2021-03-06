USE [master]
GO
/****** Object:  Database [Desafio_Bludata]    Script Date: 28/09/2020 21:22:23 ******/
CREATE DATABASE [Desafio_Bludata]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Desafio_Bludata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Desafio_Bludata.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Desafio_Bludata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Desafio_Bludata_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Desafio_Bludata] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Desafio_Bludata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Desafio_Bludata] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET ARITHABORT OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Desafio_Bludata] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Desafio_Bludata] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Desafio_Bludata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Desafio_Bludata] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET RECOVERY FULL 
GO
ALTER DATABASE [Desafio_Bludata] SET  MULTI_USER 
GO
ALTER DATABASE [Desafio_Bludata] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Desafio_Bludata] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Desafio_Bludata] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Desafio_Bludata] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Desafio_Bludata] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Desafio_Bludata', N'ON'
GO
ALTER DATABASE [Desafio_Bludata] SET QUERY_STORE = OFF
GO
USE [Desafio_Bludata]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 28/09/2020 21:22:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[idEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[nomeEmpresa] [nvarchar](50) NOT NULL,
	[cnpj] [nvarchar](18) NOT NULL,
	[uf] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 28/09/2020 21:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nomeForn] [nvarchar](50) NOT NULL,
	[cpf_cnpj] [nvarchar](18) NOT NULL,
	[rg] [nvarchar](18) NULL,
	[nascimento] [date] NULL,
	[dataCadastro] [datetime] NOT NULL,
	[idEmpresa] [int] NOT NULL,
	[fisicaJuridica] [char](1) NOT NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[idFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedores_tel]    Script Date: 28/09/2020 21:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores_tel](
	[idTelefone] [int] IDENTITY(1,1) NOT NULL,
	[telefone] [nvarchar](14) NOT NULL,
	[idFornecedor] [int] NOT NULL,
 CONSTRAINT [PK_Fornecedores_tel] PRIMARY KEY CLUSTERED 
(
	[idTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Desafio_Bludata] SET  READ_WRITE 
GO
