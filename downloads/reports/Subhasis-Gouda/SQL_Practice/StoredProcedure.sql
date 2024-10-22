USE AdventureWorks2022;
-- to get employee details by comparing the job title
CREATE PROCEDURE GetEmployeeByJobTitle @Jobtitle varchar(60)
AS BEGIN SELECT 
    BusinessEntityID,
    NationalIDNumber,
    LoginID,JobTitle,
    BirthDate,
    MaritalStatus,
    Gender,
    HireDate
FROM HumanResources.Employee WHERE JobTitle = @Jobtitle; END;

EXEC GetEmployeeByJobTitle @Jobtitle = 'Chief Executive Officer';
