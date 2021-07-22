USE master;
GO

DROP DATABASE IF EXISTS EfDemo;
GO

CREATE DATABASE EfDemo;
GO

Use EfDemo;
GO

CREATE TABLE ProductCategories
(
	[Id] INT Identity(1, 1) PRIMARY KEY NOT NULL,
	[Name] VARCHAR(200) UNIQUE NOT NULL
);
GO

CREATE TABLE Products 
(
	[Id] INT Identity(1, 1) PRIMARY KEY NOT NULL,
	[CategoryId] INT NOT NULL,
		CONSTRAINT FK_ProductCategories_Products 
		FOREIGN KEY (CategoryId) REFERENCES ProductCategories (ID),
	[Name] VARCHAR(200) UNIQUE NOT NULL, 
	[Description] VARCHAR(MAX)
);
GO

SET IDENTITY_INSERT ProductCategories ON;

INSERT INTO ProductCategories ([Id], [Name]) 
VALUES 
	  ( 1, 'Stationery' ),
	  ( 2, 'Electronics' );

SET IDENTITY_INSERT ProductCategories OFF;
GO

INSERT INTO Products (CategoryId, [Name], [Description]) 
VALUES 
	  ( 1, 'Blue Pen', 'Plastic blue pen' )
	, ( 1, 'Eraser', 'White eraser with cat picture' )
	, ( 1, 'Paper Clip', 'Metal paper clip' )
	, ( 1, 'Notebook', '100 pages notebook with red cover' )
	, ( 2, 'Electronic Tablet', 'Android tablet with 64GB of memory' )
	, ( 2, 'Smart Phone', 'Android smart phone with 48GB of memory' )
	, ( 2, 'Laptop', 'Laptop with 16GB of memory and 512GB of SSD' )
GO
