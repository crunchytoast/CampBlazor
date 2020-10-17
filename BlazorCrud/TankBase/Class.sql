CREATE TABLE [dbo].[Class]
(
	[ClassId] int Identity(1,1) NOT NULL Primary Key,
	[ClassDate] [datetimeoffset] NOT NULL,
	[ClassStartTime] [datetime] NOT NULL,
	[ClassEndTime] [datetime] NOT NULL,
	[ClassSchool] varchar(250) NULL,
	[ClassStudent] varchar(250) NULL,
)
