SELECT productid, productnumber, name as producName
FROM production.product
WHERE sellstartdate IS NOT NULL
AND production.product.productline= 'T'
ORDER BY name;