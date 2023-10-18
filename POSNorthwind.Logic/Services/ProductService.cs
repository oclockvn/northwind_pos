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
            return new List<Product>
            {
                new Product(){Id = 1, ProductName = "Samsung", CategoryID = 1, CategoryName = "Phone", QuantityPerUnit = "Unit", UnitPrice = 30000 },
                new Product(){Id = 2, ProductName = "iPhone", CategoryID = 1, CategoryName = "Phone", QuantityPerUnit = "Unit", UnitPrice = 35000 },
            };
        }
    }
}
