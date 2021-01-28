SELECT Products.ProductName, Sum("Order Details".UnitPrice*Quantity) AS ProductSales
FROM Products
INNER JOIN 
(Orders INNER JOIN "Order Details" ON Orders.OrderID = "Order Details".OrderID) 
ON Products.ProductID = "Order Details".ProductID
GROUP BY  Products.ProductName