
/*
create table Employee_backup
(
EmpId numeric, FirstName varchar(10), LastName varchar(20), Email varchar(30), Salary numeric, DeptId numeric, HireDate date
);
*/


-- insert into Employee_backup select * from Employee where EmpId <= 3;

-- select * from Employee_backup;


/*
insert into Employee_backup values
(6, 'Abdul', 'K', 'abdul@test.com', 25000, 70, '2020-07-14'),
(7, 'Swati', 'Karia', 'swati@test.com', 22000, 30, '2020-09-18');
*/

select * from Employee_backup;

alter table Employee_backup add DeptId numeric;

truncate table Employee_backup;

select * from Employee intersect select * from Employee_backup;

select * from Employee_backup;

drop table Employee_backup;

select * from Employee where salary > 15000 intersect select * from Employee_backup;

select * from Employee_backup minus select * from Employee;

select * from Employee union select * from Employee_backup;

select * from Employee where salary > 20000 union select * from Employee_backup where salary > 22000;

select * from Employee union all select * from Employee_backup;

select distinct DeptId from Employee;

select count(distinct DeptId) from Employee;

select * from Employee where DeptId = any(select DeptId from Department where Name = 'Finance' or Name = 'HR');

-- SQL Aggregate functions

select avg(salary) as AvgSalary from Employee;

select sum(salary) as Sum from Employee;

select max(salary) as MaxSalary from Employee;

select min(Salary) as MinSalary from Employee;





