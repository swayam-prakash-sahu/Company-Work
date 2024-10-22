Create table EmployeeTbl(
Emp_ID int NOT NULL,
Emp_Name varchar(20),
Job varchar(20),
Salary decimal(20),
PRIMARY KEY (Emp_ID));

select * from EmployeeTbl;

insert into EmployeeTbl values
(1, 'ANJALI', 'Developer', 21500),
(2, 'MEERA', 'Analyst',30000),
(3, 'VENU', 'Architect',12000),
(4, 'SURAJ', 'Manager',50000),
(5, 'GOPAL', 'Researcher',80000);