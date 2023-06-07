select sum(salary) as TotalSum from employee_payroll where Gender='M'

select Avg(salary) as TotalSum from employee_payroll where Gender='F'

select Min(salary) as TotalSum from employee_payroll where Gender='F'

select Max(salary) as TotalSum from employee_payroll where Gender='M'

select Count(salary) as TotalSum from employee_payroll where Gender='F'

SELECT SUM(salary) FROM employee_payroll WHERE Gender = 'M' GROUP BY Gender;

