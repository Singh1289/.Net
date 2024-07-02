Create Database June2024ECommerceDb;

USE June2024ECommerceDb;

drop table if exists Users;
drop table if exists Invoices;
drop table if exists Carts;
drop table if exists Employees;
drop table if exists Customers;
drop table if exists Products;
drop table if exists Brands;
drop table if exists Categories;


CREATE TABLE Categories ( 
    CategoryId int PRIMARY KEY AUTO_INCREMENT,
    CategoryName varchar(100),
    Description varchar(200)
);

INSERT INTO Categories(CategoryName,Description) VALUES
('Boot','Genuine Leather'),
('Casual','Running Shoe'),
('Casual','Casual Soft Leather'),
('Casual','Party Ware Leather'),
('Casual','Fashion ware'),
('Sneakers','Anywhere wear product'),
('Sports','Football Sports Shoes');

CREATE TABLE Brands ( 
    BrandId int PRIMARY KEY AUTO_INCREMENT,
    BrandName varchar(100)
);

INSERT INTO Brands(BrandName) VALUES
('Bata'),
('Campus'),
('Woodland'),
('Puma'),
('Nike'),
('Adidas');

CREATE TABLE Products ( 
    ProductId int PRIMARY KEY AUTO_INCREMENT,
    CategoryId int,
    BrandId int,
    ProductName varchar(100),
    Description varchar(100),
    UnitPrice int,
    ManufacturingDate Date,
    MadeIn varchar(100),
    Gender varchar(100),
    WarrantyPeriod varchar(100),
    ReturnPolicy varchar(100),
    ProductQuantity int,
    Discount int,
    Picture varchar(200),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    FOREIGN KEY (BrandId) REFERENCES Brands(BrandId)
);


INSERT INTO Products(CategoryId,BrandId,ProductName,Description,UnitPrice,ManufacturingDate,MadeIn,Gender,WarrantyPeriod,ReturnPolicy,ProductQuantity,Discount,Picture) VALUES
(1,1,'Bata','Genuine Leather',4200,'2023-01-05','India','Male','1 year','14 days',452,10,'~/Images/bata_b_m_1.jpg'),
(1,2,'Campus','Genuine Leather',1599,'2023-01-05','India','Male','3 months','7 days',73,5,'~/Images/campus_b_m_1.jpg'),
(1,3,'Woodland','Genuine Leather',4599,'2023-01-05','India','Male','1 year','14 days',547,10,'~/Images/woodland_b_m_1.jpeg'),
(1,3,'Woodland','Genuine Leather',2399,'2023-01-05','India','Male','6 months','7 days',78,5,'~/Images/woodland_b_m_2.jpg'),
(2,4,'Puma','Genuine Leather',1200,'2023-01-05','India','Male','6 months','14 days',54,5,'~/Images/puma_c_m_1.jpg'),
(3,1,'Bata','Genuine Leather',1199,'2023-01-05','India','Male','2 months','7 days',97,5,'~/Images/bata_c_m_1.jpeg'),
(4,1,'Bata','Genuine Leather',1899,'2023-01-05','India','Male','3 months','7 days',78,10,'~/Images/bata_c_m_2.jpeg'),
(5,2,'Campus','Genuine Leather',1599,'2023-01-05','India','Male','1 months','7 days',567,5,'~/Images/campus_c_m_1.jpeg'),
(6,2,'Campus','Genuine Leather',999,'2023-01-05','India','Male','0 months','7 days',453,5,'~/Images/campus_l_m_2.jpg'),
(6,5,'Nike','Genuine Leather',1599,'2023-01-05','India','Male','1 months','7 days',789,5,'~/Images/nikp_l_m_1.jpg'),
(6,5,'Nike','Genuine Leather',2099,'2023-01-05','India','Male','1 months','7 days',665,5,'~/Images/nikp_l_m_2.jpg'),
(6,5,'Nike','Genuine Leather',1599,'2023-01-05','India','Male','3 months','14 days',478,10,'~/Images/nikp_l_m_3.jpg'),
(7,6,'Adidas','Genuine Leather',4599,'2023-01-05','India','Male','6 Months','14 Days',465,5,'~/Images/adidas_soc_m_1.jpeg'),
(7,5,'Nike','Genuine Leather',3499,'2023-01-05','India','Male','3 Months','7 days',546,5,'~/Images/nikp_soc_m_1.jpeg'),
(7,4,'Puma','Genuine Leather',3455,'2023-01-05','India','Male','1 months','7 days',75,5,'~/Images/puma_soc_m_1.jpeg'),
(7,4,'Puma','Genuine Leather',2999,'2023-01-05','India','Male','1 months','7 days',75,5,'~/Images/puma_soc_m_2.png');

