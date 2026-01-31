Create database Asses1DB;
use Asses1DB
----Question 1----
CREATE TABLE Customers (
    CustomerID INT IDENTITY PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50)
);
CREATE TABLE SalesPersons (
    SalesPersonID INT IDENTITY PRIMARY KEY,
    SalesPersonName VARCHAR(100)
);
CREATE TABLE Products (
    ProductID INT IDENTITY PRIMARY KEY,
    ProductName VARCHAR(100)
);
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT,
    SalesPersonID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (SalesPersonID) REFERENCES SalesPersons(SalesPersonID)
);
CREATE TABLE OrderItems (
    OrderItemID INT IDENTITY PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
----Question 3----
SELECT 
    sp.SalesPersonName,
    SUM(oi.Quantity * oi.UnitPrice) AS TotalSales
FROM SalesPersons sp
JOIN Orders o ON sp.SalesPersonID = o.SalesPersonID
JOIN OrderItems oi ON o.OrderID = oi.OrderID
GROUP BY sp.SalesPersonName
HAVING SUM(oi.Quantity * oi.UnitPrice) > 60000;

----Question 4----
WITH CustomerTotals AS (
    SELECT 
        c.CustomerName,
        SUM(oi.Quantity * oi.UnitPrice) AS TotalSpent
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN OrderItems oi ON o.OrderID = oi.OrderID
    GROUP BY c.CustomerName
)
SELECT CustomerName, TotalSpent
FROM CustomerTotals
WHERE TotalSpent > (
    SELECT AVG(TotalSpent) FROM CustomerTotals
);
----Question 5----
SELECT
    UPPER(c.CustomerName) AS CustomerName,
    DATENAME(MONTH, o.OrderDate) AS OrderMonth,
    o.OrderDate
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE 
    YEAR(o.OrderDate) = 2026
    AND MONTH(o.OrderDate) = 1;

