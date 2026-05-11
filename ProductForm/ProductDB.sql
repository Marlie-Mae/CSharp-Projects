CREATE TABLE Products (
    Product_ID VARCHAR(10) PRIMARY KEY DEFAULT 'PRD0001',
    Product_Name VARCHAR(30) NOT NULL,
    Product_Description VARCHAR(50) NOT NULL,
    Quantity INT, 
    Unit VARCHAR(20) CHECK (Unit IN ('pcs', 'kg', 'ltr', 'box', 'dozen', 'gram', 'meter', 'pack'))
);

CREATE TABLE History (
    History_ID INT IDENTITY(1,1) PRIMARY KEY, 
    Product_ID VARCHAR(10) NOT NULL,
    Transaction_Date DATETIME NOT NULL,
    Transaction_Type VARCHAR(3) NOT NULL CHECK (Transaction_Type IN ('In', 'Out')),
    Quantity INT NOT NULL,  
    Unit VARCHAR(20) NOT NULL CHECK (Unit IN ('pcs', 'kg', 'ltr', 'box', 'dozen', 'gram', 'meter', 'pack')), 
    Supplier VARCHAR(30) NOT NULL,
    Customer VARCHAR(30) NOT NULL,
    FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID)
);

SELECT Product_ID, Product_Name, Unit FROM Products;

DROP TABLE Products;
DROP TABLE History;

DELETE FROM History;
DBCC CHECKIDENT ('History', RESEED, 0);

SELECT * FROM Products;
SELECT * FROM History;


DELETE FROM History;

DBCC CHECKIDENT ('History', RESEED, 0);

DELETE FROM Products;

SELECT * FROM History;

SELECT * FROM Products;