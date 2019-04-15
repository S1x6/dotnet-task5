select e.Name, sum(p.Money) projectSum from Employees e left join Projects p on e.EmployeeId = p.EmployeeId 
group by p.EmployeeId, e.Name order by projectSum desc