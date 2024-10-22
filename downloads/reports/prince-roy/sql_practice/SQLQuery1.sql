create table Employee(EmpId numeric(2), FirstName varchar(20), LastName varchar(20), Email varchar(30), Salary numeric(9), DeptId numeric(2));


insert into Employee values
(1, 'John', 'King', 'john.king@abc.com', 24000, 10),
(2, 'James', 'Bond', '', 17000, 20),
(3, 'Neena', 'Kochhar', 'neena@test.com', 15000, 20),
(4, 'Lex', 'De Haan', 'lex@test.com', 9000, 30),
(5, 'Amit', 'Patel', '', 60000, 30),
(6, 'Abdul', 'Kalam', 'abdul@test.com', 4800, 40);


select * from Employee;

-- delete Employee;

update Employee set email = 'jking@test.com' where EmpId=1;

update Employee set email = 'lex.de@test.com', salary = 10000 where empid = 4;

select * from Employee where email is not null;

create table Department(DeptId numeric(2), Name varchar(10));

insert into Department values(1, 'Finance'), (2, 'HR');

select * from Department;

select DeptId, count(EmpId) as TotalEmployees from dbo.Employee group by DeptId;

select DeptId, count(EmpId) as TotalEmployees from dbo.Employee group by DeptId having count(DeptId) > 1;

update Department set DeptId = 10 where Name = 'Finance';

update Department set DeptId = 20 where Name = 'HR';

select emp.EmpId, emp.FirstName, emp.LastName, dept.Name from Employee emp inner join Department dept on emp.DeptId = dept.DeptId;

update Employee set email = null where EmpId = 2 or EmpId = 5;

select emp.empid, emp.FirstName, dept.DeptID, dept.Name from Employee emp left join Department dept on emp.DeptId = dept.DeptId;

select emp.empid, emp.FirstName, dept.DeptID, dept.Name from Department dept left join Employee emp on dept.DeptId = emp.DeptId;

select emp.EmpId, emp.FirstName, dept.DeptId, dept.Name from Employee emp right join Department dept on emp.DeptId = dept.DeptId;

select emp.EmpId, emp.FirstName, dept.DeptID, dept.Name from Department dept right join Employee emp on emp.DeptId = dept.DeptId;

insert into Department values(70, 'SAP');

select emp.EmpId, emp.FirstName, dept.DeptID, dept.Name from Department dept full join Employee emp on emp.DeptId = dept.DeptId;

alter table Employee add HireDate date;

update Employee set HireDate='2018-12-25' where EmpId=1;
update Employee set HireDate='2018-12-25' where EmpId=2;
update Employee set HireDate='2017-08-25' where EmpId=3;
update Employee set HireDate='2020-12-10' where EmpId=4;
update Employee set HireDate='2019-06-03' where EmpId=5;
update Employee set HireDate='2021-10-17' where EmpId=6;

select * from Employee where salary between 24000 and 60000;
select * from Employee where FirstName between 'j%' and 'n%';

select * from Employee where DeptId in (select DeptId from Department);

select * from Employee where EmpId not in (1, 3, 5);

select * from Employee where FirstName like 'a%';

select * from Employee where FirstName like '%n';

select * from Employee where FirstName like '%u%';

select * from Employee where FirstName like '__h_';

select * from Employee where FirstName like 'A[i, t, m]';

select * from Employee where FirstName not like 'j%';

