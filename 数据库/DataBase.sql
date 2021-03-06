SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookInfo](
	[BookID] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[BookBarCode] [nvarchar](50) NOT NULL,
	[BookType] [nvarchar](50) NOT NULL,
	[TotalNum] [nvarchar](50) NOT NULL,
	[StorPosion] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Press] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[StoreDate] [datetime] NOT NULL,
 CONSTRAINT [PK_图书信息表] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create trigger [del] on [dbo].[BookInfo]
for delete
as
delete 简介表 
  where 图书编号 in (select 图书编号 from deleted)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookType](
	[TypeID] [nvarchar](20) NOT NULL,
	[TypeName] [nvarchar](20) NULL,
	[BorrowDays] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Borrow]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Borrow](
	[BorrowID] [int] NOT NULL,
	[BookID] [nvarchar](20) NULL,
	[ReaderID] [nvarchar](20) NULL,
	[BorrowDate] [smalldatetime] NULL,
	[MustReturnDate] [smalldatetime] NULL,
	[RenewNum] [int] NULL,
	[Operator] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReaderInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReaderInfo](
	[ReaderBarCode] [nvarchar](20) NULL,
	[ReaderID] [nvarchar](20) NOT NULL,
	[ReaderName] [nvarchar](20) NULL,
	[Sex] [nvarchar](8) NULL,
	[ReaderType] [nvarchar](20) NULL,
	[BirthDate] [smalldatetime] NULL,
	[CardName] [nvarchar](20) NULL,
	[CardNumber] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[RegisterDate] [smalldatetime] NULL,
	[ValidityDate] [smalldatetime] NULL,
	[Operator] [nvarchar](20) NULL,
	[Remarks] [nvarchar](100) NULL,
	[BookBorrowNum] [int] NULL,
	[PeriodicalBorrowNum] [int] NULL,
	[IsLoss] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReaderType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ReaderType](
	[TypeName] [nvarchar](20) NOT NULL,
	[BookNum] [int] NULL,
	[PeriodicalNum] [int] NULL,
	[RenewNum] [int] NULL,
	[IsRestrictBook] [bit] NULL,
	[IsRestrictPeriodical] [bit] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Return]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Return](
	[ReturnID] [int] NOT NULL,
	[BookID] [nvarchar](20) NULL,
	[ReaderID] [nvarchar](20) NULL,
	[ReturnDate] [smalldatetime] NULL,
	[Operator] [nvarchar](20) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NewBookInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NewBookInfo](
	[BookID] [nchar](50) NULL,
	[BookName] [nchar](50) NULL,
	[BookBarCode] [nchar](50) NULL,
	[BookType] [nchar](50) NULL,
	[TotalNum] [nchar](50) NULL,
	[StorPosion] [nchar](50) NULL,
	[NewPrice] [float] NULL,
	[Press] [nchar](50) NULL,
	[Author] [nchar](50) NULL,
	[StoreDate] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[book]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[book](
	[BID] [nvarchar](50) NULL,
	[BName] [nvarchar](50) NULL,
	[BWriter] [nvarchar](50) NULL,
	[BPublish] [nvarchar](50) NULL,
	[BDate] [datetime] NULL,
	[BPrice] [nvarchar](50) NULL,
	[BNum] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[BRemark] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manager]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[manager](
	[MName] [nvarchar](50) NULL,
	[MCode] [nvarchar](50) NULL,
	[manage] [bit] NOT NULL,
	[work] [bit] NOT NULL,
	[query] [bit] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[person]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[person](
	[PID] [nvarchar](50) NULL,
	[PName] [nvarchar](50) NULL,
	[PSex] [nvarchar](50) NULL,
	[PPhone] [nvarchar](50) NULL,
	[PN] [nvarchar](50) NULL,
	[PCode] [nvarchar](50) NULL,
	[PMoney] [decimal](18, 2) NULL,
	[identity] [nvarchar](50) NULL,
	[PRemark] [nvarchar](50) NULL,
	[sys] [bit] NOT NULL,
	[identityname] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[type]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[type](
	[TID] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[tRemark] [nvarchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[identityinfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[identityinfo](
	[identity] [nvarchar](50) NULL,
	[identityname] [nvarchar](50) NULL,
	[longTime] [int] NULL,
	[bigNum] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[bookOut]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[bookOut](
	[OID] [int] NOT NULL,
	[BID] [nvarchar](50) NULL,
	[PID] [nvarchar](50) NULL,
	[ODate] [datetime] NULL
) ON [PRIMARY]
END
