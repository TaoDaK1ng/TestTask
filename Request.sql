CREATE SCHEMA [TestTask];
GO

CREATE TABLE [TestTask].[Products]
(
	[Id] INT NOT NULL IDENTITY CONSTRAINT PK_Products_Id PRIMARY KEY,
	[Name] NVARCHAR(200) NOT NULL
);

INSERT INTO [TestTask].[Products] ([Name]) VALUES 
('Клавиатура'), ('Мышь'), ('Игровой монитор'),
('Холодильник'), ('Стиральная машина'), ('Посудомойка'),
('Видеокарта'), ('Процессор'), ('Оперативная память'),
('Wi-Fi роутер'), ('Маршрутизатор');

CREATE TABLE [TestTask].[Categories]
(
	[Id] INT NOT NULL IDENTITY CONSTRAINT PK_Categories_Id PRIMARY KEY,
	[Name] NVARCHAR(150) NOT NULL CONSTRAINT UQ_Categories_Name UNIQUE
);

INSERT INTO [TestTask].[Categories] ([Name]) VALUES ('Компьютерная периферия'), ('Бытовая техника'), ('Комплектующие для ПК');

CREATE TABLE [TestTask].[ProductCategory]
(
	[ProductId] INT NOT NULL CONSTRAINT FK_ProductCategory_To_Products FOREIGN KEY REFERENCES [TestTask].[Products] (Id) ON DELETE CASCADE,
	[CategoryId] INT NOT NULL CONSTRAINT FK_ProductCategory_To_Categories FOREIGN KEY REFERENCES [TestTask].[Categories] (Id) ON DELETE CASCADE,
	CONSTRAINT PK_ProductCategory PRIMARY KEY CLUSTERED ([ProductId] ASC, [CategoryId] ASC)
);

INSERT INTO [TestTask].[ProductCategory] ([ProductId], [CategoryId]) VALUES 
(1, 1), 
(2, 1),
(3, 1),
(4, 2),
(5, 2), 
(6, 2),
(7, 3), 
(8, 3), 
(9, 3);

SELECT p.[Name] AS 'Имя продукта', c.[Name] AS 'Имя категории' 
FROM [TestTask].[Products] p 
LEFT JOIN [TestTask].[ProductCategory] pc ON p.[Id] = pc.[ProductId]
LEFT JOIN [TestTask].[Categories] c ON c.[Id] = pc.[CategoryId];