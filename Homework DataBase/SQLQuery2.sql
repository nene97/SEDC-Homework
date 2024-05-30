



--Requirements:
--● Find all Students with FirstName = Antonio

SELECT *
FROM Student
WHERE FirstName = 'Antonio'


--● Find all Students with DateOfBirth greater than ‘01.01.1999’

SELECT *
FROM Student
WHERE DateOfBirth > '01.01.1999'


--● Find all Students with LastName starting With ‘J’ enrolled in January/1998


SELECT *
FROM Student
WHERE LastName LIKE 'J%' AND EnrolledDate >= '01.01.1998' AND EnrolledDate < '01.02.1998'

--● List all Students ordered by FirstName
SELECT *
FROM Student
ORDER BY FirstName

--● List all Teacher Last Names and Student Last Names in single result set.
--Remove duplicates
SELECT LastName FROM Teacher
UNION
SELECT LastName FROM Student


--● Create Foreign key constraints from diagram or with script
ALTER TABLE GradeDetails
ADD CONSTRAINT FK_GradeDetails_Grade
FOREIGN KEY (GradeID)
REFERENCES Grade (ID)


ALTER TABLE GradeDetails
ADD CONSTRAINT FK_GradeDetails_AcheievmentType
FOREIGN KEY (AchievementTypeID)
REFERENCES AchievementType (ID)


ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Student
FOREIGN KEY (StudentID)
REFERENCES Student (ID)

ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Course
FOREIGN KEY (CourseID)
REFERENCES Course (ID)

ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Teacher
FOREIGN KEY (TeacherID)
REFERENCES Teacher (ID)

--● List all possible combinations of Courses names and AchievementType names that can be passed by student

SELECT C.[Name] AS CourseName , [AT].[Name] AS  AchievementType
FROM Course C
CROSS JOIN AchievementType [AT]
ORDER BY C.[Name]


--● List all Teachers without exam Grade


SELECT T.ID, T.FirstName ,G.ID, G.TeacherID
FROM Teacher T
LEFT OUTER JOIN Grade G
ON T.ID = G.TeacherID
WHERE G.TeacherID IS NULL




