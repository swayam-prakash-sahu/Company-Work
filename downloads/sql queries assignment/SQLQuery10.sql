select * from HumanResources.Employee
where MaritalStatus = 'M'
and Gender = 'F'


select * from HumanResources.Employee
where VacationHours < 30


select Firstname, Lastname,
Case persontype when 'IN' then 'Individual Custonmer'
when 'EM' then 'Employee'
when 'SP' then 'Sales Person'
when 'SC' then 'Store Contact'
when 'VC' then 'Vendor Contact'
when 'GC' then 'General Contact'
else 'Unknown Person Type' end TypeOfContact
from person.Person


