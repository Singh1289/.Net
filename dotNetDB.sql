-- create database dotNetDB;

use dotNetDB;

create table Employees 
(
	empID int auto_increment,
    empName varchar(60),
    empAge int,
    empSalary int,
    empCity varchar(60),
    primary key(empID)
); 

create table Products 
(
	productID int auto_increment,
    productName varchar(60),
    productPrice int,    
    primary key(productID)
); 

select * from Products;

select * from Employees;


insert into Employees (empName,empAge,empSalary,empCity) values ('rahul', 20,25000,'pune');
insert into Employees (empName,empAge,empSalary,empCity) values ('Ajay', 22,40000,'Mumbai');
insert into Employees (empName,empAge,empSalary,empCity) values ('Rohit', 30,20000,'Mumbai');
insert into Employees (empName,empAge,empSalary,empCity) values ('Raj', 27,35000,'Goa');
insert into Employees (empName,empAge,empSalary,empCity) values ('Mukul', 31,55000,'Delhi');
insert into Employees (empName,empAge,empSalary,empCity) values ('Piyush', 28,30000,'Delhi');



insert into Products (productNameinsertProduct,productPrice) values 
('Shoes',2000),
('Bottle',100),
('Kayboard',700),
('Mouse',400),
('Charger',700),
('Shirt',1000);

USE `dotnetdb`;
DROP procedure IF EXISTS `getAllEmployees`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `getAllEmployees` ()
BEGIN
	select * from Employees;
END$$
DELIMITER ;
-- ---------------------------------------------------
USE `dotnetdb`;
DROP procedure IF EXISTS `getAllProducts`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `getAllProducts` ()
BEGIN
	select * from Products;
END$$
DELIMITER ;
-- ----------------------------------------------

USE `dotnetdb`;
DROP procedure IF EXISTS `insetEmployee`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `insetEmployee` (
	nam varchar(50),
    age int,
    sal int,
    city varchar(50)
)
BEGIN
	insert into Employees (empName,empAge,empSalary,empCity) values (nam, age,salary,city);
END$$
DELIMITER ;

USE `dotnetdb`;
DROP procedure IF EXISTS `insertProduct`;
-- -------------------------------------------------------------------------
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `insertProduct` (nam varchar(50),price int)
BEGIN
	insert into Products (productName,productPrice) values (nam,price);
END$$

DELIMITER ;
-- ----------------------------------------------------------------------------------
USE `dotnetdb`;
DROP procedure IF EXISTS `updateEmployee`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `updateEmployee` 
(
	id int,
	nam varchar(50),
    age int,
    sal int,
    city varchar(50)
)
BEGIN
	update Employees set empName= nam, empAge=age, empSalary= sal, empCity=city where empID= id;
END$$
DELIMITER ;
-- --------------------------------------------------------------------
USE `dotnetdb`;
DROP procedure IF EXISTS `updateProduct`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `updateProduct` (id int,nam varchar(50),price int)
BEGIN
	update Products set productName=nam, productPrice=price where productID= id;
END$$
DELIMITER ;

-- -------------------------------------------------------------------------
USE `dotnetdb`;
DROP procedure IF EXISTS `deleteEmployee`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `deleteEmployee` (id int)
BEGIN
	delete from Employee where empID= id; 
END$$
DELIMITER ;

-- ------------------------------------------------------------------

USE `dotnetdb`;
DROP procedure IF EXISTS `deleteProduct`;
DELIMITER $$
USE `dotnetdb`$$
CREATE PROCEDURE `deleteProduct` (id int)
BEGIN
	delete from Products where productID= id;
END$$
DELIMITER ;


