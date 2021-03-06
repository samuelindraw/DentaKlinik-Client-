USE [master]
GO
/****** Object:  Database [testdb]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE DATABASE [testdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\testdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'testdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\testdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [testdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [testdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [testdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [testdb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [testdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [testdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testdb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [testdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [testdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [testdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [testdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testdb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [testdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [testdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [testdb] SET  MULTI_USER 
GO
ALTER DATABASE [testdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [testdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [testdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [testdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [testdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [testdb] SET QUERY_STORE = OFF
GO
USE [testdb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barang](
	[IdBarang] [int] IDENTITY(1,1) NOT NULL,
	[NamaBarang] [nvarchar](max) NULL,
	[Harga] [int] NOT NULL,
	[Stok] [smallint] NOT NULL,
	[IdKatBarang] [int] NOT NULL,
	[Keterangan] [nvarchar](max) NULL,
	[Minstok] [int] NOT NULL,
	[KatBarangIdKategori] [int] NOT NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[IdBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Beli]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beli](
	[IdBeli] [int] IDENTITY(1,1) NOT NULL,
	[Tanggal] [datetime2](7) NOT NULL,
	[NamaPembelian] [nvarchar](max) NULL,
	[Keterangan] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
	[TotalHarga] [int] NOT NULL,
 CONSTRAINT [PK_Beli] PRIMARY KEY CLUSTERED 
(
	[IdBeli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailBeli]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailBeli](
	[DetailBeliId] [nvarchar](450) NOT NULL,
	[IdBeli] [int] NOT NULL,
	[Tanggal] [datetime2](7) NOT NULL,
	[IdBarang] [int] NOT NULL,
	[Qty] [smallint] NOT NULL,
	[Harga] [int] NOT NULL,
	[TotalHarga] [int] NOT NULL,
 CONSTRAINT [PK_DetailBeli] PRIMARY KEY CLUSTERED 
(
	[DetailBeliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailPasien]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPasien](
	[DetailPasienID] [int] IDENTITY(1,1) NOT NULL,
	[Registrasi] [datetime2](7) NOT NULL,
	[RwPenyakit] [nvarchar](max) NULL,
	[Username] [nvarchar](450) NULL,
	[IdPasien] [nvarchar](max) NULL,
 CONSTRAINT [PK_DetailPasien] PRIMARY KEY CLUSTERED 
(
	[DetailPasienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailPegawai]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPegawai](
	[DetailPegawaiID] [int] IDENTITY(1,1) NOT NULL,
	[Jabatan] [nvarchar](max) NULL,
	[Gaji] [int] NOT NULL,
	[TanggalJoin] [datetime2](7) NOT NULL,
	[Username] [nvarchar](450) NULL,
 CONSTRAINT [PK_DetailPegawai] PRIMARY KEY CLUSTERED 
(
	[DetailPegawaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailPenggajian]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPenggajian](
	[IdDetailGaji] [int] IDENTITY(1,1) NOT NULL,
	[IdGaji] [int] NOT NULL,
	[IdTransaksi] [int] NOT NULL,
 CONSTRAINT [PK_DetailPenggajian] PRIMARY KEY CLUSTERED 
(
	[IdDetailGaji] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JenisTindakan]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JenisTindakan](
	[IdJenisTindakan] [int] IDENTITY(1,1) NOT NULL,
	[IdKatJenis] [int] NOT NULL,
	[Jenis] [nvarchar](max) NULL,
	[Biaya] [int] NOT NULL,
	[Keterangan] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
 CONSTRAINT [PK_JenisTindakan] PRIMARY KEY CLUSTERED 
(
	[IdJenisTindakan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jual]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jual](
	[IdJual] [int] IDENTITY(1,1) NOT NULL,
	[IdTransaksi] [int] NOT NULL,
	[TenantID] [nvarchar](450) NULL,
	[Harga] [int] NOT NULL,
	[IdBarang] [int] NOT NULL,
	[Qty] [smallint] NOT NULL,
 CONSTRAINT [PK_Jual] PRIMARY KEY CLUSTERED 
(
	[IdJual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KatBarang]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KatBarang](
	[IdKategori] [int] IDENTITY(1,1) NOT NULL,
	[NamaKategori] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
 CONSTRAINT [PK_KatBarang] PRIMARY KEY CLUSTERED 
(
	[IdKategori] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KatJenis]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KatJenis](
	[IdKatJenis] [int] IDENTITY(1,1) NOT NULL,
	[KategoriName] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
 CONSTRAINT [PK_KatJenis] PRIMARY KEY CLUSTERED 
(
	[IdKatJenis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Penggajian]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Penggajian](
	[IdGaji] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](450) NULL,
	[TanggalGaji] [datetime2](7) NOT NULL,
	[TanggalAwal] [datetime2](7) NULL,
	[TanggalAkhir] [datetime2](7) NULL,
	[TotalGaji] [int] NOT NULL,
	[MasaWaktu] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
	[DetailPegawaiID] [int] NOT NULL,
 CONSTRAINT [PK_Penggajian] PRIMARY KEY CLUSTERED 
(
	[IdGaji] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pengguna]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pengguna](
	[Username] [nvarchar](450) NOT NULL,
	[IdPasien] [nvarchar](max) NULL,
	[Nama] [nvarchar](max) NULL,
	[Gender] [nvarchar](max) NULL,
	[Umur] [smallint] NOT NULL,
	[Alamat] [nvarchar](max) NULL,
	[Kota] [nvarchar](max) NULL,
	[NoTelpon] [nvarchar](max) NULL,
	[NoHP] [nvarchar](max) NULL,
	[rolename] [nvarchar](max) NULL,
	[Prosentase] [float] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
 CONSTRAINT [PK_Pengguna] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pilihGIgi]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pilihGIgi](
	[IdTindakan] [int] NOT NULL,
	[idposisiGigi] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_pilihGIgi] PRIMARY KEY CLUSTERED 
(
	[IdTindakan] ASC,
	[idposisiGigi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PosisiGigi]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PosisiGigi](
	[id] [nvarchar](450) NOT NULL,
	[gigiPosisi] [int] NOT NULL,
	[kuadran] [nvarchar](max) NULL,
 CONSTRAINT [PK_PosisiGigi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prosentase]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prosentase](
	[IdProsentase] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](450) NULL,
	[IdJenisTindakan] [int] NOT NULL,
	[Prosen] [float] NOT NULL,
	[TenantID] [nvarchar](450) NULL,
	[DetailPegawaiID] [int] NULL,
 CONSTRAINT [PK_Prosentase] PRIMARY KEY CLUSTERED 
(
	[IdProsentase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tenant]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenant](
	[TenantID] [nvarchar](450) NOT NULL,
	[TenantName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tenant] PRIMARY KEY CLUSTERED 
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TenantPengguna]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TenantPengguna](
	[TenantPenggunaID] [nvarchar](450) NOT NULL,
	[TenantID] [nvarchar](450) NULL,
	[Username] [nvarchar](450) NULL,
	[StatusTenant] [bit] NOT NULL,
 CONSTRAINT [PK_TenantPengguna] PRIMARY KEY CLUSTERED 
(
	[TenantPenggunaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tindakan]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tindakan](
	[IdTindakan] [int] IDENTITY(1,1) NOT NULL,
	[IdTransaksi] [int] NOT NULL,
	[IdJenisTindakan] [int] NOT NULL,
	[Biaya] [int] NOT NULL,
	[Persenan] [int] NOT NULL,
	[Diagnosis] [nvarchar](max) NULL,
	[BiayaDasar] [int] NOT NULL,
	[Status] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
 CONSTRAINT [PK_Tindakan] PRIMARY KEY CLUSTERED 
(
	[IdTindakan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 12/14/2020 4:39:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[IdTransaksi] [int] IDENTITY(1,1) NOT NULL,
	[IdPasien] [nvarchar](max) NULL,
	[Username] [nvarchar](450) NULL,
	[Tanggal] [datetime2](7) NOT NULL,
	[Anamnesis] [nvarchar](max) NULL,
	[Resep] [nvarchar](max) NULL,
	[TenantID] [nvarchar](450) NULL,
	[DetailPasienID] [int] NOT NULL,
 CONSTRAINT [PK_Transaksi] PRIMARY KEY CLUSTERED 
(
	[IdTransaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200911142415_InitialCreate', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200912045333_InitialMigration', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200914143708_InitialMigration2', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200926140523_dbgigi', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200928042332_fixed', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201005081401_tablejual', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201122182349_Status', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201124141017_Perbaikan database 2', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201124164301_Perbaikan database 3', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201126175616_Perbaikan tab;e Status Tenant', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201213153720_perbaikanbiayakelipatan', N'2.2.3-servicing-35854')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4231fbe4-3509-4423-939a-7b08fffba5c1', N'Pasien', N'PASIEN', N'9ddab17e-2c15-4ab3-b351-df8730e80bf4')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3', N'Dokter', N'DOKTER', N'4d03ab75-f875-4c56-a35e-9e62481899b1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'a28c0dd5-8eba-4b91-8aa8-f208fbb951cc', N'Admin', N'ADMIN', N'b207fdf8-386e-4be0-baa7-923858ac3678')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e4dcbeca-c140-4672-9077-05f76adaed02', N'Perawat', N'PERAWAT', N'13df37ed-7518-4d04-9b8b-b16120ec56fb')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2db14c47-8518-4d56-ae7f-9f67686cc2c4', N'4231fbe4-3509-4423-939a-7b08fffba5c1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d29abdf-03dd-4d12-a064-96c9ec8c777a', N'4231fbe4-3509-4423-939a-7b08fffba5c1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1a43619d-1a03-4bf2-8531-f762309b9270', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7533814a-6601-4bc3-8940-c3d4a6b2d93d', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f51bc46-ea98-4411-a8b3-6be9ba33cbeb', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a6abe9f2-bc0a-4f4c-b67c-f0c5866934b9', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'de0753cb-8a98-463a-99aa-09e966cdac31', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f006ee6c-ccf5-4104-8c89-74bedf429fee', N'9e0408d2-e9a7-4ae6-a6c2-da755dc610a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ef58f36-5cbb-4f1c-8aef-cc7b68978b09', N'a28c0dd5-8eba-4b91-8aa8-f208fbb951cc')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0a65e250-9cd5-48ef-8e04-2f0ea2241dc3', N'e4dcbeca-c140-4672-9077-05f76adaed02')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'0a65e250-9cd5-48ef-8e04-2f0ea2241dc3', N'perawattenant1', N'PERAWATTENANT1', N'perawat@gmail.com', N'PERAWAT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHyNakteUly9r+GTnrmYwfCtqgm91WjDm1Lvwa1R6vByUZJ38W1C/cT+o/4fx7bWPw==', N'FMKCXZUASZWESV4LOHE6BU2WZCGNN5SS', N'05cd23e0-7562-494f-9c39-2bbe73cfb524', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'1a43619d-1a03-4bf2-8531-f762309b9270', N'Pakkaton', N'PAKKATON', N'katony@staff.ukdw.ac.id', N'KATONY@STAFF.UKDW.AC.ID', 0, N'AQAAAAEAACcQAAAAELogv3rbb+IRaTrbsQeiqr5PN5juyjOJ0ijKYDfjqLgdc5xYzp0AfHvVHPUQBW9d7w==', N'SBSA3TUW6K6ELHUDFPIMJC3C5RPAUZRI', N'52b543ee-3f6e-474b-8fa0-f456bbfc8cf5', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'2db14c47-8518-4d56-ae7f-9f67686cc2c4', N'ClarissaWijaya', N'CLARISSAWIJAYA', N'clarisapp21@gmail.com', N'CLARISAPP21@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELsBHAGrAVB7aGJwDyQ++t91PS9BihQZFhMXk0LfFAnDcyI+HdTlnWXYNnW3BvRz/Q==', N'NNTAOK2FCCACP32DNQZEKTCVIYLAIGY6', N'041c6af3-3216-477f-88a7-c2c911d453d9', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'5d29abdf-03dd-4d12-a064-96c9ec8c777a', N'pasientenant2', N'PASIENTENANT2', N'pasientenant2@mail.com', N'PASIENTENANT2@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEDrAxnl62gM4sFOtDv4wdL5hkkkHrI99S/w9GhVMm/9J6bVx35WFL/CbysFgd2DvbQ==', N'SKY3OKQ2NX3JNE5MHIQQBRMMU7LB2J5A', N'77234b75-3dfa-4892-8af4-b323ee48831e', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'7533814a-6601-4bc3-8940-c3d4a6b2d93d', N'doktertenant2', N'DOKTERTENANT2', N'dokter2@gmail.com', N'DOKTER2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIpaU1rexMp4PkwNy0f9IOn0YX6tKmQ4m5Kdqb72kInSxQEQ+T5sO1yeivQHA39Jrw==', N'WDONZXQG6KSNNQ2B35SAFENAVX44744C', N'3dd7cc33-efc8-45e1-bec6-92f3ba964ded', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'8f51bc46-ea98-4411-a8b3-6be9ba33cbeb', N'kezia', N'KEZIA', N'samuelwjaya75@gmail.com', N'SAMUELWJAYA75@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKA9c6OrR/rtTNAiC1FK/yYDgfrnihyQru8QbE2jhxaQEdis+MFtVyORdfZeZCJfCA==', N'HAINNRRZBSNUGXONA2D33PUG5E7O4CPD', N'cf6253ac-b055-42a9-b747-fc131705b8b4', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'9ef58f36-5cbb-4f1c-8aef-cc7b68978b09', N'Pakargo', N'PAKARGO', N'argowibowo@staff.ukdw.ac.id', N'ARGOWIBOWO@STAFF.UKDW.AC.ID', 0, N'AQAAAAEAACcQAAAAEKg6k07iifeFdV7bONTg+AOMI8htLzeIPQe2QgWlESK7fVxt5LOikl0E0Y8PIvo49w==', N'JDBP5BBX6CGKLOKS47M4OX3DQIS5C6UL', N'd4ce805c-7cb3-444e-b633-39fd0253684d', NULL, 0, 0, NULL, 1, 0, 1, 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'a6abe9f2-bc0a-4f4c-b67c-f0c5866934b9', N'testprosentasedoktertenan2', N'TESTPROSENTASEDOKTERTENAN2', N'testprosentasedoktertenan2@mail.com', N'TESTPROSENTASEDOKTERTENAN2@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEA/buZ9etQcxND97jYmAGpmZg+sE4S3zig7YBFEiIiRuN6a/iW6X68UzGPy2C+TrBA==', N'DKAMHKYEXPCD5CPGO2TUNZZOEVQF5LIO', N'b73c96fd-6168-4de2-8879-b98603d03e52', NULL, 0, 0, NULL, 1, 0, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'de0753cb-8a98-463a-99aa-09e966cdac31', N'drwihan', N'DRWIHAN', N'drwihan@gmail.com', N'DRWIHAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEDejiG6YguuguDPpGn9uXfNXwm+T3wD73wv2pO9WUzdKZ/7JqFBseXDNyNvnGlvytQ==', N'2UZMGGBQQHJEX6BHZZLEXSXKHPVDKDHQ', N'573df735-5903-4d2a-a3cf-44c836b6b7c8', NULL, 0, 0, NULL, 1, 0, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsEnabled], [Status]) VALUES (N'f006ee6c-ccf5-4104-8c89-74bedf429fee', N'samuelindraw', N'SAMUELINDRAW', N'samuel.indra@si.ukdw.ac.id', N'SAMUEL.INDRA@SI.UKDW.AC.ID', 0, N'AQAAAAEAACcQAAAAEEOzoRU7N+GcH5O2fwd3f4bYGc5lJXF/OiVBC76NhL3pBLrhVvftT8emckehV+nBfg==', N'YTFS6X5GLXDBTTO2OZWZFNUE27Z3HL26', N'421308e2-97a3-42f4-9c74-67ba590711c0', NULL, 0, 0, NULL, 1, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[Barang] ON 

INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (20, N'Estrofem 1mg', 40000, 30, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (21, N'Estrofem Forte 28', 50000, 30, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (22, N'Norditropin Nordilet 5mg', 25000, 29, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (23, N'Niladacin 150mg', 3000, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (24, N'Neuralgin RX', 1000, 0, 2, N'test', 100, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (25, N'Lanamol Parasetamol', 1000, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (26, N'Nilaren 50-diclofenac sodium 50mg', 1500, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (27, N'Biolincom(Lincomycin syrup)', 52000, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (28, N'Dansera', 2500, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (29, N'Alphamol syrup', 5800, 0, 2, NULL, 30, 2)
INSERT [dbo].[Barang] ([IdBarang], [NamaBarang], [Harga], [Stok], [IdKatBarang], [Keterangan], [Minstok], [KatBarangIdKategori]) VALUES (30, N'Fenatic Ibuprofen 60ml', 15400, 0, 2, NULL, 30, 2)
SET IDENTITY_INSERT [dbo].[Barang] OFF
SET IDENTITY_INSERT [dbo].[Beli] ON 

INSERT [dbo].[Beli] ([IdBeli], [Tanggal], [NamaPembelian], [Keterangan], [TenantID], [TotalHarga]) VALUES (11, CAST(N'2020-12-13T00:00:00.0000000' AS DateTime2), N'Status obat awal', N'test', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 0)
SET IDENTITY_INSERT [dbo].[Beli] OFF
INSERT [dbo].[DetailBeli] ([DetailBeliId], [IdBeli], [Tanggal], [IdBarang], [Qty], [Harga], [TotalHarga]) VALUES (N'88462fc7-c0a0-49c5-9a60-481621b4efa1', 11, CAST(N'2020-12-13T00:00:00.0000000' AS DateTime2), 21, 30, 50000, 1500000)
INSERT [dbo].[DetailBeli] ([DetailBeliId], [IdBeli], [Tanggal], [IdBarang], [Qty], [Harga], [TotalHarga]) VALUES (N'd132f2a1-78eb-49ee-abc4-b5c66c02a315', 11, CAST(N'2020-12-13T00:00:00.0000000' AS DateTime2), 22, 30, 25000, 750000)
INSERT [dbo].[DetailBeli] ([DetailBeliId], [IdBeli], [Tanggal], [IdBarang], [Qty], [Harga], [TotalHarga]) VALUES (N'db3905d0-771b-4c65-8fbc-c82a279a29cf', 11, CAST(N'2020-12-13T00:00:00.0000000' AS DateTime2), 20, 30, 40000, 1200000)
SET IDENTITY_INSERT [dbo].[DetailPasien] ON 

INSERT [dbo].[DetailPasien] ([DetailPasienID], [Registrasi], [RwPenyakit], [Username], [IdPasien]) VALUES (1019, CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), N'Maag', N'ClarissaWijaya', N'PasienClarissaWijaya')
INSERT [dbo].[DetailPasien] ([DetailPasienID], [Registrasi], [RwPenyakit], [Username], [IdPasien]) VALUES (1020, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Gigi patah', N'pasientenant2', N'Pasienpasientenant2')
SET IDENTITY_INSERT [dbo].[DetailPasien] OFF
SET IDENTITY_INSERT [dbo].[DetailPegawai] ON 

INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1, N'Admin', 0, CAST(N'2020-09-12T00:00:00.0000000' AS DateTime2), N'Pakargo')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (2, N'Dokter', 36000, CAST(N'2020-08-01T00:00:00.0000000' AS DateTime2), N'kezia')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1003, N'Dokter', 0, CAST(N'2020-09-17T00:00:00.0000000' AS DateTime2), N'Pakkaton')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1015, N'Dokter', 0, CAST(N'2020-11-19T00:00:00.0000000' AS DateTime2), N'drwihan')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1016, N'Dokter', 0, CAST(N'2020-11-21T00:00:00.0000000' AS DateTime2), N'samuelindraw')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1021, N'Dokter', 36000, CAST(N'2020-11-27T00:00:00.0000000' AS DateTime2), N'doktertenant2')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1023, N'Perawat', 2000000, CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), N'perawattenant1')
INSERT [dbo].[DetailPegawai] ([DetailPegawaiID], [Jabatan], [Gaji], [TanggalJoin], [Username]) VALUES (1024, N'Dokter', 0, CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), N'testprosentasedoktertenan2')
SET IDENTITY_INSERT [dbo].[DetailPegawai] OFF
SET IDENTITY_INSERT [dbo].[DetailPenggajian] ON 

INSERT [dbo].[DetailPenggajian] ([IdDetailGaji], [IdGaji], [IdTransaksi]) VALUES (154, 57, 1217)
SET IDENTITY_INSERT [dbo].[DetailPenggajian] OFF
SET IDENTITY_INSERT [dbo].[JenisTindakan] ON 

INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (14, 1004, N'Trepanasi Kecil', 0, N'Perawatan Saluran Akar/Endodontik', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (15, 1004, N'Trepanasi Sedang', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (16, 1004, N'Trepanasi Besar', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (17, 1, N'Pencetakan Gigi', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (18, 2, N'jacket porcelain', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (19, 2, N'jacket akrilik', 300000, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (20, 2, N'Capping', 50000, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (21, 1005, N'Pencabutan Sedang', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (22, 1005, N'Pencabutan Besar', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (23, 1006, N'Pencabutan Kecil', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (24, 1006, N'Pencabutan Sedang', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (25, 1006, N'Pencabutan Besar	', 0, NULL, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (26, 1003, N'Pencetakan Jaket', 0, NULL, N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[JenisTindakan] ([IdJenisTindakan], [IdKatJenis], [Jenis], [Biaya], [Keterangan], [TenantID]) VALUES (27, 1002, N'Pencetakan Gigi', 0, NULL, N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
SET IDENTITY_INSERT [dbo].[JenisTindakan] OFF
SET IDENTITY_INSERT [dbo].[Jual] ON 

INSERT [dbo].[Jual] ([IdJual], [IdTransaksi], [TenantID], [Harga], [IdBarang], [Qty]) VALUES (1105, 1217, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 25000, 22, 1)
SET IDENTITY_INSERT [dbo].[Jual] OFF
SET IDENTITY_INSERT [dbo].[KatBarang] ON 

INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (1, N'Barang', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (2, N'Obat', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (1002, N'Obat', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (1003, N'Barang', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (1004, N'peralatan', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[KatBarang] ([IdKategori], [NamaKategori], [TenantID]) VALUES (1019, N'Gigi Palsu', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
SET IDENTITY_INSERT [dbo].[KatBarang] OFF
SET IDENTITY_INSERT [dbo].[KatJenis] ON 

INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1, N'Prothesa', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (2, N'Konservasi', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1002, N'Prothesa', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1003, N'Konservasi', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1004, N'Perawatan Saluran Akar/Endodontik', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1005, N'Pencabutan/Exodontie Dewasa', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1006, N'Pencabutan/Exodontie Anak', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[KatJenis] ([IdKatJenis], [KategoriName], [TenantID]) VALUES (1007, N'Kategori umum', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
SET IDENTITY_INSERT [dbo].[KatJenis] OFF
SET IDENTITY_INSERT [dbo].[Penggajian] ON 

INSERT [dbo].[Penggajian] ([IdGaji], [Username], [TanggalGaji], [TanggalAwal], [TanggalAkhir], [TotalGaji], [MasaWaktu], [TenantID], [DetailPegawaiID]) VALUES (57, N'kezia', CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), CAST(N'2020-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), 36000, N'13', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
SET IDENTITY_INSERT [dbo].[Penggajian] OFF
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'ClarissaWijaya', N'PasienClarissaWijaya', N'Clarissa Punipun', N'Female', 26, N'Jl. Jend. Sudirman, RT.1/RW.3, Gelora, Kecamatan Tanah Abang, Kota Jakarta Pusat, Daerah Khusus Ibukota Jakarta 10270', N'Jakarta', N'02914428311', N'085878042160', N'Pasien', 0, N'clarisapp21@gmail.com', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'doktertenant2', NULL, N'dokter tenant 2', NULL, 43, NULL, N'Yogyakarta', N'3131', N'1121', N'Dokter', 30, N'dokter2@gmail.com', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'drwihan', NULL, N'Wihan', N'Male', 35, N'terban kulon', N'Yogyakarta', N'0291239193', N'087441224556', N'Dokter', 70, N'drwihan@gmail.com', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'kezia', NULL, N'kezia andrea', N'Female', 25, N'Jalan zeni pelajar gkmi jogja 1234', N'Klaten', N'0291441938', N'085877421160', N'Dokter', 60, N'samuelwjaya75@gmail.com', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'Pakargo', NULL, N'argo wibowo', N'Male', 35, N'x', N'Yogyakarta', N'081677421160', N'0291431160', N'Admin', 0, N'argowibowo@staff.ukdw.ac.id', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'Pakkaton', NULL, N'Pak Katon', N'Male', 35, N'UKDW', N'Yogyakarta', N'085877421160', N'0291431160', N'Dokter', 40, N'katony@staff.ukdw.ac.id', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'pasientenant2', N'Pasienpasientenant2', N'pasientenant2', NULL, 20, NULL, N'Yogyakarta', N'13213', N'2323', N'Pasien', 0, N'pasientenant2@mail.com', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'perawattenant1', NULL, N'perawat1', N'Female', 23, NULL, N'Yogyakarta', N'0291442144', N'0892221833453', N'Perawat', 0, N'perawat@gmail.com', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'samuelindraw', NULL, N'samuel indra wijaya', NULL, 23, NULL, N'Kudus', N'0291441938', N'085878042160', N'Dokter', 40, N'samuel.indra@si.ukdw.ac.id', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[Pengguna] ([Username], [IdPasien], [Nama], [Gender], [Umur], [Alamat], [Kota], [NoTelpon], [NoHP], [rolename], [Prosentase], [Email], [TenantID]) VALUES (N'testprosentasedoktertenan2', NULL, N'test', NULL, 11, NULL, N'Yogyakarta', N'231231', N'323131', N'Dokter', 21, N'testprosentasedoktertenan2@mail.com', N'9aef0241-8efe-4ede-8186-5b73b5448cb8')
INSERT [dbo].[pilihGIgi] ([IdTindakan], [idposisiGigi]) VALUES (1109, N'0ac76f7a-324b-4ecf-995c-768f22632c7a')
INSERT [dbo].[pilihGIgi] ([IdTindakan], [idposisiGigi]) VALUES (1109, N'1d3bd5bc-80ba-413c-8d20-bea67e584cb2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'01da13d8-d557-4ef6-a144-811925f21f08', 5, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'09e598cb-9384-4f68-9ef9-b577f83943b4', 4, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'0ac76f7a-324b-4ecf-995c-768f22632c7a', 1, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'0e654ab2-7134-4c82-a0c6-0a621e39dc85', 2, N'IV')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'1c261034-6b2d-40b8-9adf-4c1b889a60f5', 3, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'1d3bd5bc-80ba-413c-8d20-bea67e584cb2', 2, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'2f9ebb88-55b1-40a6-a047-b7f947739076', 2, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'38757bc2-d653-4928-924f-ab1f3bf4ef41', 6, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'4419064a-9b6f-41cc-b62d-9ce7241feb09', 3, N'II')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'4da2f523-18e3-41be-a06d-aba1d0ad5d41', 7, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'4f081c1e-4254-4951-bbe1-785141cc9cf8', 7, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'4fa63c43-cafe-4ffe-9ce0-356660bca4d7', 1, N'II')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'537cd549-3bb7-41fd-ba28-13a9b5300256', 3, N'III')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'5773da76-c627-4e7d-9c98-d384f20d5cba', 2, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'5c91cf08-d839-4061-9669-75445ca7e244', 8, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'5e9bbc81-3d35-45ee-aa9a-b585a63d9b11', 1, N'III')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'714db95e-44c4-4a7f-8ad0-ef35f9238504', 3, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'7185e911-e8b1-47d4-b8bc-fbe21c1c5f81', 3, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'74ee30cc-be3d-4829-9183-d505cc96e2f7', 5, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'7f8846e1-11e8-4262-a20c-d693112374b8', 4, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'80c16425-42cf-4eb5-9f75-ecd47ffaf7b9', 3, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'80e10010-9e7d-489f-b683-ed26afc8b466', 2, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'89d80e45-6332-44cb-9be1-59ead79eed61', 6, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'8f524cec-4851-4174-aafd-0a27c443e025', 1, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'90cdb2a9-7cf3-4137-a564-5cca10f83f37', 5, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'942ab306-f971-493b-b801-41a5d4c047ce', 7, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'99436909-b129-498b-bec2-c89cac6cd53d', 3, N'I')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'9a758d6e-f427-43ca-95c8-508282c3a16a', 6, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'9b5d9b15-7b39-49c3-93e5-7eedbd9cf528', 3, N'IV')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'ae3ba043-71ec-4565-842a-2ae686d2690a', 5, N'IV')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'b0a89b91-657d-4a5e-9f38-b4fbc3fd9e3a', 8, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'b3544737-ecf7-41b2-80cc-8387d2516bb5', 5, N'II')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'b386d410-5663-425a-b528-303b09a7b9ba', 4, N'III')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'b526a272-2d4b-4e9f-8a55-c145fea43720', 4, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'b7681db1-1e4f-469b-bee7-07b4d74b39b2', 8, N'3')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'bc9cc51f-daba-4541-9a0d-8bc38cc8d5e3', 4, N'I')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'bf18b7fa-adcf-4243-a5c3-dad0dd949274', 2, N'I')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'bf6c2b0f-801a-4169-9640-8cdde21d2576', 5, N'III')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'c111d171-ef51-4fda-8296-32c7d4d61718', 5, N'I')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'c1fa97ab-b216-4833-9145-54e153406508', 7, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'c6f2d56b-5d65-4ecb-8470-adc636aefd9c', 4, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'ce009feb-cdcc-4e0c-be26-9dbae6d8999a', 8, N'1')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'cfd8a1e1-ffa6-4626-b104-1d2c65c8031a', 1, N'IV')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'd41a1228-0a80-4d7f-a8e5-996e779d6d1b', 2, N'III')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'd75b7425-fb48-4c6e-adcd-287fc3403b4f', 4, N'IV')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'db7a144e-ac83-4af2-ad2b-2fdd0364b8a2', 2, N'II')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'dcf2b36b-349b-4df8-9db7-0591a1939893', 1, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'e4895c9b-839c-4cab-9f9a-38234c4e76db', 4, N'II')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'e57f986f-004f-4a58-b0a0-3e11ecfd390c', 1, N'4')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'ee516c03-4ed0-47a9-964a-4b9bd78aa54c', 6, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'f413ee8e-5cb5-4316-b6ec-dc419987577e', 5, N'2')
INSERT [dbo].[PosisiGigi] ([id], [gigiPosisi], [kuadran]) VALUES (N'f781f984-cb09-4106-a6de-e5dd5b6a4649', 1, N'I')
SET IDENTITY_INSERT [dbo].[Prosentase] ON 

INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (71, N'drwihan', 14, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (72, N'kezia', 14, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (73, N'Pakkaton', 14, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (74, N'samuelindraw', 14, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (75, N'drwihan', 15, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (76, N'kezia', 15, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (77, N'Pakkaton', 15, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (78, N'samuelindraw', 15, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (79, N'drwihan', 16, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (80, N'kezia', 16, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (81, N'Pakkaton', 16, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (82, N'samuelindraw', 16, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (83, N'drwihan', 17, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (84, N'kezia', 17, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (85, N'Pakkaton', 17, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (86, N'samuelindraw', 17, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (87, N'drwihan', 18, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (88, N'kezia', 18, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (89, N'Pakkaton', 18, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (90, N'samuelindraw', 18, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (91, N'drwihan', 19, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (92, N'kezia', 19, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (93, N'Pakkaton', 19, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (94, N'samuelindraw', 19, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (95, N'drwihan', 20, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (96, N'kezia', 20, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (97, N'Pakkaton', 20, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (98, N'samuelindraw', 20, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (99, N'drwihan', 21, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (100, N'kezia', 21, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (101, N'Pakkaton', 21, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (102, N'samuelindraw', 21, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (103, N'drwihan', 22, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (104, N'kezia', 22, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (105, N'Pakkaton', 22, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (106, N'samuelindraw', 22, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (107, N'drwihan', 23, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (108, N'kezia', 23, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (109, N'Pakkaton', 23, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (110, N'samuelindraw', 23, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (111, N'drwihan', 24, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (112, N'kezia', 24, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (113, N'Pakkaton', 24, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (114, N'samuelindraw', 24, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (115, N'drwihan', 25, 70, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (116, N'kezia', 25, 60, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (117, N'Pakkaton', 25, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (118, N'samuelindraw', 25, 40, N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (119, N'doktertenant2', 26, 30, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1021)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (120, N'drwihan', 26, 70, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (121, N'kezia', 26, 60, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (122, N'Pakkaton', 26, 40, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (123, N'samuelindraw', 26, 40, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (124, N'doktertenant2', 27, 30, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1021)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (125, N'drwihan', 27, 70, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1015)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (126, N'kezia', 27, 60, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 2)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (127, N'Pakkaton', 27, 40, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1003)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (128, N'samuelindraw', 27, 40, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1016)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (129, N'testprosentasedoktertenan2', 26, 21, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1024)
INSERT [dbo].[Prosentase] ([IdProsentase], [Username], [IdJenisTindakan], [Prosen], [TenantID], [DetailPegawaiID]) VALUES (130, N'testprosentasedoktertenan2', 27, 21, N'9aef0241-8efe-4ede-8186-5b73b5448cb8', 1024)
SET IDENTITY_INSERT [dbo].[Prosentase] OFF
INSERT [dbo].[Tenant] ([TenantID], [TenantName]) VALUES (N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'klinik2')
INSERT [dbo].[Tenant] ([TenantID], [TenantName]) VALUES (N'b8e5f847-b999-4e3e-9a91-027bec086cf0', N'Klinik UKDW')
INSERT [dbo].[Tenant] ([TenantID], [TenantName]) VALUES (N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'Klinik Gigi Dr Wihan')
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'0f3564f5-c73a-42a1-bde6-4629cb13c9f8', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'pasientenant2', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'1d96f91f-3c93-4136-bb5b-282bf68a220e', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'doktertenant2', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'2c238530-5bb6-4469-9084-7f6141432d6b', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'perawattenant1', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'51c7917e-5633-47b0-a2a7-df112508632e', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'samuelindraw', 0)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'58f20559-29ee-4721-8ed8-818f14173d7c', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'Pakargo', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'5fc6c131-d345-4548-a715-4d37fef08241', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'Pakkaton', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'5fe0bed9-c5fb-4cd4-93a2-a0009bdda4a3', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'Pakkaton', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'67b750d4-653b-46c9-95d3-eccc73c24484', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'kezia', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'688af7a6-7703-4f02-966d-80e47608d7b7', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'drwihan', 0)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'77a21ec5-5434-4cf8-9d87-c0f5139fd15a', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'drwihan', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'78f6b62d-c886-4d5f-969f-75d0b31a632a', N'b8e5f847-b999-4e3e-9a91-027bec086cf0', N'Pakargo', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'948a4da3-8b72-4fe7-b8f8-77752beb1883', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'samuelindraw', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'bc910cd4-2863-4bb5-8aae-eff103f04aa2', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'Pakargo', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'c7e28740-171a-4110-9e98-52e4e099c595', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'kezia', 1)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'd1cf358c-08b2-415c-8e28-895ce112451d', N'9aef0241-8efe-4ede-8186-5b73b5448cb8', N'testprosentasedoktertenan2', 0)
INSERT [dbo].[TenantPengguna] ([TenantPenggunaID], [TenantID], [Username], [StatusTenant]) VALUES (N'd74e6f1e-67ed-4102-a133-ff1f949e0af2', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', N'ClarissaWijaya', 1)
SET IDENTITY_INSERT [dbo].[Tindakan] ON 

INSERT [dbo].[Tindakan] ([IdTindakan], [IdTransaksi], [IdJenisTindakan], [Biaya], [Persenan], [Diagnosis], [BiayaDasar], [Status], [TenantID]) VALUES (1109, 1217, 16, 60000, 60, N'Trepanasi besar harus dilakukan mengingat kondisi gigi pasien sudah diambang batas, akan di sesuaikan', 30000, N'Selesai', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e')
SET IDENTITY_INSERT [dbo].[Tindakan] OFF
SET IDENTITY_INSERT [dbo].[Transaksi] ON 

INSERT [dbo].[Transaksi] ([IdTransaksi], [IdPasien], [Username], [Tanggal], [Anamnesis], [Resep], [TenantID], [DetailPasienID]) VALUES (1217, N'PasienClarissaWijaya', N'kezia', CAST(N'2020-12-14T00:00:00.0000000' AS DateTime2), N'Anamnesis merupakan percakapan profesional terencana antara dokter dan pasien dalam rangka menyusun riwayat penyakit. ', N'Anamnesis merupakan percakapan profesional terencana antara dokter dan pasien dalam rangka menyusun riwayat penyakit. ', N'edbb2900-67c9-4c17-8c35-cd8e583cb93e', 1019)
SET IDENTITY_INSERT [dbo].[Transaksi] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Barang_KatBarangIdKategori]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Barang_KatBarangIdKategori] ON [dbo].[Barang]
(
	[KatBarangIdKategori] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Beli_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Beli_TenantID] ON [dbo].[Beli]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailBeli_IdBarang]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_DetailBeli_IdBarang] ON [dbo].[DetailBeli]
(
	[IdBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DetailPasien_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DetailPasien_Username] ON [dbo].[DetailPasien]
(
	[Username] ASC
)
WHERE ([Username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DetailPegawai_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DetailPegawai_Username] ON [dbo].[DetailPegawai]
(
	[Username] ASC
)
WHERE ([Username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailPenggajian_IdGaji]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_DetailPenggajian_IdGaji] ON [dbo].[DetailPenggajian]
(
	[IdGaji] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailPenggajian_IdTransaksi]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_DetailPenggajian_IdTransaksi] ON [dbo].[DetailPenggajian]
(
	[IdTransaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_JenisTindakan_IdKatJenis]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_JenisTindakan_IdKatJenis] ON [dbo].[JenisTindakan]
(
	[IdKatJenis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_JenisTindakan_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_JenisTindakan_TenantID] ON [dbo].[JenisTindakan]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jual_IdBarang]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Jual_IdBarang] ON [dbo].[Jual]
(
	[IdBarang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jual_IdTransaksi]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Jual_IdTransaksi] ON [dbo].[Jual]
(
	[IdTransaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Jual_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Jual_TenantID] ON [dbo].[Jual]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_KatBarang_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_KatBarang_TenantID] ON [dbo].[KatBarang]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_KatJenis_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_KatJenis_TenantID] ON [dbo].[KatJenis]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Penggajian_DetailPegawaiID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Penggajian_DetailPegawaiID] ON [dbo].[Penggajian]
(
	[DetailPegawaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Penggajian_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Penggajian_TenantID] ON [dbo].[Penggajian]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Penggajian_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Penggajian_Username] ON [dbo].[Penggajian]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Pengguna_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Pengguna_TenantID] ON [dbo].[Pengguna]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_pilihGIgi_idposisiGigi]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_pilihGIgi_idposisiGigi] ON [dbo].[pilihGIgi]
(
	[idposisiGigi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Prosentase_DetailPegawaiID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Prosentase_DetailPegawaiID] ON [dbo].[Prosentase]
(
	[DetailPegawaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Prosentase_IdJenisTindakan]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Prosentase_IdJenisTindakan] ON [dbo].[Prosentase]
(
	[IdJenisTindakan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Prosentase_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Prosentase_TenantID] ON [dbo].[Prosentase]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Prosentase_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Prosentase_Username] ON [dbo].[Prosentase]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TenantPengguna_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_TenantPengguna_TenantID] ON [dbo].[TenantPengguna]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TenantPengguna_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_TenantPengguna_Username] ON [dbo].[TenantPengguna]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tindakan_IdJenisTindakan]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tindakan_IdJenisTindakan] ON [dbo].[Tindakan]
(
	[IdJenisTindakan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tindakan_IdTransaksi]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tindakan_IdTransaksi] ON [dbo].[Tindakan]
(
	[IdTransaksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tindakan_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tindakan_TenantID] ON [dbo].[Tindakan]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transaksi_DetailPasienID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Transaksi_DetailPasienID] ON [dbo].[Transaksi]
(
	[DetailPasienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Transaksi_TenantID]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Transaksi_TenantID] ON [dbo].[Transaksi]
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Transaksi_Username]    Script Date: 12/14/2020 4:39:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Transaksi_Username] ON [dbo].[Transaksi]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Jual] ADD  DEFAULT ((0)) FOR [Harga]
GO
ALTER TABLE [dbo].[Jual] ADD  DEFAULT ((0)) FOR [IdBarang]
GO
ALTER TABLE [dbo].[Jual] ADD  DEFAULT (CONVERT([smallint],(0))) FOR [Qty]
GO
ALTER TABLE [dbo].[TenantPengguna] ADD  DEFAULT ((0)) FOR [StatusTenant]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Barang]  WITH CHECK ADD  CONSTRAINT [FK_Barang_KatBarang_KatBarangIdKategori] FOREIGN KEY([KatBarangIdKategori])
REFERENCES [dbo].[KatBarang] ([IdKategori])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Barang] CHECK CONSTRAINT [FK_Barang_KatBarang_KatBarangIdKategori]
GO
ALTER TABLE [dbo].[Beli]  WITH CHECK ADD  CONSTRAINT [FK_Beli_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Beli] CHECK CONSTRAINT [FK_Beli_Tenant_TenantID]
GO
ALTER TABLE [dbo].[DetailBeli]  WITH CHECK ADD  CONSTRAINT [FK_DetailBeli_Barang_IdBarang] FOREIGN KEY([IdBarang])
REFERENCES [dbo].[Barang] ([IdBarang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailBeli] CHECK CONSTRAINT [FK_DetailBeli_Barang_IdBarang]
GO
ALTER TABLE [dbo].[DetailBeli]  WITH CHECK ADD  CONSTRAINT [FK_DetailBeli_Beli_IdBeli] FOREIGN KEY([IdBeli])
REFERENCES [dbo].[Beli] ([IdBeli])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailBeli] CHECK CONSTRAINT [FK_DetailBeli_Beli_IdBeli]
GO
ALTER TABLE [dbo].[DetailPasien]  WITH CHECK ADD  CONSTRAINT [FK_DetailPasien_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[DetailPasien] CHECK CONSTRAINT [FK_DetailPasien_Pengguna_Username]
GO
ALTER TABLE [dbo].[DetailPegawai]  WITH CHECK ADD  CONSTRAINT [FK_DetailPegawai_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[DetailPegawai] CHECK CONSTRAINT [FK_DetailPegawai_Pengguna_Username]
GO
ALTER TABLE [dbo].[DetailPenggajian]  WITH CHECK ADD  CONSTRAINT [FK_DetailPenggajian_Penggajian_IdGaji] FOREIGN KEY([IdGaji])
REFERENCES [dbo].[Penggajian] ([IdGaji])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailPenggajian] CHECK CONSTRAINT [FK_DetailPenggajian_Penggajian_IdGaji]
GO
ALTER TABLE [dbo].[DetailPenggajian]  WITH CHECK ADD  CONSTRAINT [FK_DetailPenggajian_Transaksi_IdTransaksi] FOREIGN KEY([IdTransaksi])
REFERENCES [dbo].[Transaksi] ([IdTransaksi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetailPenggajian] CHECK CONSTRAINT [FK_DetailPenggajian_Transaksi_IdTransaksi]
GO
ALTER TABLE [dbo].[JenisTindakan]  WITH CHECK ADD  CONSTRAINT [FK_JenisTindakan_KatJenis_IdKatJenis] FOREIGN KEY([IdKatJenis])
REFERENCES [dbo].[KatJenis] ([IdKatJenis])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[JenisTindakan] CHECK CONSTRAINT [FK_JenisTindakan_KatJenis_IdKatJenis]
GO
ALTER TABLE [dbo].[JenisTindakan]  WITH CHECK ADD  CONSTRAINT [FK_JenisTindakan_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[JenisTindakan] CHECK CONSTRAINT [FK_JenisTindakan_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Barang_IdBarang] FOREIGN KEY([IdBarang])
REFERENCES [dbo].[Barang] ([IdBarang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Barang_IdBarang]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Jual]  WITH CHECK ADD  CONSTRAINT [FK_Jual_Transaksi_IdTransaksi] FOREIGN KEY([IdTransaksi])
REFERENCES [dbo].[Transaksi] ([IdTransaksi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Jual] CHECK CONSTRAINT [FK_Jual_Transaksi_IdTransaksi]
GO
ALTER TABLE [dbo].[KatBarang]  WITH CHECK ADD  CONSTRAINT [FK_KatBarang_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[KatBarang] CHECK CONSTRAINT [FK_KatBarang_Tenant_TenantID]
GO
ALTER TABLE [dbo].[KatJenis]  WITH CHECK ADD  CONSTRAINT [FK_KatJenis_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[KatJenis] CHECK CONSTRAINT [FK_KatJenis_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Penggajian]  WITH CHECK ADD  CONSTRAINT [FK_Penggajian_DetailPegawai_DetailPegawaiID] FOREIGN KEY([DetailPegawaiID])
REFERENCES [dbo].[DetailPegawai] ([DetailPegawaiID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Penggajian] CHECK CONSTRAINT [FK_Penggajian_DetailPegawai_DetailPegawaiID]
GO
ALTER TABLE [dbo].[Penggajian]  WITH CHECK ADD  CONSTRAINT [FK_Penggajian_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[Penggajian] CHECK CONSTRAINT [FK_Penggajian_Pengguna_Username]
GO
ALTER TABLE [dbo].[Penggajian]  WITH CHECK ADD  CONSTRAINT [FK_Penggajian_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Penggajian] CHECK CONSTRAINT [FK_Penggajian_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Pengguna]  WITH CHECK ADD  CONSTRAINT [FK_Pengguna_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Pengguna] CHECK CONSTRAINT [FK_Pengguna_Tenant_TenantID]
GO
ALTER TABLE [dbo].[pilihGIgi]  WITH CHECK ADD  CONSTRAINT [FK_pilihGIgi_PosisiGigi_idposisiGigi] FOREIGN KEY([idposisiGigi])
REFERENCES [dbo].[PosisiGigi] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pilihGIgi] CHECK CONSTRAINT [FK_pilihGIgi_PosisiGigi_idposisiGigi]
GO
ALTER TABLE [dbo].[pilihGIgi]  WITH CHECK ADD  CONSTRAINT [FK_pilihGIgi_Tindakan_IdTindakan] FOREIGN KEY([IdTindakan])
REFERENCES [dbo].[Tindakan] ([IdTindakan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pilihGIgi] CHECK CONSTRAINT [FK_pilihGIgi_Tindakan_IdTindakan]
GO
ALTER TABLE [dbo].[Prosentase]  WITH CHECK ADD  CONSTRAINT [FK_Prosentase_DetailPegawai_DetailPegawaiID] FOREIGN KEY([DetailPegawaiID])
REFERENCES [dbo].[DetailPegawai] ([DetailPegawaiID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prosentase] CHECK CONSTRAINT [FK_Prosentase_DetailPegawai_DetailPegawaiID]
GO
ALTER TABLE [dbo].[Prosentase]  WITH CHECK ADD  CONSTRAINT [FK_Prosentase_JenisTindakan_IdJenisTindakan] FOREIGN KEY([IdJenisTindakan])
REFERENCES [dbo].[JenisTindakan] ([IdJenisTindakan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prosentase] CHECK CONSTRAINT [FK_Prosentase_JenisTindakan_IdJenisTindakan]
GO
ALTER TABLE [dbo].[Prosentase]  WITH CHECK ADD  CONSTRAINT [FK_Prosentase_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[Prosentase] CHECK CONSTRAINT [FK_Prosentase_Pengguna_Username]
GO
ALTER TABLE [dbo].[Prosentase]  WITH CHECK ADD  CONSTRAINT [FK_Prosentase_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Prosentase] CHECK CONSTRAINT [FK_Prosentase_Tenant_TenantID]
GO
ALTER TABLE [dbo].[TenantPengguna]  WITH CHECK ADD  CONSTRAINT [FK_TenantPengguna_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[TenantPengguna] CHECK CONSTRAINT [FK_TenantPengguna_Pengguna_Username]
GO
ALTER TABLE [dbo].[TenantPengguna]  WITH CHECK ADD  CONSTRAINT [FK_TenantPengguna_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[TenantPengguna] CHECK CONSTRAINT [FK_TenantPengguna_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Tindakan]  WITH CHECK ADD  CONSTRAINT [FK_Tindakan_JenisTindakan_IdJenisTindakan] FOREIGN KEY([IdJenisTindakan])
REFERENCES [dbo].[JenisTindakan] ([IdJenisTindakan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tindakan] CHECK CONSTRAINT [FK_Tindakan_JenisTindakan_IdJenisTindakan]
GO
ALTER TABLE [dbo].[Tindakan]  WITH CHECK ADD  CONSTRAINT [FK_Tindakan_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Tindakan] CHECK CONSTRAINT [FK_Tindakan_Tenant_TenantID]
GO
ALTER TABLE [dbo].[Tindakan]  WITH CHECK ADD  CONSTRAINT [FK_Tindakan_Transaksi_IdTransaksi] FOREIGN KEY([IdTransaksi])
REFERENCES [dbo].[Transaksi] ([IdTransaksi])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tindakan] CHECK CONSTRAINT [FK_Tindakan_Transaksi_IdTransaksi]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_DetailPasien_DetailPasienID] FOREIGN KEY([DetailPasienID])
REFERENCES [dbo].[DetailPasien] ([DetailPasienID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_DetailPasien_DetailPasienID]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_Pengguna_Username] FOREIGN KEY([Username])
REFERENCES [dbo].[Pengguna] ([Username])
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_Pengguna_Username]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_Tenant_TenantID] FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenant] ([TenantID])
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_Tenant_TenantID]
GO
USE [master]
GO
ALTER DATABASE [testdb] SET  READ_WRITE 
GO
