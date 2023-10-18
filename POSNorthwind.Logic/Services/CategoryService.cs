using Dapper;
using Microsoft.Data.SqlClient;
using POSNorthwind.Logic.Models;

namespace POSNorthwind.Logic.Services
{
    public class CategoryService
    {
        public List<Category> GetCategoryList()
        {
            var sql = "select CategoryID as Id, CategoryName, Description from Categories";

            var connectionString = "Server=localhost;Database=northwind;User Id=sa; Password=A@ssm!n@1234;MultipleActiveResultSets=true;TrustServerCertificate=True";
            SqlConnection connection = new(connectionString);

            var categories = connection.Query<Category>(sql).ToList();
            return categories;
        }
    }
}
