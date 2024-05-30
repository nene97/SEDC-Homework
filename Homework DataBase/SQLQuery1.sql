CREATE DATABASE SEDCACADEMYDB
USE SEDCACADEMYDB

CREATE TABLE Student(
ID int NOT NULL,
FirstName nvarchar(100) NOT NULL,
LastName nvarchar(100) NOT NULL,
DateOfBirth date,
EnrolledDate date,
Gender nchar(1),
NationalIDNumber nvarchar(20),
StudentCardNumber nvarchar(20)
)



CREATE TABLE Teacher(
ID int NOT NULL,
FirstName nvarchar(100) NOT NULL,
LastName nvarchar(100) NOT NULL,
DateOfBirth date,
AcademicRank  nvarchar(100),
HireDate date,
)


CREATE TABLE Grade(
ID int NOT NULL,
StudentID int NOT NULL,
CourseID int NOT NULL,
TeacherID int NOT NULL,
Grade int,
Comment nvarchar(100),
CreatedDate date
)

CREATE TABLE Course(
ID int NOT NULL,
[Name] nvarchar(100) NOT NULL,
Credit INT,
AcademicYear INT,
Semester INT
)

CREATE TABLE GradeDetails(
ID int NOT NULL,
GradeID INT NOT NULL,
AchievementTypeID INT NOT NULL,
AchievementPoints INT ,
AchievementMaxPoints INT ,
AchievementDate date
)

CREATE TABLE AchievementType(
ID int NOT NULL,
[Name] nvarchar(100) NOT NULL,
[Description] nvarchar(100) ,
ParticipationRate INT
)