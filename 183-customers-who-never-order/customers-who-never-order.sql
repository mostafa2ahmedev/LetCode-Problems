/* Write your T-SQL query statement below */
select C.name as Customers 
from Customers C left join Orders O
On C.id = O.customerId 
where O.customerId is null