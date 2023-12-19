CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    GPA FLOAT
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50),
    Difficulty INT,
    Credits INT
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    Grade FLOAT
);

INSERT INTO Students (StudentID, FirstName, LastName, Age, GPA)
VALUES
    (1, 'Иван', 'Иванов', 20, 3.5),
    (2, 'Мария', 'Петрова', 22, 3.8),
    (3, 'Александр', 'Сидоров', 21, 3.2),
    (4, 'Екатерина', 'Козлова', 23, 3.9),
    (5, 'Дмитрий', 'Федоров', 20, 3.0);

INSERT INTO Courses (CourseID, CourseName, Difficulty, Credits)
VALUES
    (101, 'Математика', 4, 3),
    (102, 'Физика', 3, 4),
    (103, 'Литература', 2, 3),
    (104, 'История', 2, 3),
    (105, 'Биология', 3, 4);

INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, Grade)
VALUES
    (1, 1, 101, 3.7),
    (2, 1, 102, 4.0),
    (3, 2, 101, 3.9),
    (4, 3, 103, 3.5),
    (5, 3, 105, 3.2),
    (6, 4, 102, 3.8),
    (7, 4, 104, 4.0),
    (8, 5, 105, 3.1),
    (9, 5, 101, 3.0);

select AVG(Grade) from Enrollments where CourseID = 101;

select MAX(Age) from Students where GPA >= 3.5;

select Count(CourseID) from Courses where Difficulty > 3;

select CourseName,AVG(Grade) as AverageGrade from Enrollments e join Courses c on e.CourseID = c.CourseID group by CourseName;

select MAX(Difficulty) from Courses; -- хотел чтоб выводилось имя курса но немного не вдупил
