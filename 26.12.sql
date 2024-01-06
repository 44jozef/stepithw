create database Academy;

use Academy;


create table Curators(
 Id int primary key identity(1,1) NOT NULL,
 Name nvarchar(MAX)  check(Name <> N''),
 Surname nvarchar(MAX) check(Surname <> N''),
)



create table Faculties(
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
 Year int NOT NULL CHECK(Year >= 1 and Year <= 5),
 DepartamentId int foreign key references Departments(Id)
)


create table GroupCurators(
 Id int primary key identity(1,1) NOT NULL,
 CuratorId int foreign key references Curators(Id),
 GroupId int foreign key references Groups(Id)

)

create table Lectures (
 Id int primary key identity(1,1) NOT NULL,
 LectureRoom nvarchar(100) check (LectureRoom <> N''),
 SubjectId int foreign key references Subjects(Id),
 TeacherId int foreign key references Teachers(Id)

)

create table GroupsLectures (
 Id int primary key identity(1,1) NOT NULL,
 GroupId int foreign key references Groups(Id),
 LectureId int foreign key references Lectures(Id)

)

insert into Curators(Name,Surname) Values (N'Tamila',N'Gasanova')



insert into Teachers (Name,Salary,Surname) Values (N'Elvin',2200,N'Azimov')
insert into Teachers (Name,Salary,Surname) Values (N'Samantha',1500,N'Adams ')


insert into Subjects(Name) Values (N'SQL')
insert into Subjects(Name) Values (N'PC Build')
insert into Subjects(Name) Values (N'Database Theory')


insert into Faculties(Financing,Name) Values (5000,N'Computer Science')
insert into Faculties(Financing,Name) Values (3500,N'Enginer')


insert into Departments(Financing,Name,FacultyId) Values (7800,N'Step',1)
insert into Departments(Financing,Name,FacultyId) Values (6700,N'EU',2)


insert into Groups(Name,Year,DepartamentId) Values (N'FBAS 3_22_11',3,1)
insert into Groups(Name,Year,DepartamentId) Values (N'P107',3,1)
insert into Groups(Name,Year,DepartamentId) Values (N'A309',5,2)




insert into Lectures(LectureRoom,SubjectId,TeacherId) Values (N'A1',1,1)
insert into Lectures(LectureRoom,SubjectId,TeacherId) Values (N'C1',2,2)
insert into Lectures(LectureRoom,SubjectId,TeacherId) Values (N'B103',3,2)



insert into GroupCurators(CuratorId,GroupId) Values (1,1)



insert into GroupsLectures(GroupId,LectureId) Values (1,1)
insert into GroupsLectures(GroupId,LectureId) Values (2,2)
insert into GroupsLectures(GroupId,LectureId) Values (3,3)



select * from GroupsLectures
select * from Lectures


drop table GroupCurators
drop table Lectures
drop table Subjects
drop table Faculties
drop table Curators
drop table GroupsLectures
drop table Teachers
drop table Groups
drop table Departments



--1 

select * from Teachers
select * from Groups

--2

select Name from Faculties
select Departments.Financing from Departments
INNER JOIN Faculties on Departments.Id = Faculties.id
where Departments.Financing > Faculties.Financing

--3

select Groups.Name as GroupName, Curators.Name as CuratorName from GroupCurators
INNER JOIN Groups on GroupCurators.Id = Groups.Id
INNER JOIN Curators on GroupCurators.Id = Curators.Id

--4

select Groups.Name as [Group],Teachers.Surname as Surname from GroupsLectures
INNER JOIN Lectures on GroupsLectures.Id = Lectures.Id
INNER JOIN Teachers on Lectures.id = Lectures.Id
INNER JOIN Groups on GroupsLectures.Id = Groups.Id
WHERE Groups.Name = N'P107'

--5


select Teachers.Surname as TeacherSurname,Faculties.Name as Faculty from GroupsLectures
INNER JOIN Lectures on GroupsLectures.Id = Lectures.Id
INNER JOIN Subjects on Lectures.Id = Subjects.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Groups on GroupsLectures.LectureId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id


--6

select Departments.Name as Department,Groups.Name as [Group] from Groups
INNER JOIN Departments on Groups.Id = Departments.Id


--7

select Subjects.Name as N'Subject',Teachers.Name as N'Teacher'  from Lectures
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Subjects on Lectures.SubjectId = Subjects.Id
Where Teachers.Name = N'Samantha' and Teachers.Surname = N'Adams'

--8

select Departments.Name as Department,Subjects.Name as Subject from GroupsLectures
INNER JOIN Lectures on GroupsLectures.Id = Lectures.Id
INNER JOIN Subjects on Lectures.SubjectId = Subjects.Id
INNER JOIN Groups on  Lectures.SubjectId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
Where Subjects.Name = N'Database Theory'


--9

select Groups.Name from GroupsLectures
INNER JOIN Lectures on GroupsLectures.Id = Lectures.Id
INNER JOIN Subjects on Lectures.Id = Subjects.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Groups on GroupsLectures.LectureId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id
Where Faculties.Name = N'Computer Science'

--10 

select Faculties.Name as Faculty,Groups.Year as Year from Groups
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id
Where Groups.Year = 5

--11

Select Teachers.Name as TeacherName,Teachers.Surname as TeacherSurname,Subjects.Name as Subjet,Groups.Name as [Group] from GroupsLectures
INNER JOIN Lectures on GroupsLectures.Id = Lectures.Id
INNER JOIN Subjects on Lectures.Id = Subjects.Id
INNER JOIN Teachers on Lectures.TeacherId = Teachers.Id
INNER JOIN Groups on GroupsLectures.LectureId = Groups.Id
INNER JOIN Departments on Groups.DepartamentId = Departments.Id
INNER JOIN Faculties on Departments.FacultyId = Faculties.Id
Where Lectures.LectureRoom = N'B103'