CREATE TABLE Customers ( 
    CustomerId int PRIMARY KEY AUTO_INCREMENT,
    ContactName varchar(100),
    Address varchar(200),
    City varchar(100),
    Phone varchar(50)
);

CREATE TABLE Employees ( 
    EmployeeId int PRIMARY KEY AUTO_INCREMENT,
    EmployeeName varchar(100),
    Address varchar(200),
    City varchar(100),
    Phone varchar(50)
);

CREATE TABLE Carts ( 
    CartId int PRIMARY KEY AUTO_INCREMENT,
    CartDate Date,
    CustomerId int,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
Create Table CartDetails(
  CartDetailsId int PRIMARY KEY AUTO_INCREMENT,
  CartId int,
  ProductId int,
  Quantity int,
  FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
  FOREIGN KEY (CartId) REFERENCES Carts(CartId)
);
CREATE TABLE Invoices ( 
    InvoiceId int PRIMARY KEY AUTO_INCREMENT,
    CartId int,
    FOREIGN KEY (CartId) REFERENCES Carts(CartId)
);

CREATE TABLE Users ( 
    UserId int PRIMARY KEY AUTO_INCREMENT,
    Email varchar(100),
    Password varchar(100),
    Role varchar(100)
);


/* Categories */

drop procedure if exists GetAllCategories;
delimiter $$
create procedure GetAllCategories()
begin
    select * from Categories;
end $$
delimiter ;


drop procedure if exists GetOneCategory;
delimiter $$
create procedure GetOneCategory(p_CategoryID int)
begin
    select * from Categories where CategoryID=p_CategoryID;
end $$
delimiter ;


drop procedure if exists InsertCategory;
delimiter $$
create procedure InsertCategory(p_CategoryName varchar(100), p_Description varchar(200))
begin
    insert into Categories(CategoryName, Description) values( p_CategoryName, p_Description);
end $$
delimiter ;


drop procedure if exists UpdateCategory;
delimiter $$
create procedure UpdateCategory(p_CategoryId int, p_CategoryName varchar(100), p_Description varchar(200))
begin
    update Categories set CategoryName = p_CategoryName, Description = p_Description where CategoryID = p_CategoryId;
end $$
delimiter ;


drop procedure if exists DeleteCategory;
delimiter $$
create procedure DeleteCategory(p_CategoryId int)
begin
    delete from Categories where CategoryID = p_CategoryId;
end $$
delimiter ;

/* Brands */

drop procedure if exists GetAllBrands;
delimiter $$
create procedure GetAllBrands()
begin
    select * from Brands;
end $$
delimiter ;


drop procedure if exists GetOneBrand;
delimiter $$
create procedure GetOneBrand(p_BrandID int)
begin
    select * from Brands where BrandID=p_BrandID;
end $$
delimiter ;


drop procedure if exists InsertBrand;
delimiter $$
create procedure InsertBrand(p_BrandName varchar(100))
begin
    insert into Brands(BrandName) values( p_BrandName );
end $$
delimiter ;


drop procedure if exists UpdateBrand;
delimiter $$
create procedure UpdateBrand(p_BrandId int, p_BrandName varchar(100))
begin
    update Brands set BrandName = p_BrandName where BrandID = p_BrandId;
end $$
delimiter ;


drop procedure if exists DeleteBrand;
delimiter $$
create procedure DeleteBrand(p_BrandId int)
begin
    delete from Brands where BrandID = p_BrandId;
end $$
delimiter ;

/* Products */

drop procedure if exists GetAllProducts;
delimiter $$
create procedure GetAllProducts()
begin
    select * from Products;
end $$
delimiter ;


drop procedure if exists GetOneProduct;
delimiter $$
create procedure GetOneProduct(p_ProductID int)
begin
    select * from Products where ProductID=p_ProductID;
end $$
delimiter ;


drop procedure if exists InsertProduct;
delimiter $$
create procedure InsertProduct(p_CategoryId int,p_BrandId int,p_ProductName varchar(100),p_Description varchar(100),p_UnitPrice int,p_ManufacturingDate Date,p_MadeIn varchar(100),p_Gender varchar(100),p_WarrantyPeriod varchar(100),p_ReturnPolicy varchar(100),p_ProductQuantity int,p_Discount int,p_Picture varchar(200))
begin
    INSERT INTO Products(CategoryId,BrandId,ProductName,Description,UnitPrice,ManufacturingDate,MadeIn,Gender,WarrantyPeriod,ReturnPolicy,ProductQuantity,Discount,Picture) VALUES ( p_CategoryId ,p_BrandId ,p_ProductName ,p_Description,p_UnitPrice ,p_ManufacturingDate ,p_MadeIn ,p_Gender ,p_WarrantyPeriod ,p_ReturnPolicy ,p_ProductQuantity ,p_Discount ,p_Picture );
end $$
delimiter ;


drop procedure if exists UpdateProduct;
delimiter $$
create procedure UpdateProduct(p_ProductId int, p_CategoryId int,p_BrandId int,p_ProductName varchar(100),p_Description varchar(100),p_UnitPrice int,p_ManufacturingDate Date,p_MadeIn varchar(100),p_Gender varchar(100),p_WarrantyPeriod varchar(100),p_ReturnPolicy varchar(100),p_ProductQuantity int,p_Discount int,p_Picture varchar(200))
begin
    update Products set CategoryId = p_CategoryId, BrandId = p_BrandId, ProductName = p_ProductName, Description = p_Description, UnitPrice = p_UnitPrice, ManufacturingDate = p_ManufacturingDate, MadeIn = p_MadeIn, Gender = p_Gender, WarrantyPeriod = p_WarrantyPeriod, ReturnPolicy = p_ReturnPolicy, ProductQuantity = p_ProductQuantity, Discount = p_Discount, Picture = p_Picture where ProductID = p_ProductId;
end $$
delimiter ;


drop procedure if exists DeleteProduct;
delimiter $$
create procedure DeleteProduct(p_ProductId int)
begin
    delete from Products where ProductID = p_ProductId;
end $$
delimiter ;

/* Customers */

drop procedure if exists GetAllCustomers;
delimiter $$
create procedure GetAllCustomers()
begin
    select * from Customers;
end $$
delimiter ;


drop procedure if exists GetOneCustomer;
delimiter $$
create procedure GetOneCustomer(p_CustomerID int)
begin
    select * from Customers where CustomerID=p_CustomerID;
end $$
delimiter ;


drop procedure if exists InsertCustomer;
delimiter $$
create procedure InsertCustomer(p_ContactName varchar(100), p_Address varchar(200), p_City varchar(100), p_Phone varchar(50) )
begin
    insert into Customers(ContactName, Address, City, Phone) values( p_ContactName, p_Address, p_City, p_Phone );
end $$
delimiter ;


drop procedure if exists UpdateCustomer;
delimiter $$
create procedure UpdateCustomer(p_CustomerId int, p_ContactName varchar(100), p_Address varchar(200), p_City varchar(100), p_Phone varchar(50) )
begin
    update Customers set ContactName = p_ContactName, Address = p_Address, City = p_City, Phone = p_Phone where CustomerID = p_CustomerId;
end $$
delimiter ;


drop procedure if exists DeleteCustomer;
delimiter $$
create procedure DeleteCustomer(p_CustomerId int)
begin
    delete from Customers where CustomerID = p_CustomerId;
end $$
delimiter ;

/* Employees */

drop procedure if exists GetAllEmployees;
delimiter $$
create procedure GetAllEmployees()
begin
    select * from Employees;
end $$
delimiter ;


drop procedure if exists GetOneEmployee;
delimiter $$
create procedure GetOneEmployee(p_EmployeeID int)
begin
    select * from Employees where EmployeeID=p_EmployeeID;
end $$
delimiter ;


drop procedure if exists InsertEmployee;
delimiter $$
create procedure InsertEmployee(p_EmployeeName varchar(100), p_Address varchar(200), p_City varchar(100), p_Phone varchar(50) )
begin
    insert into Employees(EmployeeName, Address, City, Phone) values( p_EmployeeName, p_Address, p_City, p_Phone );
end $$
delimiter ;


drop procedure if exists UpdateEmployee;
delimiter $$
create procedure UpdateEmployee(p_EmployeeId int, p_EmployeeName varchar(100), p_Address varchar(200), p_City varchar(100), p_Phone varchar(50) )
begin
    update Employees set EmployeeName = p_EmployeeName, Address = p_Address, City = p_City, Phone = p_Phone where EmployeeID = p_EmployeeId;
end $$
delimiter ;


drop procedure if exists DeleteEmployee;
delimiter $$
create procedure DeleteEmployee(p_EmployeeId int)
begin
    delete from Employees where EmployeeID = p_EmployeeId;
end $$
delimiter ;

/* Carts */

drop procedure if exists GetAllCarts;
delimiter $$
create procedure GetAllCarts()
begin
    select * from Carts;
end $$
delimiter ;


drop procedure if exists GetOneCart;
delimiter $$
create procedure GetOneCart(p_CartID int)
begin
    select * from Carts where CartID=p_CartID;
end $$
delimiter ;


drop procedure if exists InsertCart;
delimiter $$
create procedure InsertCart(p_CartDate Date, p_CustomerID int, p_ProductID int, p_EmployeeID int, p_Quantity int )
begin
    insert into Carts(CartDate, CustomerId, ProductId, EmployeeId, Quantity) values( p_CartDate, p_CustomerID, p_ProductID, p_EmployeeID, p_Quantity );
end $$
delimiter ;


drop procedure if exists UpdateCart;
delimiter $$
create procedure UpdateCart(p_CartId int, p_CartDate Date, p_CustomerID int, p_ProductID int, p_EmployeeID int, p_Quantity int )
begin
    update Carts set CartDate = p_CartDate, CustomerId = p_CustomerID, ProductId = p_ProductID, EmployeeId = p_EmployeeID, Quantity = p_Quantity where CartID = p_CartId;
end $$
delimiter ;


drop procedure if exists DeleteCart;
delimiter $$
create procedure DeleteCart(p_CartId int)
begin
    delete from Carts where CartID = p_CartId;
end $$
delimiter ;

drop procedure if exists GetAllCartDetails;
delimiter $$
create procedure GetAllCartDetails(p_CartId int)
begin
    select * from CartDetails where CartID = p_CartId;
end $$
delimiter ;


/* Invoices */

drop procedure if exists GetAllInvoices;
delimiter $$
create procedure GetAllInvoices()
begin
    select * from Invoices;
end $$
delimiter ;


drop procedure if exists GetOneInvoice;
delimiter $$
create procedure GetOneInvoice(p_InvoiceID int)
begin
    select * from Invoices where InvoiceID=p_InvoiceID;
end $$
delimiter ;


drop procedure if exists InsertInvoice;
delimiter $$
create procedure InsertInvoice(p_CartID int)
begin
    insert into Invoices(CartID) values( p_CartID );
end $$
delimiter ;


drop procedure if exists UpdateInvoice;
delimiter $$
create procedure UpdateInvoice(p_InvoiceId int, p_CartID int)
begin
    update Invoices set CartID = p_CartID where InvoiceID = p_InvoiceId;
end $$
delimiter ;


drop procedure if exists DeleteInvoice;
delimiter $$
create procedure DeleteInvoice(p_InvoiceId int)
begin
    delete from Invoices where InvoiceID = p_InvoiceId;
end $$
delimiter ;

/* Users */

drop procedure if exists GetAllUsers;
delimiter $$
create procedure GetAllUsers()
begin
    select * from Users;
end $$
delimiter ;


drop procedure if exists GetOneUser;
delimiter $$
create procedure GetOneUser(p_UserID int)
begin
    select * from Users where UserID=p_UserID;
end $$
delimiter ;


drop procedure if exists InsertUser;
delimiter $$
create procedure InsertUser(p_Email varchar(100), p_Password varchar(100), p_Role varchar(100))
begin
    insert into Users(Email, Password, Role) values( p_Email, p_Password, p_Role );
end $$
delimiter ;


drop procedure if exists UpdateUser;
delimiter $$
create procedure UpdateUser(p_UserId int, p_Email varchar(100), p_Password varchar(100), p_Role varchar(100))
begin
    update Users set Email = p_Email, Password = p_Password, Role = p_Role where UserID = p_UserId;
end $$
delimiter ;


drop procedure if exists DeleteUser;
delimiter $$
create procedure DeleteUser(p_UserId int)
begin
    delete from Users where UserID = p_UserId;
end $$
delimiter ;
