select * from person.person
left join sales.PersonCreditCard
on PersonCreditCard.BusinessEntityID = person.BusinessEntityID
left join sales. CreditCard
on CreditCard.CreditCardID = PersonCreditCard.CreditCardID
where PersonCreditCard.BusinessEntityID is null