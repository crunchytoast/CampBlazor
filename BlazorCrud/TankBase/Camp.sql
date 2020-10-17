CREATE TABLE [dbo].[Camp]
(
	[CampId] [int] IDENTITY(1,1) NOT NULL primary key,
	[CampName] [varchar](250) NOT NULL,
	[StartDate] [datetimeoffset](7) NOT NULL,
	[EndDate] [datetimeoffset](7) NOT NULL,
	[DIYs] [int] NULL,
)
