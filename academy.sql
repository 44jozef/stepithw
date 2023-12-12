create database gagulik;

use gagulik;

create table groups (
    id int primary key identity(1,1) not null,
    name nvarchar(10) not null unique,
    rating int not null check (rating >= 0 and rating <= 5),
    year int not null check (year >= 1 and year <= 5)
);

create table departments (
    id int primary key identity(1,1) not null,
    financing money default 0 not null check (financing >= 0),
    name nvarchar(100) not null unique
);

create table faculties (
    id int primary key identity(1,1) not null,
    name nvarchar(100) not null unique
);

create table teachers (
    id int primary key identity(1,1) not null,
    name nvarchar(max) not null,
	surname nvarchar(max) not null,
	employmentdate date not null ,
    premium smallmoney default 0 not null check (premium >= 0),
    salary smallmoney not null check (salary > 0),
);
insert into groups(name, rating, year) values ('Yusif','5','4')
insert into departments(name,financing) values ('Yusif','0')
insert into faculties(name) values ('FBAS3_22_11')
insert into teachers(name,surname,employmentdate,premium,salary) values ('Yusuf','Bayramov','11-07-2016','1000','6000')

select * 
from groups,departments,faculties,teachers;


