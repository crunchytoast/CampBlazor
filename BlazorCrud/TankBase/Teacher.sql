CREATE TABLE [dbo].[Teacher]
(
	[TeacherId] [int] IDENTITY(1,1) NOT NULL Primary Key,
	[TeacherName] [varchar](250) NOT NULL,
	[School] [varchar](20) NOT NULL,
	[Colour] [varchar](20) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
)
