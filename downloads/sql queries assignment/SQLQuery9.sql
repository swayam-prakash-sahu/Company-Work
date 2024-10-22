CREATE PROCEDURE GetProductByID
    @ProductID INT
AS
BEGIN
    SELECT *
    FROM Production.Product
    WHERE ProductID = @ProductID;
END;