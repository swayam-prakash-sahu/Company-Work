CREATE PROCEDURE GetEmployeeDetails AS BEGIN
SELECT 
    e.BusinessEntityID,
    p.FirstName,
    p.LastName,
    a.AddressLine1,
    a.City,
    a.StateProvinceID
    FROM HumanResources.Employee e
    -- created a stored procedure to get employee details
    INNER JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID
    LEFT JOIN Person.Address a ON p.BusinessEntityID = a.AddressID;
    -- executed joins
END;
EXEC GetEmployeeDetails;
