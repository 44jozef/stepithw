use master

use academy

create table Faculties( --
 Id int primary key identity(1,1) NOT NULL,
 Financing Money NOT NULL check(Financing > 0),
 Name nvarchar(30) unique check(Name <> N''),
) 


create table Subjects (
 Id int primary key identity(1,1) NOT NULL,
 Name nvarchar(100) unique NOT NULL,
)


create table Teachers ( 
 Id int primary key identity (1,1) NOT NULL,
 Name nvarchar(100) unique NOT NULL,
 Salary money check(Salary > 0) NOT NULL,
 Surname nvarchar(100) check(Surname <> N'')
)


create table Departments( 
 Id int primary key identity(1,1) NOT NULL,
 Financing Money NOT NULL check(Financing > 0) Default(0),
 Name nvarchar(30) unique check(Name <> N''),
 [FacultyId] int foreign key references Faculties(Id),
)

create table Groups ( 
 Id int primary key identity(1,1) NOT NULL,
 Name nvarchar(30) unique check(Name <> N''),
 Year int NOT NULL check(Year >= 1 and Year <= 5),
 DepartamentId int foreign key references Departments(Id),
)


create table Lectures (
 Id int primary key identity(1,1) NOT NULL,
 LectureRoom nvarchar(100) check (LectureRoom <> N''),
 SubjectId int foreign key references Subjects(Id),
 TeacherId int foreign key references Teachers(Id)
)

create table GroupsLectures ( 
 Id int primary key identity(1,1) NOT NULL,
 DayOfWeek int NOT NULL check(DayOfWeek >= 1 and DayOfWeek <= 7),
 GroupId int foreign key references Groups(Id),
 LectureId int foreign key references Lectures(Id)
)


INSERT INTO Teachers(Name,Salary,Surname) Values (N'Jack',1200,N'Underhill')
INSERT INTO Subjects(Name) Values (N'CS1')
INSERT INTO Lectures(LectureRoom,SubjectId,TeacherId) Values (N'D201',1,1)

INSERT INTO Faculties(Financing,Name) Values (6000,N'Computer Science')
INSERT INTO Departments (Financing,Name,FacultyId) Values (9000,N'Science',1)
INSERT INTO Groups(Name,Year,DepartamentId) Values (N'FBAS 3_22_11',3,1)



INSERT INTO Teachers(Name,Salary,Surname) Values (N'Dave',1000,N'McQueen')
INSERT INTO Subjects(Name) Values (N'Development')
INSERT INTO Lectures(LectureRoom,SubjectId,TeacherId) Values (N'D201',2,2)


INSERT INTO Faculties(Financing,Name) Values (6000,N'SD1')
INSERT INTO Departments (Financing,Name,FacultyId) Values (9000,N'Software Development',2)
INSERT INTO Groups(Name,Year,DepartamentId) Values (N'FBAS 3_11_11',5,2)


INSERT INTO GroupsLectures(DayOfWeek,GroupId,LectureId) Values (4,1,1)
INSERT INTO GroupsLectures(DayOfWeek,GroupId,LectureId) Values (6,2,2)




--1
select  COUNT(Lectures.TeacherId) as SoftwareDevelopmentTeachers  from GroupsLectures
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
Where Departments.Name = N'Software Development'


--2
select COUNT(GroupsLectures.LectureId) as DaveMcQueenLectures from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
Where Teachers.Name = N'Dave' and Teachers.Surname = N'McQueen'

--3
select COUNT(GroupsLectures.LectureId) as LecturesInD201 from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
WHERE Lectures.LectureRoom = N'D201'

--4
select LectureRoom  ,COUNT(GroupsLectures.LectureId) as Lectures from GroupsLectures
INNER JOIN Lectures  on GroupsLectures.LectureId = Lectures.Id
Group by Lectures.LectureRoom

--5 
select COUNT(GroupsLectures.GroupId) as Groups from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
Where Teachers.Name = N'Jack' and Teachers.Surname = 'Underhill'

--6
select AVG(Teachers.Salary) as AverageSalary from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id
Where Faculties.Name = N'Computer Science'

--7 
select AVG(Groups.Year) from GroupsLectures
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id



--8
select AVG(Departments.Financing) as AVG from GroupsLectures
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id

--9
select Teachers.Name as Name,Teachers.Surname as Surname,Subjects.Name as Subject from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Subjects on Lectures.SubjectId = Subjects.Id
Group by Teachers.Name,Teachers.Surname,Subjects.Name

--10
select GroupsLectures.DayOfWeek,COUNT(Lectures.Id) as Lectures from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
Group by GroupsLectures.DayOfWeek

--11
select Lectures.LectureRoom,COUNT(Departments.Id) as Departments from GroupsLectures 
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
Group by Lectures.LectureRoom

--12
select Faculties.Name,COUNT(Subjects.Id) as Subjects from GroupsLectures 
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Subjects on Lectures.SubjectId = Subjects.Id
INNER JOIN Groups on GroupsLectures.GroupId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id
Group by Faculties.Name

--13 
select Teachers.Name,Teachers.Surname,COUNT(Lectures.SubjectId) as Subjects from GroupsLectures
INNER JOIN Lectures on GroupsLectures.LectureId = Lectures.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
Group by Teachers.Name,Teachers.Surname