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

public class CustomerDetailsDTO
{
    public int CustomerID { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public List<PurchasedDTO> Purchased { get; set; } = new List<PurchasedDTO>();
}

public class PurchasedDTO
{
    public int SaleID { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalAmount { get; set; }
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

public class SaleCreationDTO
{
    public int SaleID { get; set; }
    public int CustomerID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalAmount { get; set; }
}

public class SaleDetailDTO
{
    public int SaleDetailID { get; set; }
    public int SaleID { get; set; }
    public required string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}

public class SaleDetailCreationDTO
{
    public int SaleDetailID { get; set; }
    public int SaleID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}

public class ProductDTO
{
    public int ProductID { get; set; }
    public required string ProductName { get; set; }
    public string? Category { get; set; }
    public required decimal Price { get; set; }
    public required int StockQuality { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class InventoryDTO
{
    public int InventoryID { get; set; }
    public required string ProductName { get; set; }
    public int Quantity { get; set; }
    public DateTime LastUpdated { get; set; }
}

public class InventoryCreationDTO
{
    public int InventoryID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public DateTime LastUpdated { get; set; }
}