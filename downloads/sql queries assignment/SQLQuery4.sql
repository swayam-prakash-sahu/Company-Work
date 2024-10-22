SELECT productid, sum(quantity) AS total_quantity
FROM production.productinventory
WHERE shelf IN ('A','C','H')
GROUP BY productid
HAVING SUM(quantity)>500
ORDER BY productid;