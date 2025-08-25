/* Write your T-SQL query statement below */
select  C.* 
from Cinema C 
where C.id %2 != 0 and C.description !='boring'
order by C.rating desc