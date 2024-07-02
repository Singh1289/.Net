use group023;
create table Customers1104
(
	CustomerId int Primary Key,
    ContactName varchar(100),
    City varchar(100)
);
insert into Customers1104 Values(1,'Alisha C.','Mumbai');
insert into Customers1104 Values(2,'John Mark','London');
insert into Customers1104 Values(3,'Maria Andrus','Berlin');

drop procedure if exists DeleteCustomer;
delimiter $$
create procedure DeleteCustomer(p_CustomerId int)
begin
    delete from Customers1104 where CustomerID = p_CustomerId;
end $$
delimiter ;

drop procedure if exists GetAllCustomers;
delimiter $$
create procedure GetAllCustomers()
begin
    select * from Customers1104;
end $$
delimiter ;

drop procedure if exists InsertCustomer;
delimiter $$
create procedure InsertCustomer(p_CustomerId int,p_ContactName varchar(100), p_City varchar(100))
begin
    insert into Customers1104(CustomerId,ContactName, City) values(p_CustomerId, p_ContactName, p_City );
end $$
delimiter ;


drop procedure if exists UpdateCustomer;
delimiter $$
create procedure UpdateCustomer(p_CustomerId int, p_ContactName varchar(200), p_City varchar(100) )
begin
   update Customers1104 set ContactName = p_ContactName, City = p_City where CustomerID = p_CustomerId;
end $$
delimiter ;