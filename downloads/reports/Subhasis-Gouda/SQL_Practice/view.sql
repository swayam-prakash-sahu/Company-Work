use AdventureWorks2022;
CREATE VIEW EmployeeDetails AS SELECT 
    BusinessEntityID AS EmployeeID,
    NationalIDNumber,
    LoginID,
    JobTitle,
    BirthDate,
    MaritalStatus,
    Gender,
    HireDate
FROM  HumanResources.Employee;

SELECT * FROM EmployeeDetails;