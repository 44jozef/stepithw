CREATE DATABASE Academy

USE Academy;



create table People(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL,
[Surname] nvarchar(30) NOT NULL,
[Age] int NOT NULL check (Age >= 14 and Age < 100)
);


create table Employee(
[Id] int primary key identity(1, 1),
[Salary] smallmoney NOT NULL check ([Salary] >= 300),
[Experience] int NOT NULL check ([Experience] >= 0)
);


create table Faculty(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL
);


create table Students(
[Id] int primary key identity(1, 1),
[PersonId] int foreign key references People(Id),
[GPA] int NOT NULL check ([GPA] >= 0 and [GPA] <= 12)
);


create table Teachers(
[Id] int primary key identity(1, 1),
[PersonId] int foreign key references People(Id),
[EmployeeId] int foreign key references Employee(Id)
);


create table Groups(
[Id] int primary key identity(1, 1),
[Name] nvarchar(30) NOT NULL,
[Course] int NOT NULL check ([Course] >= 1 and [Course] <= 6),
[FacultyId] int foreign key references Faculty(Id)
);

create table GroupData(
[Id] int primary key identity(1, 1),
[StudentId] int foreign key references Students(Id),
[GroupId] int foreign key references Groups(Id)
);

create table StudyPlan(
[Id] int primary key identity(1, 1),
[TeacherId] int foreign key references Teachers(Id),
[GroupId] int foreign key references Groups(Id)
);


INSERT INTO People(Name,Surname,Age) VALUES  (N'Elvin',N'Azimov',23)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Vagif',N'Aliev',16)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Yusif',N'Melikov',15)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Yusif',N'Bayramov',22)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Magomed',N'Farmanov',24)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Baxtiyar',N'Mirzoev',17)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Anver',N'Mamedov',19)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Magsudlu',N'Afgan',16)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Xelil',N'Orudjlu',15)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Nilay',N'Alieva',16)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Murad',N'Efendiyev',16)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Gariba',N'Dadashova',19)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Alina',N'Orudjova',16)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Eldeniz',N'Yoluchev',19)
INSERT INTO People(Name,Surname,Age) VALUES  (N'Tatyana',N'Ermakova',25)



INSERT INTO Employee(Salary,Experience) VALUES (600,5)
INSERT INTO Employee(Salary,Experience) VALUES (400,2)


INSERT INTO Faculty(Name) VALUES (N'SQL')


INSERT INTO Students(PersonId,GPA) VALUES (2,11)
INSERT INTO Students(PersonId,GPA) VALUES (3,10)
INSERT INTO Students(PersonId,GPA) VALUES (4,12)
INSERT INTO Students(PersonId,GPA) VALUES (5,12)
INSERT INTO Students(PersonId,GPA) VALUES (6,11)
INSERT INTO Students(PersonId,GPA) VALUES (7,11)
INSERT INTO Students(PersonId,GPA) VALUES (8,10)
INSERT INTO Students(PersonId,GPA) VALUES (9,11)
INSERT INTO Students(PersonId,GPA) VALUES (10,10)
INSERT INTO Students(PersonId,GPA) VALUES (11,11)
INSERT INTO Students(PersonId,GPA) VALUES (12,10)
INSERT INTO Students(PersonId,GPA) VALUES (13,12)
INSERT INTO Students(PersonId,GPA) VALUES (14,12)
INSERT INTO Students(PersonId,GPA) VALUES (15,12)


INSERT INTO Teachers(PersonId,EmployeeId) VALUES (1,1)


INSERT INTO Groups(Name,Course,FacultyId) VALUES (N'FBAS_3_11_22',2,1)

INSERT INTO GroupData(StudentId,GroupId) VALUES (1,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (2,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (3,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (4,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (5,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (6,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (7,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (8,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (9,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (10,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (11,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (12,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (13,1)
INSERT INTO GroupData(StudentId,GroupId) VALUES (14,1)


INSERT INTO StudyPlan(TeacherId,GroupId) VALUES (1,1)

