using System.ComponentModel.DataAnnotations;

namespace pos_library.models;

public class Customers
{
    [Key]
    public int customer_id { get; set; }
}

public class Sale
{
    [Key]
    public int sale_id { get; set; }
}

public class Employee
{
    [Key]
    public int employee_id { get; set; }
}

public class SaleDetail
{
    [Key]
    public int sales_detail_id { get; set; }
}

public class Product
{
    [Key]
    public int product_id { get; set; }
}

public class Inventory
{
    [Key]
    public int inventory_id { get; set; }
}