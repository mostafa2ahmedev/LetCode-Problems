/* Write your T-SQL query statement below */

Delete  P
from Person P
where P.id Not in (
    select Min(id)
    from Person P
    Group by P.email
)