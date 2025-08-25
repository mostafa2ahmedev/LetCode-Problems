/* Write your T-SQL query statement below */
select  P.email 
from Person P
Group by P.email
Having Count(*) > 1