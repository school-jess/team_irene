using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace pos_library.models;

[Index(nameof(email), IsUnique = true)]
public class Customer
{
    [Key]
    [Required]
    public int customer_id { get; set; }

    [Required]
    [MaxLength(20)]
    public required string first_name { get; set; }

    [Required]
    [MaxLength(20)]
    public required string last_name { get; set; }

    [Required]
    [MaxLength(255)]
    public required string email { get; set; }

    [MaxLength(13)]
    public required string phone_number { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime created_at { get; set; }

    public List<Sale>? Sales { get; set; } = new List<Sale>();
}

public class Sale
{
    [Key]
    [Required]
    public int sale_id { get; set; }

    [Required]
    [ForeignKey("Customer")]
    public int customer_id { get; set; }
    public virtual Customer? Customer { get; set; }

    [Required]
    [ForeignKey("Employee")]
    public int employee_id { get; set; }
    public virtual Employee? Employee { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime sale_date { get; set; }

    [Required]
    [Column(TypeName = "decimal(6,2)")]
    public decimal total_amount { get; set; }

    public List<SaleDetail>? SaleDetails { get; set; } = new List<SaleDetail>();
}

public class Employee
{
    [Key]
    [Required]
    public int employee_id { get; set; }

    [MaxLength(20)]
    [Required]
    public required string first_name { get; set; }

    [MaxLength(20)]
    [Required]
    public required string last_name { get; set; }

    [MaxLength(10)]
    public string? position { get; set; }

    [DataType(DataType.Date)]
    public DateTime hire_date { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime created_at { get; set; }

    public List<Sale>? Sales { get; set; }
}

public class SaleDetail
{
    [Key]
    [Required]
    public int sale_detail_id { get; set; }

    [Required]
    [ForeignKey("Sale")]
    public int sale_id { get; set; }
    public virtual Sale? Sale { get; set; }

    [Required]
    [ForeignKey("Product")]
    public int product_id { get; set; }
    public virtual Product? Product { get; set; }

    [Required]
    public required int quantity { get; set; }

    [Required]
    [Column(TypeName = "decimal(6,2)")]
    public required decimal unit_price { get; set; }
}

public class Product
{
    [Key]
    [Required]
    public int product_id { get; set; }

    [MaxLength(30)]
    [Required]
    public required string product_name { get; set; }

    [MaxLength(30)]
    public string? category { get; set; }

    [Required]
    [Column(TypeName = "decimal(6,2)")]
    public required decimal price { get; set; }

    [Required]
    public required int stock_quality { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime created_at { get; set; }

    public List<SaleDetail>? SaleDetails { get; set; }
}

public class Inventory
{
    [Key]
    [Required]
    public int inventory_id { get; set; }

    [Required]
    [ForeignKey("Product")]
    public int product_id { get; set; }
    public virtual Product? Product { get; set; }

    [Required]
    public int quantity { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime last_updated { get; set; }
}
