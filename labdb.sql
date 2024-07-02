use group038_campus;
insert into Employees(EmployeeName,City) values(p_name,p_city);
Update  Employees Set  EmployeeName =p_name,City=p_city where EmployeeID =p_id ;
	Delete from Employees where EmployeeId = p_id;
    
    
Update  Employees Set  EmployeeName ="Harsh",City="Selvas" where EmployeeID =2 ;

insert into Employees(EmployeeName,City) values("Sarvesh","Amravati");


select * from employees;