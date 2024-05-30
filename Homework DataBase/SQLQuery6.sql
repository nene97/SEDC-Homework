USE SEDCACADEMYDB

--Declare scalar variable for storing FirstName values
--• Assign value ‘Antonio’ to the FirstName variable
--• Find all Students having FirstName same as the variable
	DECLARE @FirstName VARCHAR(100)
	SET @FirstName = 'Antonio'

	SELECT *
	FROM Student
	WHERE FirstName = @FirstName
	GO


--• Declare table variable that will contain StudentId, StudentName and DateOfBirth
--• Fill the table variable with all Female students

DECLARE @FemaleStudents TABLE
(StudentID INT , StudentName NVARCHAR(100) ,DateOfBirth DATE)

INSERT INTO @FemaleStudents
SELECT ID , FirstName , DateOfBirth
FROM Student
WHERE Gender = 'F'

SELECT *
FROM @FemaleStudents
GO

--• Declare temp table that will contain LastName and EnrolledDate columns
--• Fill the temp table with all Male students having First Name starting with ‘A’
CREATE TABLE #MaleStudentsNameA
(LastName NVARCHAR(100),EnrolledDate DATE )

INSERT INTO #MaleStudentsNameA
SELECT LastName , EnrolledDate
FROM Student
WHERE FirstName LIKE 'A%'

SELECT *
FROM #MaleStudentsNameA
GO

--• Retrieve the students from the table which last name is with 7 characters
SELECT *
FROM #MaleStudentsNameA
WHERE LEN(LastName) = 7
GO

--• Find all teachers whose FirstName length is less than 5 and
--• the first 3 characters of their FirstName and LastName are the same

SELECT FirstName , LastName
FROM Teacher
WHERE LEN(FirstName) < 5
GROUP BY FirstName , LastName
HAVING LEFT(FirstName , 3) = SUBSTRING(LastName, 1 ,3)



