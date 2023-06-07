create Table Employee_Department(Id int primary key IDENTITY(1,1),EmployeeId int ,DepartmentId int,FOREIGN KEY (DepartmentId) REFERENCES employee_payroll(Id))


select * from employee_payroll inner join  Employee_Department on employee_payroll.ID=Employee_Department.DepartmentId;



