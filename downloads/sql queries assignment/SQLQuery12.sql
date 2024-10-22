MERGE INTO [AdventureWorks2022].[Sales].[Currencytest] ct -- our test table
USING [AdventureWorks2022].[Sales].[Currency] c --source table

ON ct.CurrencyCode = c.CurrencyCode  

WHEN MATCHED   
THEN UPDATE SET
 ct.name = c.name,
 ct.ModifiedDate = 'feb 28, 2024' --the update date 

WHEN NOT MATCHED 
THEN INSERT  VALUES(c.CurrencyCode,c.Name, 'feb 29 2024') --insert date 

WHEN NOT MATCHED BY SOURCE 
THEN DELETE; --if you have data in the destination you want to delete it

select * from [Sales].[Currencytest];

select * from [Sales].[Currency];
