select * from employee_payroll inner join  Employee_Department on employee_payroll.ID=Employee_Department.DepartmentId where name='Bill'


select * from employee_payroll inner join  Employee_Department on employee_payroll.ID=Employee_Department.DepartmentId WHERE StartDate BETWEEN CAST('2018-01-01'
AS DATE) AND cast(GETDATE()as date);