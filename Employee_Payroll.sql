alter table employee_payroll add Gender char(1) 

UPDATE employee_payroll set Gender='M' where name = 'Bill' or name ='Charlie';
