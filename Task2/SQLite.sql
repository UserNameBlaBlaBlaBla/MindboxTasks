-- создание и заполнение таблиц
DROP TABLE If EXISTS Products;
CREATE TABLE Products (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(20));
INSERT INTO Products (Name) VALUES ('Яблоко');
INSERT INTO Products (Name) VALUES ('Груша');
INSERT INTO Products (Name) VALUES ('Картошка');
INSERT INTO Products (Name) VALUES ('Арбуз');

DROP TABLE If EXISTS Categories;
CREATE TABLE Categories (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(20));
INSERT INTO Categories (Name) VALUES ('Фрукты');
INSERT INTO Categories (Name) VALUES ('Овощи');
INSERT INTO Categories (Name) VALUES ('Корнеплоды');

DROP TABLE If EXISTS ProductsCategories; 
CREATE TABLE ProductsCategories (Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                 ProductId INTEGER, 
                                 CategoryId INTEGER,
                                 FOREIGN KEY ([ProductId]) REFERENCES Products (Id),
                                 FOREIGN KEY ([CategoryId]) REFERENCES Categories (Id));
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (1,1);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (2,1);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (3,2);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (3,3);

-- решение 2 задания
Select Products.Name as 'Имя продукта', Categories.Name as 'Имя категории' 
FROM Products 
LEFT JOIN ProductsCategories ON Products.Id == ProductsCategories.ProductId
LEFT JOIN Categories ON ProductsCategories.CategoryId == Categories.Id