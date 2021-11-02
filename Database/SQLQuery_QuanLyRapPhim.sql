USE [master]
GO
/****** Object:  Database [QuanLyRapPhim]    Script Date: 24/10/2021 20:31:04 ******/
CREATE DATABASE [QuanLyRapPhim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyRapPhim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyRapPhim.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyRapPhim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyRapPhim_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyRapPhim] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyRapPhim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyRapPhim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyRapPhim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyRapPhim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyRapPhim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyRapPhim] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyRapPhim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyRapPhim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyRapPhim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyRapPhim] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyRapPhim] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyRapPhim] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyRapPhim', N'ON'
GO
ALTER DATABASE [QuanLyRapPhim] SET QUERY_STORE = OFF
GO
USE [QuanLyRapPhim]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO
/****** Object:  Table [dbo].[Account]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](100) NOT NULL,
	[Pass] [varchar](1000) NOT NULL,
	[StaffID] [varchar](50) NOT NULL,
	[AccountType] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [varchar](50) NOT NULL,
	[Price] [float] NULL,
	[Date] [datetime] NULL,
	[ClientID] [varchar](50) NULL,
	[ShowtimeID] [varchar](50) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [varchar](50) NULL,
	[SeatID] [varchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[BillDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CinemaRoom]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CinemaRoom](
	[CinemaRoomID] [varchar](50) NOT NULL,
	[CinemaRoomName] [nvarchar](100) NOT NULL,
	[ScreenTypeID] [varchar](50) NULL,
	[SeatRows] [int] NOT NULL,
	[SeatPerRow] [int] NOT NULL,
	[Seats] [int] NOT NULL,
	[CinemaRoomStatus] [int] NOT NULL,
 CONSTRAINT [PK__CinemaRo__6DC62F62C4ACCA66] PRIMARY KEY CLUSTERED 
(
	[CinemaRoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [varchar](50) NOT NULL,
	[ClientName] [nvarchar](100) NOT NULL,
	[Birthday] [date] NOT NULL,
	[ClientAddress] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
	[IDNumber] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [varchar](50) NOT NULL,
	[GenreName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieID] [varchar](50) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Runtime] [float] NOT NULL,
	[PreDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Nation] [nvarchar](50) NOT NULL,
	[Director] [nvarchar](100) NULL,
	[YearProduce] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieClassification]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieClassification](
	[MovieID] [varchar](50) NOT NULL,
	[GenreID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PhanLoaiPhim] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC,
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieFormat]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieFormat](
	[MovieFormatID] [varchar](50) NOT NULL,
	[MovieID] [varchar](50) NOT NULL,
	[ScreenTypeID] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieFormatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieTicket]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieTicket](
	[TicketsID] [int] IDENTITY(1,1) NOT NULL,
	[TicketType] [int] NULL,
	[ShowtimeID] [varchar](50) NULL,
	[SeatID] [varchar](50) NULL,
	[ClientID] [varchar](50) NULL,
	[TicketStatus] [int] NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScreenType]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScreenType](
	[ScreenTypeID] [varchar](50) NOT NULL,
	[ScreenName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ScreenTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Showtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Showtime](
	[ShowtimeID] [varchar](50) NOT NULL,
	[ShowDate] [datetime] NOT NULL,
	[CinemaRoomID] [varchar](50) NOT NULL,
	[MovieFormatID] [varchar](50) NOT NULL,
	[TicketPrice] [float] NOT NULL,
	[ShowtimeStatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ShowtimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [varchar](50) NOT NULL,
	[StaffName] [nvarchar](100) NOT NULL,
	[Birthday] [date] NOT NULL,
	[StaffAddress] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
	[IDNumber] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [Pass], [StaffID], [AccountType]) VALUES (N'admin', N'admin', N'ST01', 1)
INSERT [dbo].[Account] ([Username], [Pass], [StaffID], [AccountType]) VALUES (N'nhanvien', N'nhanvien', N'ST02', 2)
GO
INSERT [dbo].[Bill] ([BillID], [Price], [Date], [ClientID], [ShowtimeID]) VALUES (N'637705381522831903', 180000, CAST(N'2021-10-22T22:22:32.293' AS DateTime), N'CL01', N'ST02')
INSERT [dbo].[Bill] ([BillID], [Price], [Date], [ClientID], [ShowtimeID]) VALUES (N'637705407733582737', 90000, CAST(N'2021-10-22T23:06:13.357' AS DateTime), N'CL02', N'ST02')
INSERT [dbo].[Bill] ([BillID], [Price], [Date], [ClientID], [ShowtimeID]) VALUES (N'637705426905850916', 270000, CAST(N'2021-10-22T23:38:10.593' AS DateTime), N'CL01', N'ST02')
INSERT [dbo].[Bill] ([BillID], [Price], [Date], [ClientID], [ShowtimeID]) VALUES (N'637705965700026654', 165000, CAST(N'2021-10-23T14:36:10.033' AS DateTime), N'CL04', N'ST03')
GO
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (1, N'637705381522831903', N'F3', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (2, N'637705381522831903', N'F2', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (3, N'637705407733582737', N'G9', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (4, N'637705426905850916', N'B1', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (5, N'637705426905850916', N'B2', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (6, N'637705426905850916', N'B3', 90000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (7, N'637705965700026654', N'H4', 88000)
INSERT [dbo].[BillDetails] ([BillDetailsID], [BillID], [SeatID], [Price]) VALUES (8, N'637705965700026654', N'H5', 77000)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
GO
INSERT [dbo].[CinemaRoom] ([CinemaRoomID], [CinemaRoomName], [ScreenTypeID], [SeatRows], [SeatPerRow], [Seats], [CinemaRoomStatus]) VALUES (N'CNR01', N'ROOM 01', N'SCT01', 10, 10, 100, 1)
INSERT [dbo].[CinemaRoom] ([CinemaRoomID], [CinemaRoomName], [ScreenTypeID], [SeatRows], [SeatPerRow], [Seats], [CinemaRoomStatus]) VALUES (N'CNR02', N'ROOM 02', N'SCT02', 8, 10, 80, 1)
INSERT [dbo].[CinemaRoom] ([CinemaRoomID], [CinemaRoomName], [ScreenTypeID], [SeatRows], [SeatPerRow], [Seats], [CinemaRoomStatus]) VALUES (N'CNR03', N'ROOM 03', N'SCT03', 8, 8, 64, 1)
GO
INSERT [dbo].[Client] ([ClientID], [ClientName], [Birthday], [ClientAddress], [PhoneNumber], [IDNumber]) VALUES (N'CL01', N'Ngô Bá Kiệt', CAST(N'1990-04-26' AS Date), N'Quận 7, Hồ Chí Minh', N'0351265489', 201236548)
INSERT [dbo].[Client] ([ClientID], [ClientName], [Birthday], [ClientAddress], [PhoneNumber], [IDNumber]) VALUES (N'CL02', N'Bùi Minh Tuấn', CAST(N'1992-03-12' AS Date), N'Bình Thạnh, Hồ Chí Minh', N'0125478953', 213654850)
INSERT [dbo].[Client] ([ClientID], [ClientName], [Birthday], [ClientAddress], [PhoneNumber], [IDNumber]) VALUES (N'CL03', N'Ngô Thị Lê Na', CAST(N'2000-01-01' AS Date), N'Thủ Đức, Hồ Chí Minh', N'0321502168', 213569845)
INSERT [dbo].[Client] ([ClientID], [ClientName], [Birthday], [ClientAddress], [PhoneNumber], [IDNumber]) VALUES (N'CL04', N'Nguyễn Văn An', CAST(N'1998-08-16' AS Date), N'Quận 1, Hồ Chí Minh', N'0321564851', 230125684)
GO
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR01', N'Viễn tưởng')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR02', N'Hành động')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR03', N'Hài')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR04', N'Hoạt hình')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR05', N'Kinh dị')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR06', N'Gia đình')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR07', N'Tình cảm')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (N'GR08', N'Chính kịch')
GO
INSERT [dbo].[Movie] ([MovieID], [Title], [Runtime], [PreDate], [EndDate], [Nation], [Director], [YearProduce]) VALUES (N'MV01', N'Bố già', 128, CAST(N'2021-03-12' AS Date), CAST(N'2021-12-31' AS Date), N'Việt Nam', N'Vũ Ngọc Đãng, Trấn Thành', 2020)
INSERT [dbo].[Movie] ([MovieID], [Title], [Runtime], [PreDate], [EndDate], [Nation], [Director], [YearProduce]) VALUES (N'MV02', N'Godzilla vs Kong', 113, CAST(N'2021-03-26' AS Date), CAST(N'2021-12-31' AS Date), N'Mỹ', N'Adam Wingard', 2019)
INSERT [dbo].[Movie] ([MovieID], [Title], [Runtime], [PreDate], [EndDate], [Nation], [Director], [YearProduce]) VALUES (N'MV03', N'Ong nhí phiêu lưu ký ', 88, CAST(N'2021-03-24' AS Date), CAST(N'2021-12-31' AS Date), N'Mỹ', N'Noel Cleary', 2019)
GO
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV01', N'GR03')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV01', N'GR06')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV01', N'GR07')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV02', N'GR01')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV02', N'GR02')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV03', N'GR03')
INSERT [dbo].[MovieClassification] ([MovieID], [GenreID]) VALUES (N'MV03', N'GR04')
GO
INSERT [dbo].[MovieFormat] ([MovieFormatID], [MovieID], [ScreenTypeID]) VALUES (N'MF01', N'MV01', N'SCT01')
INSERT [dbo].[MovieFormat] ([MovieFormatID], [MovieID], [ScreenTypeID]) VALUES (N'MF02', N'MV02', N'SCT02')
INSERT [dbo].[MovieFormat] ([MovieFormatID], [MovieID], [ScreenTypeID]) VALUES (N'MF03', N'MV03', N'SCT03')
GO
SET IDENTITY_INSERT [dbo].[MovieTicket] ON 

INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (201, 0, N'ST01', N'A1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (202, 0, N'ST01', N'A2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (203, 0, N'ST01', N'A3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (204, 0, N'ST01', N'A4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (205, 0, N'ST01', N'A5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (206, 0, N'ST01', N'A6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (207, 0, N'ST01', N'A7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (208, 0, N'ST01', N'A8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (209, 0, N'ST01', N'A9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (210, 0, N'ST01', N'A10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (211, 0, N'ST01', N'B1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (212, 0, N'ST01', N'B2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (213, 0, N'ST01', N'B3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (214, 0, N'ST01', N'B4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (215, 0, N'ST01', N'B5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (216, 0, N'ST01', N'B6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (217, 0, N'ST01', N'B7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (218, 0, N'ST01', N'B8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (219, 0, N'ST01', N'B9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (220, 0, N'ST01', N'B10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (221, 0, N'ST01', N'C1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (222, 0, N'ST01', N'C2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (223, 0, N'ST01', N'C3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (224, 0, N'ST01', N'C4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (225, 0, N'ST01', N'C5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (226, 0, N'ST01', N'C6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (227, 0, N'ST01', N'C7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (228, 0, N'ST01', N'C8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (229, 0, N'ST01', N'C9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (230, 0, N'ST01', N'C10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (231, 0, N'ST01', N'D1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (232, 0, N'ST01', N'D2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (233, 0, N'ST01', N'D3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (234, 0, N'ST01', N'D4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (235, 0, N'ST01', N'D5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (236, 0, N'ST01', N'D6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (237, 0, N'ST01', N'D7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (238, 0, N'ST01', N'D8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (239, 1, N'ST01', N'D9', N'CL02', 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (240, 1, N'ST01', N'D10', N'CL02', 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (241, 0, N'ST01', N'E1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (242, 0, N'ST01', N'E2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (243, 0, N'ST01', N'E3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (244, 0, N'ST01', N'E4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (245, 1, N'ST01', N'E5', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (246, 1, N'ST01', N'E6', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (247, 1, N'ST01', N'E7', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (248, 1, N'ST01', N'E8', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (249, 0, N'ST01', N'E9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (250, 0, N'ST01', N'E10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (251, 0, N'ST01', N'F1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (252, 0, N'ST01', N'F2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (253, 0, N'ST01', N'F3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (254, 0, N'ST01', N'F4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (255, 0, N'ST01', N'F5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (256, 0, N'ST01', N'F6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (257, 1, N'ST01', N'F7', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (258, 1, N'ST01', N'F8', NULL, 1, 100000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (259, 0, N'ST01', N'F9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (260, 0, N'ST01', N'F10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (261, 0, N'ST01', N'G1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (262, 0, N'ST01', N'G2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (263, 0, N'ST01', N'G3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (264, 0, N'ST01', N'G4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (265, 0, N'ST01', N'G5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (266, 0, N'ST01', N'G6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (267, 0, N'ST01', N'G7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (268, 0, N'ST01', N'G8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (269, 0, N'ST01', N'G9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (270, 0, N'ST01', N'G10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (271, 0, N'ST01', N'H1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (272, 0, N'ST01', N'H2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (273, 0, N'ST01', N'H3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (274, 0, N'ST01', N'H4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (275, 0, N'ST01', N'H5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (276, 0, N'ST01', N'H6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (277, 0, N'ST01', N'H7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (278, 0, N'ST01', N'H8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (279, 0, N'ST01', N'H9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (280, 0, N'ST01', N'H10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (281, 0, N'ST01', N'I1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (282, 0, N'ST01', N'I2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (283, 0, N'ST01', N'I3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (284, 0, N'ST01', N'I4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (285, 0, N'ST01', N'I5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (286, 0, N'ST01', N'I6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (287, 0, N'ST01', N'I7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (288, 0, N'ST01', N'I8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (289, 0, N'ST01', N'I9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (290, 0, N'ST01', N'I10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (291, 0, N'ST01', N'J1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (292, 0, N'ST01', N'J2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (293, 0, N'ST01', N'J3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (294, 0, N'ST01', N'J4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (295, 0, N'ST01', N'J5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (296, 0, N'ST01', N'J6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (297, 0, N'ST01', N'J7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (298, 0, N'ST01', N'J8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (299, 0, N'ST01', N'J9', NULL, 0, 0)
GO
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (300, 0, N'ST01', N'J10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (301, 0, N'ST02', N'A1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (302, 0, N'ST02', N'A2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (303, 0, N'ST02', N'A3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (304, 0, N'ST02', N'A4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (305, 0, N'ST02', N'A5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (306, 0, N'ST02', N'A6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (307, 0, N'ST02', N'A7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (308, 0, N'ST02', N'A8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (309, 0, N'ST02', N'A9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (310, 0, N'ST02', N'A10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (311, 1, N'ST02', N'B1', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (312, 1, N'ST02', N'B2', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (313, 1, N'ST02', N'B3', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (314, 0, N'ST02', N'B4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (315, 1, N'ST02', N'B5', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (316, 2, N'ST02', N'B6', N'CL01', 1, 72000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (317, 0, N'ST02', N'B7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (318, 1, N'ST02', N'B8', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (319, 0, N'ST02', N'B9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (320, 0, N'ST02', N'B10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (321, 0, N'ST02', N'C1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (322, 0, N'ST02', N'C2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (323, 0, N'ST02', N'C3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (324, 0, N'ST02', N'C4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (325, 0, N'ST02', N'C5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (326, 0, N'ST02', N'C6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (327, 1, N'ST02', N'C7', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (328, 1, N'ST02', N'C8', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (329, 1, N'ST02', N'C9', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (330, 0, N'ST02', N'C10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (331, 0, N'ST02', N'D1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (332, 0, N'ST02', N'D2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (333, 0, N'ST02', N'D3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (334, 0, N'ST02', N'D4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (335, 0, N'ST02', N'D5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (336, 1, N'ST02', N'D6', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (337, 1, N'ST02', N'D7', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (338, 1, N'ST02', N'D8', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (339, 1, N'ST02', N'D9', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (340, 0, N'ST02', N'D10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (341, 0, N'ST02', N'E1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (342, 0, N'ST02', N'E2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (343, 0, N'ST02', N'E3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (344, 0, N'ST02', N'E4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (345, 1, N'ST02', N'E5', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (346, 0, N'ST02', N'E6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (347, 0, N'ST02', N'E7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (348, 1, N'ST02', N'E8', N'CL02', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (349, 1, N'ST02', N'E9', N'CL02', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (350, 0, N'ST02', N'E10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (351, 0, N'ST02', N'F1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (352, 1, N'ST02', N'F2', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (353, 1, N'ST02', N'F3', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (354, 0, N'ST02', N'F4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (355, 1, N'ST02', N'F5', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (356, 1, N'ST02', N'F6', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (357, 0, N'ST02', N'F7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (358, 1, N'ST02', N'F8', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (359, 0, N'ST02', N'F9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (360, 0, N'ST02', N'F10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (361, 0, N'ST02', N'G1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (362, 0, N'ST02', N'G2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (363, 0, N'ST02', N'G3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (364, 0, N'ST02', N'G4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (365, 0, N'ST02', N'G5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (366, 0, N'ST02', N'G6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (367, 1, N'ST02', N'G7', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (368, 1, N'ST02', N'G8', N'CL01', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (369, 1, N'ST02', N'G9', N'CL02', 1, 90000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (370, 0, N'ST02', N'G10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (371, 0, N'ST02', N'H1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (372, 0, N'ST02', N'H2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (373, 0, N'ST02', N'H3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (374, 0, N'ST02', N'H4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (375, 0, N'ST02', N'H5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (376, 0, N'ST02', N'H6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (377, 0, N'ST02', N'H7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (378, 0, N'ST02', N'H8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (379, 0, N'ST02', N'H9', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (380, 0, N'ST02', N'H10', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (381, 0, N'ST03', N'A1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (382, 0, N'ST03', N'A2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (383, 0, N'ST03', N'A3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (384, 0, N'ST03', N'A4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (385, 0, N'ST03', N'A5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (386, 0, N'ST03', N'A6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (387, 0, N'ST03', N'A7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (388, 0, N'ST03', N'A8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (389, 0, N'ST03', N'B1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (390, 0, N'ST03', N'B2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (391, 0, N'ST03', N'B3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (392, 0, N'ST03', N'B4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (393, 0, N'ST03', N'B5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (394, 0, N'ST03', N'B6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (395, 0, N'ST03', N'B7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (396, 0, N'ST03', N'B8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (397, 0, N'ST03', N'C1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (398, 0, N'ST03', N'C2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (399, 0, N'ST03', N'C3', NULL, 0, 0)
GO
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (400, 0, N'ST03', N'C4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (401, 0, N'ST03', N'C5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (402, 0, N'ST03', N'C6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (403, 0, N'ST03', N'C7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (404, 0, N'ST03', N'C8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (405, 0, N'ST03', N'D1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (406, 0, N'ST03', N'D2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (407, 0, N'ST03', N'D3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (408, 0, N'ST03', N'D4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (409, 0, N'ST03', N'D5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (410, 0, N'ST03', N'D6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (411, 0, N'ST03', N'D7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (412, 0, N'ST03', N'D8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (413, 0, N'ST03', N'E1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (414, 0, N'ST03', N'E2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (415, 0, N'ST03', N'E3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (416, 0, N'ST03', N'E4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (417, 0, N'ST03', N'E5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (418, 0, N'ST03', N'E6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (419, 0, N'ST03', N'E7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (420, 0, N'ST03', N'E8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (421, 0, N'ST03', N'F1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (422, 0, N'ST03', N'F2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (423, 0, N'ST03', N'F3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (424, 0, N'ST03', N'F4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (425, 0, N'ST03', N'F5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (426, 0, N'ST03', N'F6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (427, 0, N'ST03', N'F7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (428, 0, N'ST03', N'F8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (429, 0, N'ST03', N'G1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (430, 0, N'ST03', N'G2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (431, 0, N'ST03', N'G3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (432, 0, N'ST03', N'G4', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (433, 0, N'ST03', N'G5', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (434, 0, N'ST03', N'G6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (435, 0, N'ST03', N'G7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (436, 0, N'ST03', N'G8', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (437, 0, N'ST03', N'H1', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (438, 0, N'ST03', N'H2', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (439, 0, N'ST03', N'H3', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (440, 2, N'ST03', N'H4', N'CL04', 1, 88000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (441, 3, N'ST03', N'H5', N'CL04', 1, 77000)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (442, 0, N'ST03', N'H6', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (443, 0, N'ST03', N'H7', NULL, 0, 0)
INSERT [dbo].[MovieTicket] ([TicketsID], [TicketType], [ShowtimeID], [SeatID], [ClientID], [TicketStatus], [Price]) VALUES (444, 0, N'ST03', N'H8', NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[MovieTicket] OFF
GO
INSERT [dbo].[ScreenType] ([ScreenTypeID], [ScreenName]) VALUES (N'SCT01', N'2D')
INSERT [dbo].[ScreenType] ([ScreenTypeID], [ScreenName]) VALUES (N'SCT02', N'3D')
INSERT [dbo].[ScreenType] ([ScreenTypeID], [ScreenName]) VALUES (N'SCT03', N'IMAX')
INSERT [dbo].[ScreenType] ([ScreenTypeID], [ScreenName]) VALUES (N'SCT04', N'4D')
GO
INSERT [dbo].[Showtime] ([ShowtimeID], [ShowDate], [CinemaRoomID], [MovieFormatID], [TicketPrice], [ShowtimeStatus]) VALUES (N'ST01', CAST(N'2021-10-19T20:00:00.000' AS DateTime), N'CNR01', N'MF01', 100000, 1)
INSERT [dbo].[Showtime] ([ShowtimeID], [ShowDate], [CinemaRoomID], [MovieFormatID], [TicketPrice], [ShowtimeStatus]) VALUES (N'ST02', CAST(N'2021-10-23T18:00:00.000' AS DateTime), N'CNR02', N'MF02', 90000, 1)
INSERT [dbo].[Showtime] ([ShowtimeID], [ShowDate], [CinemaRoomID], [MovieFormatID], [TicketPrice], [ShowtimeStatus]) VALUES (N'ST03', CAST(N'2021-10-23T22:00:00.000' AS DateTime), N'CNR03', N'MF03', 110000, 1)
INSERT [dbo].[Showtime] ([ShowtimeID], [ShowDate], [CinemaRoomID], [MovieFormatID], [TicketPrice], [ShowtimeStatus]) VALUES (N'ST04', CAST(N'2021-10-24T20:00:00.000' AS DateTime), N'CNR01', N'MF01', 100000, 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [Birthday], [StaffAddress], [PhoneNumber], [IDNumber]) VALUES (N'ST01', N'Trần Ánh Nguyệt', CAST(N'1995-02-12' AS Date), N'Quận 1, Hồ Chí Minh', N'0325648951', 201123654)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [Birthday], [StaffAddress], [PhoneNumber], [IDNumber]) VALUES (N'ST02', N'Nguyễn Văn Nguyên', CAST(N'1998-05-24' AS Date), N'Biên Hoà, Đồng Nai', N'0532165894', 201354268)
GO
/****** Object:  Index [UQ__Client__564DB08AB0651FE2]    Script Date: 24/10/2021 20:31:04 ******/
ALTER TABLE [dbo].[Client] ADD UNIQUE NONCLUSTERED 
(
	[IDNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Staff__564DB08A0D368C92]    Script Date: 24/10/2021 20:31:04 ******/
ALTER TABLE [dbo].[Staff] ADD UNIQUE NONCLUSTERED 
(
	[IDNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CinemaRoom] ADD  CONSTRAINT [DF__CinemaRoo__Cinem__2D27B809]  DEFAULT ((1)) FOR [CinemaRoomStatus]
GO
ALTER TABLE [dbo].[MovieTicket] ADD  DEFAULT ('0') FOR [TicketType]
GO
ALTER TABLE [dbo].[MovieTicket] ADD  DEFAULT ('0') FOR [TicketStatus]
GO
ALTER TABLE [dbo].[MovieTicket] ADD  DEFAULT ('0') FOR [Price]
GO
ALTER TABLE [dbo].[Showtime] ADD  DEFAULT ('0') FOR [ShowtimeStatus]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[CinemaRoom]  WITH CHECK ADD  CONSTRAINT [FK__CinemaRoo__Scree__2E1BDC42] FOREIGN KEY([ScreenTypeID])
REFERENCES [dbo].[ScreenType] ([ScreenTypeID])
GO
ALTER TABLE [dbo].[CinemaRoom] CHECK CONSTRAINT [FK__CinemaRoo__Scree__2E1BDC42]
GO
ALTER TABLE [dbo].[MovieClassification]  WITH CHECK ADD FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genre] ([GenreID])
GO
ALTER TABLE [dbo].[MovieClassification]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[MovieFormat]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[MovieFormat]  WITH CHECK ADD FOREIGN KEY([ScreenTypeID])
REFERENCES [dbo].[ScreenType] ([ScreenTypeID])
GO
ALTER TABLE [dbo].[MovieTicket]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[MovieTicket]  WITH CHECK ADD FOREIGN KEY([ShowtimeID])
REFERENCES [dbo].[Showtime] ([ShowtimeID])
GO
ALTER TABLE [dbo].[Showtime]  WITH CHECK ADD  CONSTRAINT [FK__Showtime__Cinema__3D5E1FD2] FOREIGN KEY([CinemaRoomID])
REFERENCES [dbo].[CinemaRoom] ([CinemaRoomID])
GO
ALTER TABLE [dbo].[Showtime] CHECK CONSTRAINT [FK__Showtime__Cinema__3D5E1FD2]
GO
ALTER TABLE [dbo].[Showtime]  WITH CHECK ADD FOREIGN KEY([MovieFormatID])
REFERENCES [dbo].[MovieFormat] ([MovieFormatID])
GO
/****** Object:  StoredProcedure [dbo].[CreateAccount]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateAccount]--InsertAccount
@Username NVARCHAR(100), @StaffID VARCHAR(50)
AS
BEGIN
	INSERT dbo.Account( Username, Pass, StaffID )
	VALUES ( @username, '1', @StaffID )
END

GO
/****** Object:  StoredProcedure [dbo].[CreateBill]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreateBill]--InsertCustomer
@BillID varchar(50), @Price float, @Date Datetime, @ClientID varchar(50), @ShowtimeID varchar(50)
AS
BEGIN
	INSERT dbo.Bill(BillID, Price, Date, ClientID, ShowtimeID)
	VALUES (@BillID, @Price, @Date, @ClientID, @ShowtimeID)
END

GO
/****** Object:  StoredProcedure [dbo].[CreatebillDetails]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CreatebillDetails]
@BillID varchar(50), @SeatID varchar(50), @Price float
AS
BEGIN
	INSERT dbo.BillDetails(BillID, SeatID, Price)
	VALUES (@BillID, @SeatID, @Price)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateCinemaRoom]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateCinemaRoom]--InsertCinema
@CinemaRoomID VARCHAR(50), @CinemaRoomName NVARCHAR(100), @ScreenTypeID VARCHAR(50), @Seats INT, @CinemaRoomStatus INT, @SeatRows INT, @SeatPerRow INT
AS
BEGIN
	INSERT dbo.CinemaRoom( CinemaRoomID , CinemaRoomName , ScreenTypeID , Seats , CinemaRoomStatus , SeatRows , SeatPerRow)
	VALUES (@CinemaRoomID , @CinemaRoomName , @ScreenTypeID , @Seats , @CinemaRoomStatus , @SeatRows , @SeatPerRow)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateClient]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateClient]--InsertCustomer
@ClienID VARCHAR(50), @ClienName NVARCHAR(100), @Birthday date, @ClientAddress NVARCHAR(100), @PhoneNumber VARCHAR(100), @IDNumber INT
AS
BEGIN
	INSERT dbo.Client(ClientID, ClientName, Birthday, ClientAddress, PhoneNumber, IDNumber)
	VALUES (@ClienID, @ClienName, @Birthday, @ClientAddress, @PhoneNumber, @IDNumber)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateGenre]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--THỂ LOẠI
CREATE PROC [dbo].[CreateGenre]--InsertGenre
@GenreID VARCHAR(50), @GenreName NVARCHAR(100)
AS
BEGIN
	INSERT dbo.Genre (GenreID, GenreName)
	VALUES  (@GenreID, @GenreName)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateMovie]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateMovie]--InsertMovie
@MovieID VARCHAR(50), @Title NVARCHAR(100), @Runtime FLOAT, @PreDate DATE, @EndDate DATE, @Nation NVARCHAR(50), @Director NVARCHAR(100), @YearProduce INT
AS
BEGIN
	INSERT dbo.Movie(MovieID , Title , Runtime , PreDate , EndDate , Nation , Director , YearProduce)
	VALUES (@MovieID , @Title , @Runtime , @PreDate , @EndDate , @Nation , @Director , @YearProduce)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateMovieFormat]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateMovieFormat]--InsertFormatMovie
@MovieFormatID VARCHAR(50), @MovieID VARCHAR(50), @ScreenTypeID VARCHAR(50)
AS
BEGIN
	INSERT dbo.MovieFormat( MovieFormatID, MovieID, ScreenTypeID )
	VALUES  ( @MovieFormatID, @MovieID, @ScreenTypeID )
END

GO
/****** Object:  StoredProcedure [dbo].[CreateMovieTicketByShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--VÉ
CREATE PROC [dbo].[CreateMovieTicketByShowtime]--InsertTicketByShowTimes
@ShowtimeID VARCHAR(50), @SeatID VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.MovieTicket
	(
		ShowtimeID,
		SeatID,
		ClientID
	)
	VALUES
	(
		@ShowtimeID,
		@SeatID,
		NULL
	)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateScreenType]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--LOẠI MÀN HÌNH
CREATE PROC [dbo].[CreateScreenType]--InsertScreenType
@ScreenTypeID VARCHAR(50), @ScreenTypeName NVARCHAR(100)
AS
BEGIN
	INSERT dbo.ScreenType( ScreenTypeID, ScreenName )
	VALUES  (@ScreenTypeID, @ScreenTypeName)
END

GO
/****** Object:  StoredProcedure [dbo].[CreateShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateShowtime]--InsertShowtime
@ShowtimeID VARCHAR(50), @CinemaRoomID VARCHAR(50), @MovieFormatID VARCHAR(50), @ShowDate DATETIME, @TicketPrice FLOAT
AS
BEGIN
	INSERT dbo.Showtime( ShowtimeID , CinemaRoomID , MovieFormatID, ShowDate , TicketPrice , ShowtimeStatus )
	VALUES  ( @ShowtimeID , @CinemaRoomID , @MovieFormatID, @ShowDate  , @TicketPrice , 0 )
END

GO
/****** Object:  StoredProcedure [dbo].[CreateStaff]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CreateStaff]--InsertStaff
@StaffID VARCHAR(50), @StaffName NVARCHAR(100), @Birthday date, @StaffAddress NVARCHAR(100), @PhoneNumber VARCHAR(100), @IDNumber INT
AS
BEGIN
	INSERT dbo.Staff(StaffID, StaffName, Birthday, StaffAddress, PhoneNumber, IDNumber)
	VALUES (@StaffID, @StaffName, @Birthday, @StaffAddress, @PhoneNumber, @IDNumber)
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteMovieTicketByShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteMovieTicketByShowtime]--DeleteTicketsByShowTimes
@ShowtimeID VARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.MovieTicket
	WHERE ShowtimeID = @ShowtimeID
END

GO
/****** Object:  StoredProcedure [dbo].[GetAccountList]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TÀI KHOẢN (frmAdmin)
CREATE PROC [dbo].[GetAccountList]
AS
BEGIN
	SELECT TK.Username AS [Username], NV.StaffID AS [Mã nhân viên], NV.StaffName AS [Tên nhân viên]
	FROM dbo.Account TK, dbo.Staff NV
	WHERE NV.StaffID = TK.StaffID
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllListShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllListShowtime]--GetAllListShowTimes
AS
BEGIN
	select l.ShowtimeID, pc.CinemaRoomName, p.Title, l.ShowDate, d.MovieFormatID as MovieFormatID, l.TicketPrice, l.ShowtimeStatus
	from Movie p ,MovieFormat d, Showtime l, CinemaRoom pc
	where p.MovieID = d.MovieID and d.MovieFormatID = l.MovieFormatID and l.CinemaRoomID = pc.CinemaRoomID
	order by l.ShowDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetBill]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetBill]
AS
BEGIN
	SELECT BillID AS [Mã hoá đơn], Date AS [Ngày mua], ShowtimeID AS [Xuất chiếu], Price AS [Giá tổng]
	FROM dbo.Bill
END

GO
/****** Object:  StoredProcedure [dbo].[GetCinemaRoom]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--PHÒNG CHIẾU
CREATE PROC [dbo].[GetCinemaRoom]--GetCinema
AS
BEGIN
	SELECT PC.CinemaRoomID AS [Mã phòng], CinemaRoomName AS [Tên phòng], ScreenName AS [Tên màn hình], PC.Seats AS [Số chỗ ngồi], PC.CinemaRoomStatus AS [Tình trạng], PC.SeatRows AS [Số hàng ghế], PC.SeatPerRow AS [Ghế mỗi hàng]
	FROM dbo.CinemaRoom AS PC, dbo.ScreenType AS MH
	WHERE PC.ScreenTypeID = MH.ScreenTypeID
END

GO
/****** Object:  StoredProcedure [dbo].[GetClient]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetClient]--GetCustomer
AS
BEGIN
	SELECT ClientID AS [Mã khách hàng], ClientName AS [Họ tên], Birthday AS [Ngày sinh], ClientAddress AS [Địa chỉ], PhoneNumber AS [Số điện thoại], IDNumber AS [Chứng minh nhân dân]
	FROM dbo.Client
END

GO
/****** Object:  StoredProcedure [dbo].[GetListGenreByMovie]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetListGenreByMovie]
@MovieID VARCHAR(50)
AS
BEGIN
	SELECT TL.GenreID, GenreName
	FROM dbo.MovieClassification PL, dbo.Genre TL
	WHERE MovieID = @MovieID AND PL.GenreID = TL.GenreID
END

GO
/****** Object:  StoredProcedure [dbo].[GetListMovieFormat]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ĐỊNH DẠNG PHIM
CREATE PROC [dbo].[GetListMovieFormat]--GetListFormatMovie
AS
BEGIN
	SELECT DD.MovieFormatID AS [Mã định dạng], P.MovieID AS [Mã phim], P.Title AS [Tên phim], MH.ScreenTypeID AS [Mã màn hình], MH.ScreenName AS [Tên màn hình]
	FROM dbo.MovieFormat DD, Movie P, dbo.ScreenType MH
	WHERE DD.MovieID = P.MovieID AND DD.ScreenTypeID = MH.ScreenTypeID
END

GO
/****** Object:  StoredProcedure [dbo].[GetListShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetListShowtime]--GetListShowTimesByFormatMovie
@Date Datetime
AS
BEGIN
	select l.ShowtimeID, pc.CinemaRoomName, p.Title, l.ShowDate, d.MovieFormatID as MovieFormatID, l.TicketPrice, l.ShowtimeStatus
	from Movie p ,MovieFormat d, Showtime l, CinemaRoom pc
	where p.MovieID = d.MovieID and d.MovieFormatID = l.MovieFormatID and l.CinemaRoomID = pc.CinemaRoomID
	and CONVERT(DATE, @Date) = CONVERT(DATE, l.ShowDate)
	order by l.ShowDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetListShowtimeByMovieFormat]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--LỊCH CHIẾU
CREATE PROC [dbo].[GetListShowtimeByMovieFormat]--GetListShowTimesByFormatMovie
@MovieFormatID varchar(50), @Date Datetime
AS
BEGIN
	select l.ShowtimeID, pc.CinemaRoomName, p.Title, l.ShowDate, d.MovieFormatID as MovieFormatID, l.TicketPrice, l.ShowtimeStatus
	from Movie p ,MovieFormat d, Showtime l, CinemaRoom pc
	where p.MovieID = d.MovieID and d.MovieFormatID = l.MovieFormatID and l.CinemaRoomID = pc.CinemaRoomID
	and d.MovieFormatID = @MovieFormatID and CONVERT(DATE, @Date) = CONVERT(DATE, l.ShowDate)
	order by l.ShowDate
END
GO
/****** Object:  StoredProcedure [dbo].[GetListShowtimeNotCreateMovieTicket]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetListShowtimeNotCreateMovieTicket]--GetListShowTimesNotCreateTickets
AS
BEGIN
	select l.ShowtimeID, pc.CinemaRoomName, p.Title, l.ShowDate, d.MovieFormatID as MovieFormatID, l.TicketPrice, l.ShowtimeStatus
	from Movie p ,MovieFormat d, Showtime l, CinemaRoom pc
	where p.MovieID = d.MovieID and d.MovieFormatID = l.MovieFormatID and l.CinemaRoomID = pc.CinemaRoomID and l.ShowtimeStatus = 0
	order by l.ShowDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetListTicketByShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetListTicketByShowtime]--UpdateStatusShowTimes
AS
BEGIN
	select TicketsID as [Mã vé], TicketType as [Loại vé], ShowtimeID as [Mã lịch chiếu], SeatID as [Sô ghế], ClientID as [Mã khách hàng], Price as [Giá vé]
	from MovieTicket
END

GO
/****** Object:  StoredProcedure [dbo].[GetMovie]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetMovie]--GetMovie
AS
BEGIN
	SELECT MovieID AS [Mã phim], Title AS [Tên phim], Runtime AS [Thời lượng], PreDate AS [Ngày khởi chiếu], EndDate AS [Ngày kết thúc], Nation AS [Quốc gia], Director AS [Đạo diễn], YearProduce AS [Năm sản xuất]
	FROM dbo.Movie
END

GO
/****** Object:  StoredProcedure [dbo].[GetReportRevenueByMovieAndDate]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetReportRevenueByMovieAndDate]
@MovieID VARCHAR(50), @FromDate date, @ToDate date
AS
BEGIN
	SELECT P.Title, CONVERT(DATE, LC.ShowDate) AS NgayChieu, CONVERT(TIME(0),LC.ShowDate) AS GioChieu, COUNT(V.TicketsID) AS SoVeDaBan, SUM(Price) AS TienBanVe
	FROM dbo.MovieTicket AS V, dbo.Showtime AS LC, dbo.MovieFormat AS DDP, Movie AS P
	WHERE V.ShowtimeID = LC.ShowtimeID AND LC.MovieFormatID = DDP.MovieFormatID AND DDP.MovieID = P.MovieID AND V.TicketStatus = 1 AND P.MovieID = @MovieID AND LC.ShowDate >= @FromDate AND LC.ShowDate <= @ToDate
	GROUP BY V.ShowtimeID, P.Title, LC.ShowDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetRevenueByMovieAndDate]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DOANH THU
CREATE PROC [dbo].[GetRevenueByMovieAndDate]
@MovieID VARCHAR(50), @FromDate date, @ToDate date
AS
BEGIN
	SELECT P.Title AS [Tên phim], CONVERT(DATE, LC.ShowDate) AS [Ngày chiếu], CONVERT(TIME(0),LC.ShowDate) AS [Giờ chiếu], COUNT(V.TicketsID) AS [Số vé đã bán], SUM(Price) AS [Tiền vé]
	FROM dbo.MovieTicket AS V, dbo.Showtime AS LC, dbo.MovieFormat AS DDP, Movie AS P
	WHERE V.ShowtimeID = LC.ShowtimeID AND LC.MovieFormatID = DDP.MovieFormatID AND DDP.MovieID = P.MovieID AND V.TicketStatus = 1 AND P.MovieID = @MovieID AND LC.ShowDate >= @fromDate AND LC.ShowDate <= @ToDate
	GROUP BY V.ShowtimeID, P.Title, LC.ShowDate
END

GO
/****** Object:  StoredProcedure [dbo].[GetShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetShowtime]
AS
BEGIN
	SELECT LC.ShowtimeID AS [Mã lịch chiếu], LC.CinemaRoomID AS [Mã phòng], P.Title AS [Tên phim], MH.ScreenName AS [Màn hình], LC.ShowDate AS [Thời gian chiếu], LC.TicketPrice AS [Giá vé]
	FROM dbo.Showtime AS LC, dbo.MovieFormat AS DD, Movie AS P, dbo.ScreenType AS MH
	WHERE LC.MovieFormatID = DD.MovieFormatID AND DD.MovieID = P.MovieID AND DD.ScreenTypeID = MH.ScreenTypeID
END

GO
/****** Object:  StoredProcedure [dbo].[GetStaff]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetStaff]
AS
BEGIN
	SELECT StaffID AS [Mã nhân viên], StaffName AS [Họ tên], Birthday AS [Ngày sinh], StaffAddress AS [Địa chỉ], PhoneNumber AS [Số điện thoại], IDNumber AS [Chứng minh nhân dân]
	FROM dbo.Staff
END

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Login]
@Username NVARCHAR(1000), @Pass VARCHAR(1000)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS AND Pass = @Pass COLLATE SQL_Latin1_General_CP1_CS_AS

END

GO
/****** Object:  StoredProcedure [dbo].[ResetPasswordForAccount]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ResetPasswordForAccount]--ResetPasswordAccount
@Username NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account 
	SET Pass = '1' 
	WHERE Username = @Username
END

GO
/****** Object:  StoredProcedure [dbo].[SearchAccount]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchAccount]
@StaffName NVARCHAR(100)
AS
BEGIN
	SELECT TK.UserName AS [Username], NV.StaffID AS [Mã nhân viên], NV.StaffName AS [Tên nhân viên]
	FROM dbo.Account TK, dbo.Staff NV
	WHERE NV.StaffID = TK.StaffID AND dbo.fuConvertToUnsign1(NV.StaffName) LIKE N'%' + dbo.fuConvertToUnsign1(@StaffName) + N'%'
END

GO
/****** Object:  StoredProcedure [dbo].[SearchClient]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SearchClient]--SearchCustomer
@ClienName NVARCHAR(100)
AS
BEGIN
	SELECT ClientID AS [Mã khách hàng], ClientName AS [Họ tên], Birthday AS [Ngày sinh], ClientAddress AS [Địa chỉ], PhoneNumber AS [Số điện thoại], IDNumber AS [Chứng minh nhân dân]
	FROM dbo.Client
	WHERE dbo.fuConvertToUnsign1(ClientName) LIKE N'%' + dbo.fuConvertToUnsign1(@ClienName) + N'%' or PhoneNumber like @ClienName
END
GO
/****** Object:  StoredProcedure [dbo].[SearchShowtimeByTitle]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SearchShowtimeByTitle]--SearchShowtimeByMovieName
@Title NVARCHAR(100)
AS
BEGIN
	SELECT LC.ShowtimeID AS [Mã lịch chiếu], LC.CinemaRoomID AS [Mã phòng], P.Title AS [Tên phim], MH.ScreenName AS [Màn hình], LC.ShowDate AS [Thời gian chiếu], LC.TicketPrice AS [Giá vé]
	FROM dbo.Showtime AS LC, dbo.MovieFormat AS DD, Movie AS P, dbo.ScreenType AS MH
	WHERE LC.MovieFormatID = DD.MovieFormatID AND DD.MovieID = P.MovieID AND DD.ScreenTypeID = MH.ScreenTypeID AND dbo.fuConvertToUnsign1(P.Title) LIKE N'%' + dbo.fuConvertToUnsign1(@Title) + N'%'
END

GO
/****** Object:  StoredProcedure [dbo].[SearchStaff]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchStaff]
@StaffName NVARCHAR(100)
AS
BEGIN
	SELECT StaffID AS [Mã nhân viên], StaffName AS [Họ tên], Birthday AS [Ngày sinh], StaffAddress AS [Địa chỉ], PhoneNumber AS [Số điện thoại], IDNumber AS [Chứng minh nhân dân]
	FROM dbo.Staff
	WHERE dbo.fuConvertToUnsign1(StaffName) LIKE N'%' + dbo.fuConvertToUnsign1(@StaffName) + N'%'
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateMovie]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateMovie]
@MovieID VARCHAR(50), @Title NVARCHAR(100), @Runtime FLOAT, @PreDate DATE, @EndDate DATE, @Nation NVARCHAR(50), @Director NVARCHAR(100), @YearProduce INT
AS
BEGIN
	UPDATE dbo.Movie SET Title = @Title, Runtime = @Runtime, PreDate = @PreDate, EndDate = @EndDate, Nation = @Nation, Director = @Director, YearProduce = @YearProduce WHERE MovieID = @MovieID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePasswordForAccount]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Stored Procedures
--TÀI KHOẢN (Đổi mật khẩu & đăng nhập)
CREATE PROC [dbo].[UpdatePasswordForAccount]
@Username NVARCHAR(100), @Pass VARCHAR(1000), @NewPass VARCHAR(1000)
AS
BEGIN
	DECLARE @IsRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE Username = @Username AND Pass = @Pass

	IF (@IsRightPass = 1)
	BEGIN
		UPDATE dbo.Account SET Pass = @NewPass WHERE Username = @Username
    END
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateShowtime]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateShowtime]
@ShowtimeID VARCHAR(50), @CinemaRoomID VARCHAR(50), @MovieFormatID VARCHAR(50), @ShowDate DATETIME, @TicketPrice FLOAT
AS
BEGIN
	UPDATE dbo.Showtime 
	SET CinemaRoomID = @CinemaRoomID, MovieFormatID = @MovieFormatID, ShowDate = @ShowDate , TicketPrice = @TicketPrice
	WHERE ShowtimeID = @ShowtimeID
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateShowtimeStatus]    Script Date: 24/10/2021 20:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateShowtimeStatus]--UpdateStatusShowTimes
@ShowtimeID NVARCHAR(50), @ShowtimeStatus int
AS
BEGIN
	UPDATE dbo.Showtime
	SET ShowtimeStatus = @ShowtimeStatus
	WHERE ShowtimeID = @ShowtimeID
END

GO
USE [master]
GO
ALTER DATABASE [QuanLyRapPhim] SET  READ_WRITE 
GO
