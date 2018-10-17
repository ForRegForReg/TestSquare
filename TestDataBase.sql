select  Products.ProductName,
STRING_AGG (ISNULL(Categories.CategoryName,'No Category'),',') as 'Category'
 from Products left outer join ProductsCategories 
on Products.ProductID = ProductsCategories.ProductID left outer join Categories
on ProductsCategories.CategoryID = Categories.CategoryID 
GROUP BY Products.ProductName
