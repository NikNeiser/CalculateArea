CREATE TABLE Products
(
	ProductId int IDENTITY Not Null Primary key,
	ProductName varchar(25) NOT NULL
)

CREATE TABLE Categories
(
	CategoryId int IDENTITY Not Null Primary key,
	CategoryName varchar(25) NOT NULL
)

CREATE TABLE ProductsCategories
(
	ProductId int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
	CategoryId int NOT NULL FOREIGN KEY REFERENCES Categories(CategoryId),
	Primary key (ProductId,CategoryId)
)

SELECT ProductName, CategoryName From Products prod
LEFT OUTER JOIN ProductsCategories PrCt ON prod.ProductId = PrCt.ProductId
LEFT OUTER JOIN Categories Cat ON Cat.CategoryId = PrCt.CategoryId