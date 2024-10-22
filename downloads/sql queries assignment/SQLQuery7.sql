SELECT ContactTypeID, Name
    FROM Person.ContactType
    WHERE Name LIKE '%Manager%'
    ORDER BY Name DESC;