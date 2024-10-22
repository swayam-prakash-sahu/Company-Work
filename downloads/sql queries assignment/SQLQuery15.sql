MERGE INTO EmpTarget t

USING EmpSource src

ON t.EmpId = src.EmpId

WHEN MATCHED THEN 

    UPDATE SET T.EmpName = src.EmpName

WHEN NOT MATCHED by TARGET THEN

  INSERT (EmpId, EmpName, EmpSalary) VALUES (src.EmpId, src.EmpName, src.EmpSalary)

WHEN NOT MATCHED by source THEN

	DELETE;
 
 
	select * from EmpSource

