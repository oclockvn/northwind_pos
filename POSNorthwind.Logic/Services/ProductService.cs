using Dapper;
using Microsoft.Data.SqlClient;
using POSNorthwind.Logic.Models;

namespace POSNorthwind.Logic.Services;

public class ProductService
{
    private string connectionString = "Server=localhost;Database=northwind;User Id=sa; Password=A@ssm!n@1234;MultipleActiveResultSets=true;TrustServerCertificate=True";

    public List<Product> GetProductList(string search = null)
    {
        var sql = """
            select ProductID as Id, p.ProductName, p.CategoryID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, c.CategoryName from products as p
            join Categories as c on p.CategoryID = c.CategoryID
            """;

        SqlConnection connection = new(connectionString);

        if (!string.IsNullOrWhiteSpace(search))
        {
            sql += " where p.ProductName like @keyword";
        }

        var parameter = new { keyword = string.IsNullOrWhiteSpace(search) ? "" : $"%{search}%" };
        var products = connection.Query<Product>(sql, parameter).ToList();
        return products;
    }

    public void AddProduct(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.ProductName))
        {
            throw new ArgumentNullException();
        }

        var sql = """
            insert into products ([ProductName], [CategoryId], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [ReorderLevel], [Discontinued])
            values (@productName, @categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, 0, 0)
            """;

        var parameter = new
        {
            productName = product.ProductName,
            categoryId = product.CategoryID,
            quantityPerUnit = product.QuantityPerUnit,
            unitPrice = product.UnitPrice,
            unitsInStock = product.UnitsInStock,
        };

        SqlConnection connection = new(connectionString);

        connection.Execute(sql, parameter);
    }

    public void UpdateProduct(Product p)
    {
        var sql = """
            update products 
            set productname=@productname, QuantityPerUnit=@quantityPerUnit, UnitPrice=@unitPrice, UnitsInStock=@unitsInStock, categoryID=@categoryID
            where [ProductId] = @id
            """;

        var parameter = new
        {
            id = p.Id,
            productname = p.ProductName,
            quantityPerUnit = p.QuantityPerUnit,
            unitPrice = p.UnitPrice,
            unitsInStock = p.UnitsInStock,
            categoryID = p.CategoryID
        };

        SqlConnection connection = new(connectionString);
        connection.Execute(sql, parameter);
    }
}
