CREATE TABLE [dbo].[Class]
(
	[ClassId] int Identity(1,1) NOT NULL Primary Key,
	[ClassDate] [datetimeoffset] NOT NULL,
	[ClassStartTime] [datetime] NOT NULL,
	[ClassEndTime] [datetime] NOT NULL,
	[SchoolId] Int foreign key references School(Id) On Delete Cascade,
	[TeacherId] Int foreign key references Teacher(id) On Delete Cascade,
	[CampId] Int foreign key references Camp(Id) On Delete Cascade,
)
