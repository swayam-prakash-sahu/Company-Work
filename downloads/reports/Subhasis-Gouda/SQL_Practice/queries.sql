use sg;
select * into scholar from Employee;
select * from scholar;
alter table scholar ADD scholarship INTEGER ;
select * from scholar;
exec sp_rename 'scholar.EmployeeID', 'StudentId';
select * from scholar;
ALTER TABLE scholar ALTER COLUMN FirstName varchar(50); 
ALTER TABLE scholar drop COLUMN City, Experience; 
select * from scholar;
sp_rename scholar,students;
select * from students;

UPDATE students set scholarship=3000;