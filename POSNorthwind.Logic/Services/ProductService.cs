using Dapper;
using Microsoft.Data.SqlClient;
using POSNorthwind.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSNorthwind.Logic.Services
{
    public class ProductService
    {
        public List<Product> GetProductList()
        {
            var sql = """
                select ProductID as Id, p.ProductName, p.CategoryID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, c.CategoryName from products as p
                join Categories as c on p.CategoryID = c.CategoryID
                """;

            var connectionString = "Server=localhost;Database=northwind;User Id=sa; Password=A@ssm!n@1234;MultipleActiveResultSets=true;TrustServerCertificate=True";
            SqlConnection connection = new(connectionString);

            var products = connection.Query<Product>(sql).ToList();
            return products;
        }
    }
}
