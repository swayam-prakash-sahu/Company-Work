use AdventureWorks2022;


--creating a table from HumanResources.Employee--
select * into Employee from [HumanResources].[Employee]


--Starting a transaction--
BEGIN TRANSACTION t1;
SAVE TRANSACTION before_delete;
DELETE FROM Employee WHERE BusinessEntityID = 79;
-- Here the id 79 has been deleted--
SELECT * FROM Employee;
ROLLBACK TRANSACTION before_delete;
--This rolls back the transaction--
COMMIT TRANSACTION t1;
--this commits the transaction--
SELECT * FROM Employee  WHERE BusinessEntityID = 79;

SELECT *FROM Employee;
--Droping a column--
ALTER TABLE Employee drop COLUMN rowguid; 

-- renaming a column
exec sp_rename 'Employee.BusinessEntityID','Employee.ID';

