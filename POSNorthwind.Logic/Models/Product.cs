namespace POSNorthwind.Logic.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    //public int? SupplierID { get; set; }
    public int? CategoryID { get; set; }
    public string CategoryName { get; set; } = null!;
    public string QuantityPerUnit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    //public int UnitsOnOrder { get; set; }
    //public string ReorderLevel { get; set; }
    //public string Discontinued { get; set; }
}
