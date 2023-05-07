USE [Sales Data]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 5/7/2023 5:25:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[OrderId] [nvarchar](255) NULL,
	[ProductId] [nvarchar](255) NULL,
	[Category] [nvarchar](255) NULL,
	[SubCategory] [nvarchar](255) NULL,
	[ProductName] [nvarchar](255) NULL,
	[Sales] [float] NULL,
	[Quantity] [float] NULL,
	[Discount] [float] NULL,
	[Profit] [float] NULL
) ON [PRIMARY]
GO


