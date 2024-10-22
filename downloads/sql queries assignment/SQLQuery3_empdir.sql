SELECT TOP (1000) [ContactId]
      ,[EmployeeId]
      ,[Email]
      ,[Phone]
      ,[OfficeLocation]
      ,[SocialMediaProfiles]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[UpdatedDate]
      ,[UpdatedBy]
  FROM [EmployeeDirectoryDB].[dbo].[ContactInformations]
   select e.employeeName, e.employeeId, c.phone, c.Officelocation, c.socialmediaprofiles from contactInformations c
   inner join EmployeeProfiles e
   on c.employeeid=e.employeeid;