create database Academy;

use Academy;

create table Departments(
Id int primary key identity(1,1),
Financing money default 0 not null check (Financing >= 0),
Name nvarchar(100) not null unique check (Name <> ''),
)

create table Faculties(
Id int primary key identity(1,1),
Dean nvarchar(max) check (Dean <> ''),
Name nvarchar(100) not null unique check (Name <> ''),
)

create table Groups(
Id int primary key identity(1,1),
Name nvarchar(10) not null unique check (Name <> ''),
Rating int check (Rating >= 0 and Rating <= 5) not null,
Year int check (Year >= 1 and Year <= 5) not null,
)

create table Teachers(
Id int primary key identity(1,1),
EmploymentDate date not null check (EmploymentDate >= '1990-01-01'),
IsAssistant bit not null default 0,
IsProfessor bit not null default 0,
Name nvarchar(max) not null check (Name <> ''),
Position nvarchar(max) not null check (Position <> ''),
Premium money default 0 not null check (Premium >= 0),
Salary money not null check (Salary > 0),
Surname nvarchar(max) not null check (Surname <> ''),
)

insert into Departments(Financing, Name) values ('3','IT Department')
insert into Departments(Financing, Name) values ('3000','IT')
insert into Departments(Financing, Name) values ('4500','Programing')
insert into Faculties(Dean, Name) values ('Fuad', 'Software')
insert into Faculties(Dean, Name) values ('Nihad', 'Computer Science')
insert into Groups(Name, Rating, Year) values ('P251','4','3')
insert into Groups(Name, Rating, Year) values ('P253','2','5')
insert into Teachers(EmploymentDate, IsAssistant , IsProfessor , Position ,Name, Premium, Salary, Surname) values ('11.11.1999', '0', '1' , 'System administrator' ,'Yusif' , '200' , '8000' , 'Bayramov')
insert into Teachers(EmploymentDate, IsAssistant , IsProfessor , Position ,Name, Premium, Salary, Surname) values ('11.11.2000', '1', '1' , 'System administrator' ,'Fuad' , '650' , '400' , 'Zeynalov')
insert into Teachers(EmploymentDate, IsAssistant , IsProfessor , Position ,Name, Premium, Salary, Surname) values ('01.01.2023', '1', '0' , 'System administrator' ,'Nihad' , '150' , '3000' , 'Salayev')
-- 1
select * from Departments order by Id desc;
-- 2
select Name as 'Group name', Rating as 'Group Rating' from Groups 
-- 3
select Surname, Premium/Salary * 100 as 'Percen of Premium', (Salary + Premium)/Salary * 100 as 'Percentage of Total Salary'from Teachers
-- 4
select 'The dean of faculty' + Name + ' is ' + Dean as FacultyInformation from Faculties
-- 5
select Surname from Teachers where IsProfessor = 1 and Salary > 1050;
-- 6
select Name from Departments where Financing < 11000 or Financing > 25000;
-- 7
select Name from Faculties where Name != 'Computer Science';
-- 8
select Surname from Teachers where IsProfessor = 0;
-- 9
select Surname from Teachers where 160 < Premium and Premium < 550;
-- 10
select Surname from Teachers where IsAssistant = 1;
-- 11
select Surname from Teachers where EmploymentDate < '01.01.2000';
-- 12
select Name as 'Name of Department' from Departments where Name < 'Software Development' order by Name;
-- 13
select Surname from Teachers where IsAssistant = 1 and (Salary + Premium) <= 1200;
-- 14
select Name from Groups where Year = 5 and (Rating >= 2 and Rating <= 4); 
-- 15
select Surname from Teachers where Salary < 550 or Premium < 200;