-- Active: 1717616006091@@blyw28avltsxk3qcaz3d-mysql.services.clever-cloud.com@3306@blyw28avltsxk3qcaz3d
CREATE TABLE Students(
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(125),
    BirthDate DATE,
    Address VARCHAR(125),
    Email VARCHAR(125) UNIQUE
);

DROP Table `Students`;

CREATE TABLE Enrollments (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Date DATE,
    Status ENUM("Paid", "pending payment", "Canceled"),
    StudentId INTEGER(10),
    CourseId INTEGER(10),
    Foreign Key (StudentId) REFERENCES Students(Id),
    Foreign Key (CourseId) REFERENCES Courses(Id)
);

DROP TABLE `Enrollments`;

CREATE TABLE Courses (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125),
    Description TEXT,
    Schedule VARCHAR(125),
    Duration VARCHAR(125),
    Capacity INTEGER(10),
    TeacherId INTEGER(10),
    Foreign Key (TeacherId) REFERENCES Teachers(Id)
);

CREATE TABLE Teachers (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(125),
    Specialty VARCHAR(125),
    Phone VARCHAR(25),
    Email VARCHAR(125) UNIQUE,
    YearsExperience INTEGER
);