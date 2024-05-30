--HOMEWORK REQUIREMENTS
--● Calculate the count of all grades per Teacher in the system
USE 
SEDCACADEMYDB


SELECT T.FirstName, COUNT(Grade) AS AllGradesPerTeacher
FROM Grade G
INNER JOIN Teacher T
ON G.TeacherID = T.ID
GROUP BY T.FirstName


--● Calculate the count of all grades per Teacher in the system for first 100
--Students (ID < 100)

SELECT T.FirstName, COUNT(Grade) AS AllGradesPerTeacher
FROM Grade G
INNER JOIN Teacher T
ON G.TeacherID = T.ID
WHERE StudentID < 100
GROUP BY T.FirstName


--● Find the Maximal Grade, and the Average Grade per Student on all grades in
--the system

SELECT S.FirstName, MAX(Grade) AS MaximalGrade, AVG(Grade) AS AverageGrade
FROM Grade G
INNER JOIN Student S 
ON G.StudentID = S.ID
GROUP BY S.FirstName



--● Calculate the count of all grades per Teacher in the system and filter only
--grade count greater then 200

SELECT T.FirstName, COUNT(Grade) AS AllGradesPerTeacher
FROM Grade G
INNER JOIN Teacher T
ON G.TeacherID = T.ID
GROUP BY T.FirstName
HAVING COUNT(Grade) > 200


--● Find the Grade Count, Maximal Grade, and the Average Grade per Student on
--all grades in the system. Filter only records where Maximal Grade is equal to
--Average Grade

SELECT S.FirstName, MAX(Grade) AS MaximalGrade, AVG(Grade) AS AverageGrade ,COUNT(Grade) AS GradeCount
FROM Grade G
INNER JOIN Student S 
ON G.StudentID = S.ID
GROUP BY S.FirstName
HAVING MAX(Grade) = AVG(Grade)
--There are none


--● List Student First Name and Last Name next to the other details from previous
--query

SELECT S.FirstName, S.LastName, MAX(Grade) AS MaximalGrade, AVG(Grade) AS AverageGrade ,COUNT(Grade) AS GradeCount
FROM Grade G
INNER JOIN Student S 
ON G.StudentID = S.ID
GROUP BY S.FirstName , S.LastName

--● Create new view (vv_StudentGrades) that will List all StudentIds and count of
--Grades per student

CREATE VIEW vv_StudentGrades
AS
SELECT S.ID, COUNT(Grade) AS GradeCount
FROM Grade G
INNER JOIN Student S 
ON G.StudentID = S.ID
GROUP BY S.ID

SELECT *
FROM  vv_StudentGrades


--● Change the view to show Student First and Last Names instead of StudentID
ALTER VIEW vv_StudentGrades
AS
SELECT S.FirstName, S.LastName, COUNT(Grade) AS GradeCount
FROM Grade G
INNER JOIN Student S 
ON G.StudentID = S.ID
GROUP BY S.FirstName, S.LastName


--● List all rows from view ordered by biggest Grade Count

SELECT *
FROM  vv_StudentGrades
ORDER BY GradeCount DESC