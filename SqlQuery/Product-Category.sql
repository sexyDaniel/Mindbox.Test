create database TestDB

create table Products
(
	ID int primary key identity,
	Name varchar(45),
	Price DECIMAL check (Price>0)
)

create table Categories
(
	ID int primary key identity,
	Name varchar(45)
)

create table ProductCategory
(
	ProductId int references Products (ID),
	CategoryId int references Categories (ID)
)

insert into Products (Name, Price) values ('Nike 1234', 124), ('Adidas 23', 234), ('Puma 34', 123), ('Rossita 1', 1294)
insert into Categories (Name) values ('Кросовки'), ('Куртки'), ('Джинсы'), ('Ветровки')
insert into ProductCategory (ProductId, CategoryId) values (1,1), (2,4), (3,2), (3,4)

select p.Name, c.Name 
from Products p
left join ProductCategory as pc on p.ID = pc.ProductId
left join Categories as c on c.ID = pc.CategoryId