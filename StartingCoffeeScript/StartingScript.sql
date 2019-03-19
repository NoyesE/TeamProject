use master

if DB_ID('CoffeeDatabase') is not null
	drop database CoffeeDatabase
GO

Create Database CoffeeDatabase
go

use CoffeeDatabase
go

CREATE TABLE Customer
(
	CustomerID int   PRIMARY KEY IDENTITY
	,DateOfBirth     date  NOT NULL
	,FirstName varchar(30) NOT NULL
	,LastName  varchar(35) NOT NULL
	,DrinkName           varchar(40) NOT NULL
)
GO
INSERT INTO Customer(DateOfBirth, FirstName,LastName,DrinkName)
	VALUES('Jan 01, 1980', 'Bark', 'Sana', 'Iced Coffee')
	,('April 12, 1987', 'Meow', 'Mina', 'Latte')
	,('May 1, 1950', 'Beep', 'Momo', 'Coffee Milk')
GO

--CREATE TABLE Registration
--(
--	CustomerID int   REFERENCES Customer(CustomerID)
--	,Product int references Drink(ProductID)
--	,RegDate   smalldatetime    NOT NULL
--	,PRIMARY KEY(CustomerID)
--)
--GO
--INSERT INTO Registration (CustomerID, Product, RegDate)
--VALUES(3, 'Latte', GETDATE()),(2, 'Cappuccino', GETDATE() - 7)
--GO

Create table Drink
(
	ProductID int Primary Key Identity
	,DrinkName varchar(40) Unique not null
	,BaseCost smallmoney not null
)
Go

Create table DrinkExtra
(
	ExtraID int Primary Key Identity
	,Product int references Drink(ProductID)
	,ExtraName varchar(30) not null
	,Cost smallmoney not null
)

insert into Drink(DrinkName,BaseCost)
	Values('TestDrink' , '10')
go
insert into DrinkExtra(Product, ExtraName, Cost)
	Values('1', 'TestExtra', '5')