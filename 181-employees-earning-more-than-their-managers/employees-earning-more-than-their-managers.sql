/* Write your T-SQL query statement below */
select E.name as Employee
from Employee E inner join Employee M
On E.managerId  =  M.id   
where E.salary > M.salary