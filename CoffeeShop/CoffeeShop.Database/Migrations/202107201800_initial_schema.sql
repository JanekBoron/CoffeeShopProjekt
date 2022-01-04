SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User]
(
    [UserId]     [UNIQUEIDENTIFIER] NOT NULL,
    [Login]  [NVARCHAR](100)     NOT  NULL,
    [Email]     [NVARCHAR](100)    NOT NULL,
    [FirstName]     [NVARCHAR](100)    NOT NULL,
    [LastName]     [NVARCHAR](100)    NOT NULL,
    [DateOfBirth]     [date]    NOT NULL,
   
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED
        (
         [UserId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) 
CREATE TABLE [dbo].[Shop]
(
    [ShopId]     [UNIQUEIDENTIFIER] NOT NULL,
    [Name] [NVARCHAR](100)     NOT  NULL,
    [Email] [NVARCHAR](100)     NOT  NULL,
    [FoundedDate] [date]     NOT  NULL,
)
ON [PRIMARY]
GO