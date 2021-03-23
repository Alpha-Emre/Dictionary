select CompanyName Şirke_Adı,ContactName Adı,City Şehirler from Customers

select Categories.CategoryID from Categor

select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc

select COUNT(*) Adet from Products where CategoryID = 2

select CategoryID, COUNT(*) from Products group by CategoryID having COUNT(*)<10

select CategoryID, COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.ProductID = Categories.CategoryID  

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.ProductID = Categories.CategoryID where Products.UnitPrice>10

select * from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID inner join Orders on [Order Details].OrderID = Orders.OrderID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null