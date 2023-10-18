using Dapper;
using Microsoft.Data.SqlClient;
using POSNorthwind.Logic.Models;

namespace POSNorthwind.Logic.Services
{
    public class ProductService
    {
        public List<Product> GetProductList(string search = null)
        {
            var sql = """
                select ProductID as Id, p.ProductName, p.CategoryID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, c.CategoryName from products as p
                join Categories as c on p.CategoryID = c.CategoryID
                """;

            var connectionString = "Server=localhost;Database=northwind;User Id=sa; Password=A@ssm!n@1234;MultipleActiveResultSets=true;TrustServerCertificate=True";
            SqlConnection connection = new(connectionString);

            if (!string.IsNullOrWhiteSpace(search))
            {
                sql += " where p.ProductName like @keyword";
            }

            var parameter = new { keyword = string.IsNullOrWhiteSpace(search) ? "" : $"%{search}%" };
            var products = connection.Query<Product>(sql, parameter).ToList();
            return products;
        }
    }
}
