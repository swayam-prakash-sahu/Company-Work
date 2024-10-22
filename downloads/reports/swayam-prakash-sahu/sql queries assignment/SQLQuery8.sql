CREATE TRIGGER trgAfterInsert
ON Sales.SalesOrderDetail
AFTER INSERT
AS
BEGIN
    -- Your trigger logic here
    -- For example, logging the inserted data
    INSERT INTO dbo.LogTable (Event, DateLogged)
    VALUES ('New row inserted into SalesOrderDetail', GETDATE())
END;