select Products.ProductName, ISNULL(Categories.CategoryName,'No Category')
 from Products left outer join ProductsCategories 
on Products.ProductID = ProductsCategories.ProductID left outer join Categories
on ProductsCategories.CategoryID = Categories.CategoryID
