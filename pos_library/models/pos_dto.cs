namespace pos_library.models;

public class CustomerDTO
{
    public int CustomerID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class EmployeeDTO
{
    public int EmployeeID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Position { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class SaleDTO
{
    public int SaleID { get; set; }
    public required string CustomerName { get; set; }
    public required string EmployeeName { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalAmount { get; set; }
}

public class SaleDetailDTO
{
    public int SaleDetailID { get; set; }
    // public int sale_id { get; set; }
    public required string ProductName { get; set; }
    public required int Quantity { get; set; }
    public required decimal UnitPrice { get; set; }
}