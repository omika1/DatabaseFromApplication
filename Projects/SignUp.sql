USE [Registration]
GO

/****** Object:  Table [dbo].[UserDetails]    Script Date: 10/13/2020 5:57:57 PM ******/
SET ANSI_NULLS ON
GO
SET IDENTITY_INSERT UserDetails ON
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserDetails](
       [UserId] [int] IDENTITY(1,1) NOT NULL,
       [FirstName] [nvarchar](50) NOT NULL,
       [LastName] [nvarchar](50) NOT NULL,
       [UserName] [nvarchar](50) NOT NULL,
       [Password] [nvarchar](50) NOT NULL,
       [Email] [nvarchar](50) NOT NULL,
       [UserRole] [nvarchar](50) NOT NULL,
       [CreatedDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
