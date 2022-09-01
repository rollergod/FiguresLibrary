CREATE DATABASE Magazine

CREATE TABLE Products
(
Id int primary key identity,
ProductName nvarchar(50) not null
)

CREATE TABLE Category
(
Id int primary key identity,
CategoryName nvarchar(50) not null
)

CREATE TABLE ProductCategories
(
ProductId int,
CategoryId int,
FOREIGN KEY (ProductId) REFERENCES Products(Id),
FOREIGN KEY (CategoryId) REFERENCES Category(id),
PRIMARY KEY(ProductId,CategoryId)
)

INSERT INTO Products VALUES
('Сникерс'),('Фруто няня'),('Лосось'),('Машинка')

INSERT INTO Category VALUES
('Напитки'),('Рыба'),('Шоколад')


SELECT * FROM Products

SELECT * FROM Category

SELECT * FROM ProductCategories

INSERT INTO ProductCategories VALUES
(1,3),(2,1),(3,2)

SELECT P.ProductName,C.CategoryName FROM Products P
	LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
	LEFT JOIN Category C
ON PC.CategoryId = C.Id
