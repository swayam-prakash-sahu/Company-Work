

## Here you can find my sql practice queries.

### Some syntax of SQL


| S.NO | TASK | SYNTAX|
|------|------|-------|
|1| TO CREATE A DATABASE | CREATE DATABASE Database_name; |
|2| TO USE EXISTING DATABASE | USE Datbase_name; |
|3| TO CREATE A TABLE | CREATE TABLE Table_name (Column_name Data_Type Key_Type [NULL/NOT NULL], ... ); |
|4| TO CREATE A TABLE FROM AN EXISTING TABLE |  CREATE TABLE Table_Name AS SELECT * FROM EMPLOYEE ( EXISTING TABLE NAME ); |
|5| TO ONLY COPY THE STRUCTURE OF THE TABLE | CREATE TABLE Table_Name AS SELECT * FROM Employee WHERE 1=2; (1=2 RETURNS nothing ) |
|6| TO ALTER A TABLE COLUMN LIKE ADD OR REMOVE | ALTER TABLE table_name ADD column_name1 data_type,     column_name2 data_type,...;|
|7| TO RENAME A COLUMN | EXEC sp_rename 'Employee.PinCode', 'Employee.ZipCode';|
|8| TO ALTER A COLUMN | ALTER TABLE Employee ALTER COLUMN PinCode integer; |
|9| TO DROP COLUMN | ALTER TABLE Employee DROP COLUMN Address; ALTER TABLE Employee DROP COLUMN Address, City, Pincode; -- deletes multiple columns |
|10| TO RENAME A TABLE | sp_rename Employee, emp; |
|11| TO DROP A TABLE | DROP TABLE Employee; |
|12| TO INSERT DATA IN A TABLE | INSERT INTO Employee VALUES(1,'John','King','john.king@abc.com','123.123.1834', 33000); |
|13| TO UPDATE A RECORD | UPDATE Employee SET email = 'jking@test.com' WHERE EmpId = 1; |
|14| TO DELETE A RECORD | DELETE FROM Employee WHERE EmpId = 4; |
|15| TO TRUNCATE A TABLE | TRUNCATE TABLE Employee; |
|16| TO ASSIGN A NULL VALUE TO A COLUMN | SELECT * FROM Employee WHERE PhoneNo IS NULL; SELECT * FROM Employee WHERE Email IS NOT NULL; |
|17| TO MERGE TWO TABLES INTO THIRD TABLE |MERGE INTO Employee TARGET USING Consultant SOURCE ON TARGET.EmpId = SOURCE.EmpId WHEN MATCHED THEN UPDATE TARGET.FirstName = SOURCE.FirstName, TARGET.LastName = SOURCE.LastName WHEN NOT MATCHED THEN INSERT into Employee(EmpId, FirstName, LastName) VALUES(SOURCE.EmpId, SOURCE.FirstName, SOURCE.LastName);|
|18| TO SELECT A RECORD | SELECT column1, column2,...columnN FROM table_name WHERE conditions |
|19| GROUP | SELECT column1, column2,...columnN FROM table_name [WHERE] [GROUP BY column1, column2...columnN] [HAVING] [ORDER BY]|
---

### Some operators ( CAN BE USED FOR WHERE CONDITION )

| S.NO | Operator | Description |
|------|----------|-------------|
| 1 | =	    |  Equal. |
| 2 | >	    |  Greater than. |
| 3 | <	    |  Less than. |
| 4 | >=	    |  Greater than or equal. |
| 5 | <=	    |  Less than or equal. |
| 6 | <> or !=|	Not equal. In some databases, the != is used to compare values which are not equal. |
| 7 | BETWEEN	|  Between some range. |
| 8 | LIKE	|  Search for a pattern. |
| 9 | IN	    |  To specify multiple possible values for a column. |
---