use master

if DB_ID('CoffeeDatabase') is not null
	drop database CoffeeDatabase
GO

Create Database CoffeeDatabase
go

use CoffeeDatabase
go

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