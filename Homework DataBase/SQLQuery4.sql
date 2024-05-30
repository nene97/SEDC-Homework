
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Nebojsha
-- Create date: 30.05.2024
-- Description:	--Homework 02.1
--• Create new procedure called CreateGrade;
--• Procedure should create only Grade header info (not Grade Details);
--• Procedure should return the total number of grades in the system for
--the Student on input (from the CreateGrade);
--• Procedure should return second resultset with the MAX Grade of all
--grades for the Student and Teacher on input (regardless the Course).


-- =============================================
CREATE PROCEDURE  CreateGrade
		@StudentID INT ,
		@CourseID INT ,
		@TeacherID INT ,
		@Grade INT,
		@Comment NVARCHAR(100),
		@CreatedDate Datetime
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Grade
	VALUES (@StudentID,@CourseID ,@TeacherID,@Grade,@Comment,@CreatedDate)

	SELECT COUNT(*) AS TotalNumber
	FROM Grade
	WHERE StudentID = @StudentID

	SELECT MAX(Grade) AS MaxGrade
	FROM Grade
	WHERE StudentID = @StudentID AND TeacherID = @TeacherID
    

END
GO

EXEC CreateGrade
		@StudentID = 237 ,
		@CourseID = 37 ,
		@TeacherID = 80 ,
		@Grade = 8,
		@Comment = 'New Grade',
		@CreatedDate  = '2019-04-30 00:00:00.000'