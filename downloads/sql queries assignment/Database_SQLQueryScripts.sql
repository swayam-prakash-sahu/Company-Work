CREATE TABLE EmployeeProfiles (
    EmployeeID INT PRIMARY KEY NOT NULL,
    EmployeeName VARCHAR(50) NOT NULL,
    --Department VARCHAR(100),
    --Designation VARCHAR(100),  
    EmployeeProfilePic varchar(255),
    EmploymentStatus VARCHAR(20) CHECK (EmploymentStatus IN ('Active', 'Terminated')),
	Created_Date DateTime, 
	Created_By int, 
	Updated_Date DateTime, 
	Updated_By int 
);


CREATE TABLE ContactInformation (
    ContactID INT PRIMARY KEY,
    EmployeeID INT,
    Email VARCHAR(100),
    Phone VARCHAR(20),
	OfficeLocation VARCHAR(50),
    SocialMediaProfiles VARCHAR(255),  
    FOREIGN KEY (EmployeeID) REFERENCES EmployeeProfiles(EmployeeID) ON DELETE CASCADE
);


CREATE TABLE UserAuthentication (
    UserID INT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(255) NOT NULL,
	);

EXEC sp_rename 'UserAuthentication.Role', 'RoleID', 'COLUMN';

ALTER TABLE UserAuthentication
ALTER COLUMN RoleID INT;

ALTER TABLE UserAuthentication
ADD CONSTRAINT FK_UserAuthentication_Role
FOREIGN KEY (RoleID) REFERENCES Role(RoleID);

-----------

select * from UserAuthentication;

select * from ContactInformation;

select * from EmployeeProfiles;

SELECT * FROM Department;
SELECT * FROM Designation;
SELECT * FROM Manager;
SELECT * FROM Role;


ALTER TABLE UserAuthentication ADD IsActive BIT;

-----
ALTER TABLE EmployeeProfiles
ADD DesignationID INT,
    DeptID INT,
	ManagerID INT,
	RoleID INT,
    EmployeeProfilePic varchar(255),
    EmploymentStatus VARCHAR(20) CHECK (EmploymentStatus IN ('Active', 'Terminated')),
	Created_Date DateTime, 
	Created_By int, 
	Updated_Date DateTime, 
	Updated_By int ;
----

ALTER TABLE Role
ADD Created_Date Datetime,
    Created_By int,
    Updated_Date Datetime,
    Updated_By int;


Drop Table EmployeeProfiles;

ALTER TABLE UserAuthentication
DROP CONSTRAINT CK__UserAuthen__Role__3E52440B;

ALTER TABLE UserAuthentication
DROP CONSTRAINT CK__UserAuthen__Role__3E52440B;

EXEC sp_rename 'UserAuthentication.Role', 'RoleID', 'COLUMN';


ALTER TABLE UserAuthentication
DROP COLUMN Role;




--On the basis of EmployeeProfiles,UserAuthentication and ContactInformation table 
--build 4 more tables named as Role, Manager, Designation and Department with the columns as specified below and its corresponding datatypes

-- Create table Department
CREATE TABLE Department (
    DeptID INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

-- Populate Department table
INSERT INTO Department (DeptID, DepartmentName)
VALUES (1, 'Salesforce'),
       (2, 'Microsoft'),
       (3, 'SAP'),
       (4, 'DataAnalysis');

-- Create table Designation
CREATE TABLE Designation (
    DesignationID INT PRIMARY KEY,
    DesignationName VARCHAR(100) NOT NULL
);

-- Populate Designation table with four types of designations
INSERT INTO Designation (DesignationID, DesignationName)
VALUES (1, 'Manager'),
       (2, 'Engineer'),
       (3, 'Analyst'),
       (4, 'Consultant');

-- Create table Manager
CREATE TABLE Manager(
    EmployeeID INT PRIMARY KEY,
    ManagerID INT,
    FOREIGN KEY (EmployeeID) REFERENCES EmployeeProfiles(EmployeeID),
    FOREIGN KEY (ManagerID) REFERENCES EmployeeProfiles(EmployeeID)
);

-- Create table Role
CREATE TABLE Role (
    RoleID INT PRIMARY KEY,
    RoleName VARCHAR(20) NOT NULL
);

-- Role table with Admin and Employee roles
INSERT INTO Role (RoleID, RoleName)
VALUES (1, 'Admin'),
       (2, 'Employee');




SELECT * FROM Department;
SELECT * FROM Designation;
SELECT * FROM Manager;
SELECT * FROM Role;



-- Add DesignationID column
ALTER TABLE EmployeeProfiles
ADD DesignationID INT,
FOREIGN KEY (DesignationID) REFERENCES Designation(DesignationID);

-- Add DeptID column
ALTER TABLE EmployeeProfiles
ADD DeptID INT,
FOREIGN KEY (DeptID) REFERENCES Department(DeptID);

-- Add ManagerID column
ALTER TABLE EmployeeProfiles
ADD ManagerID INT,
FOREIGN KEY (ManagerID) REFERENCES Manager(EmployeeID);

-- Add RoleID column
--ALTER TABLE EmployeeProfiles
--ADD RoleID INT,
--FOREIGN KEY (RoleID) REFERENCES Role(RoleID);

-- Add EmployeeProfilePic column
ALTER TABLE EmployeeProfiles
ADD EmployeeProfilePic VARCHAR(255);

-- Add EmploymentStatus column
ALTER TABLE EmployeeProfiles
ADD EmploymentStatus VARCHAR(20) CHECK (EmploymentStatus IN ('Active', 'Terminated'));

-- Add Created_Date column
ALTER TABLE EmployeeProfiles
ADD Created_Date DATETIME;

-- Add Created_By column
ALTER TABLE EmployeeProfiles
ADD Created_By INT;

-- Add Updated_Date column
ALTER TABLE EmployeeProfiles
ADD Updated_Date DATETIME;

-- Add Updated_By column
ALTER TABLE EmployeeProfiles
ADD Updated_By INT;


-- Find the name of the foreign key constraint
SELECT OBJECT_NAME(constraint_object_id) AS ConstraintName
FROM sys.foreign_key_columns
WHERE parent_object_id = OBJECT_ID('Manager')
AND parent_column_id = (SELECT column_id FROM sys.columns WHERE name = 'EmployeeID' AND object_id = OBJECT_ID('Manager'));

-- Once you have the constraint name, use the following statement to drop the constraint
ALTER TABLE Manager
DROP CONSTRAINT FK__Manager__Employe__4CA06362; 
