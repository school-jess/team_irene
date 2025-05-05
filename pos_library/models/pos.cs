using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace pos_library.models;

[Index(nameof(email), IsUnique = true)]
public class Customer
{
    [Key]
    public required int customer_id { get; set; }
    [MaxLength(20)]
    public required string first_name { get; set; }
    [MaxLength(20)]
    public required string last_name { get; set; }
    [MaxLength(255)]
    public required string email { get; set; }
    [MaxLength(13)]
    public string? phone_number { get; set; }
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
    public List<Sale> Sales { get; set; } = new List<Sale>();
}

public class Sale
{
    [Key]
    public required int sale_id { get; set; }
    [ForeignKey("Customer")]
    public int customer_id { get; set; }
    public virtual Customer Customer { get; set; }
    [ForeignKey("Employee")]
    public required int employee_id { get; set; }
    public virtual Employee Employee { get; set; }
    [Column(TypeName = "timestamp")]
    public DateTime? sale_date { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public required decimal total_amount { get; set; }
    public List<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}

public class Employee
{
    [Key]
    public required int employee_id { get; set; }
    [MaxLength(20)]
    public required string first_name { get; set; }
    [MaxLength(20)]
    public required string last_name { get; set; }
    [MaxLength(10)]
    public string? position { get; set; }
    [DataType(DataType.Date)]
    public DateTime? hire_date { get; set; }
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
    public List<Sale> Sales { get; set; } = new List<Sale>();
}

public class SaleDetail
{
    [Key]
    public required int sale_detail_id { get; set; }
    [ForeignKey("Sale")]
    public required int sale_id { get; set; }
    public virtual Sale Sale { get; set; }
    [ForeignKey("Product")]
    public required int product_id { get; set; }
    public virtual Product Product { get; set; }
    public required int quantity { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public required decimal unit_price { get; set; }
}

public class Product
{
    [Key]
    public required int product_id { get; set; }
    [MaxLength(30)]
    public required string product_name { get; set; }
    [MaxLength(30)]
    public string? category { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public required decimal price { get; set; }
    public required int stock_quality { get; set; }
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
    public List<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}

public class Inventory
{
    [Key]
    public required int inventory_id { get; set; }
    [ForeignKey("Product")]
    public required int product_id { get; set; }
    public virtual Product Product { get; set; }
    public required int quantity { get; set; }
    [Column(TypeName = "timestamp")]
    public DateTime? last_updated { get; set; }
}
