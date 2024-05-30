
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Nebojsha
-- Create date: 30.05.2024
-- Description:	Homework 02.2
--• Create new procedure called CreateGradeDetail;
--• Procedure should add details for specific Grade (new record for new
--AchievementTypeID, Points, MaxPoints, Date for specific Grade);
--• Output from this procedure should be resultset with SUM of
--GradePoints calculated with formula
--AchievementPoints/AchievementMaxPoints*ParticipationRate for
--specific Grade

-- =============================================
ALTER PROCEDURE CreateGradeDetail
	@GradeID INT,
	@AchievementTypeID INT,
	@AchievementPoints INT,
	@AchievementMaxPoints INT,
	@AchievementDate DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO GradeDetails
	VALUES (@GradeID,@AchievementTypeID,@AchievementPoints,@AchievementMaxPoints,@AchievementDate)

	
	SELECT (GD.AchievementPoints/GD.AchievementMaxPoints) * A.ParticipationRate AS GradePoints
	FROM GradeDetails GD
	INNER JOIN AchievementType A
	ON A.ID = GD.AchievementTypeID
	WHERE GD.GradeID = @GradeID
	
END
GO


EXEC CreateGradeDetail
	@GradeID = 51,
	@AchievementTypeID = 5,
	@AchievementPoints = 6,
	@AchievementMaxPoints = 100,
	@AchievementDate = '2024-05-31'
