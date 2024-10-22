Select * from Employee;

Select * from Designation;

Insert into Designation values(1, 'Developer');

Insert into Designation values(2, 'Manager');

Alter table Employee 
Add M_ID Int;

UPDATE Employee
SET M_ID = 6 WHERE EMPID = 10;


SELECT E1.EMPNAME
FROM Employee E1
INNER JOIN Employee E2 ON E1.M_ID = E2.EMPID
WHERE E1.EMPSALARY > E2.EMPSALARY;












