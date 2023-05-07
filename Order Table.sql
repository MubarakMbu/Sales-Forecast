USE [Sales Data]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 5/7/2023 5:22:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[OrderId] [nvarchar](255) NULL,
	[OrderDate] [datetime] NULL,
	[ShipDate] [datetime] NULL,
	[ShipMode] [nvarchar](255) NULL,
	[CustomerId] [nvarchar](255) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[Segment] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[State] [nvarchar](255) NULL,
	[Postal Code] [float] NULL,
	[Region] [nvarchar](255) NULL
) ON [PRIMARY]
GO


