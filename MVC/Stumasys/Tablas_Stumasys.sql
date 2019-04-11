CREATE TABLE [dbo].[Course](
  	[CourseID] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Title] [varchar](100) NOT NULL,
	[Credits] [int] NOT NULL,
)

CREATE TABLE [dbo].[Person](
	[PersonID] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[HireDate] [datetime] NULL,
	[EnrollmentDate] [datetime] NULL,
)


CREATE TABLE [dbo].[StudentGrade](
	[EnrollmentID] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[CourseID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[Grade] [decimal](3, 2) NULL,
)

ALTER TABLE [dbo].[StudentGrade]  WITH CHECK ADD  CONSTRAINT [FK_StudentGrade_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO

ALTER TABLE [dbo].[StudentGrade] CHECK CONSTRAINT [FK_StudentGrade_Course]
GO

ALTER TABLE [dbo].[StudentGrade]  WITH CHECK ADD  CONSTRAINT [FK_StudentGrade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Person] ([PersonID])
GO

ALTER TABLE [dbo].[StudentGrade] CHECK CONSTRAINT [FK_StudentGrade_Student]
GO