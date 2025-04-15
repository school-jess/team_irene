using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pos_library.models;

public class Customer
{
    [Key]
    [Required]
    public int customer_id
    {
        get => _customerId; set
        {
            _customerId = value;
        }
    }
    private int _customerId;
    [MaxLength(20)]
    [Required]
    public string first_name
    {
        get => _firstName; set
        {
            _firstName = value;
        }
    }
    private string _firstName;
    [MaxLength(20)]
    [Required]
    public string last_name
    {
        get => _lastName; set
        {
            _lastName = value;
        }
    }
    private string _lastName;
    [MaxLength(255)]
    [Required]
    public string email
    {
        get => _email; set
        {
            _email = value;
        }
    }
    private string _email;
    [MaxLength(13)]
    public string phone_number
    {
        get => _phoneNumber; set
        {
            _phoneNumber = value;
        }
    }
    private string _phoneNumber;
    [Column(TypeName = "timestamp")]
    public DateTime created_at
    {
        get => _createdAt; set
        {
            _createdAt = value;
        }
    }
    private DateTime _createdAt;
}

public class Sale
{
    [Key]
    [Required]
    public int sale_id
    {
        get => _saleId; set
        {
            _saleId = value;
        }
    }
    private int _saleId;
    [Required]
    public virtual Customer Customer
    {
        get => _Customer; set
        {
            _Customer = value;
        }
    }
    [Required]
    private Customer _Customer;
    public virtual Employee Employee
    {
        get => _Employee; set
        {
            _Employee = value;
        }
    }
    private Employee _Employee;
    [Column(TypeName = "timestamp")]
    public DateTime sale_date
    {
        get => _saleDate; set
        {
            _saleDate = value;
        }
    }
    private DateTime _saleDate;
    [Required]
    [Column(TypeName = "decimal(6,2)")]
    public decimal total_amount
    {
        get => _totalAmount; set
        {
            _totalAmount = value;
        }
    }
    private decimal _totalAmount;
}

public class Employee
{
    [Key]
    [Required]
    public int employee_id
    {
        get => _employeeId; set
        {
            _employeeId = value;
        }
    }
    private int _employeeId;
    [MaxLength(20)]
    [Required]
    public string first_name
    {
        get => _firstName; set
        {
            _firstName = value;
        }
    }
    private string _firstName;
    [MaxLength(20)]
    [Required]
    public string last_name
    {
        get => _lastName; set
        {
            _lastName = value;
        }
    }
    private string _lastName;
    [MaxLength(10)]
    public string position
    {
        get => _position; set
        {
            _position = value;
        }
    }
    private string _position;
    [DataType(DataType.Date)]
    public DateTime hire_date
    {
        get => _hireDate; set
        {
            _hireDate = value;
        }
    }
    private DateTime _hireDate;
    [Column(TypeName = "timestamp")]
    public DateTime created_at
    {
        get => _createdAt; set
        {
            _createdAt = value;
        }
    }
    private DateTime _createdAt;
}

public class SaleDetail
{
    [Key]
    [Required]
    public int sale_detail_id
    {
        get => _saleDetailId; set
        {
            _saleDetailId = value;
        }
    }
    private int _saleDetailId;
    [Required]
    public virtual Sale Sale
    {
        get => _Sale; set
        {
            _Sale = value;
        }
    }
    private Sale _Sale;
    [Required]
    public virtual Product Product
    {
        get => _Product; set
        {
            _Product = value;
        }
    }
    private Product _Product;
    [Required]
    public int quantity
    {
        get => _quantity; set
        {
            _quantity = value;
        }
    }
    private int _quantity;
    [Column(TypeName = "decimal(6,2)")]
    [Required]
    public decimal unit_price
    {
        get => _unitPrice; set
        {
            _unitPrice = value;
        }
    }
    private decimal _unitPrice;
}

public class Product
{
    [Key]
    [Required]
    public int product_id
    {
        get => _productId; set
        {
            _productId = value;
        }
    }
    private int _productId;
    [MaxLength(30)]
    [Required]
    public string product_name
    {
        get => _productName; set
        {
            _productName = value;
        }
    }
    private string _productName;
    [MaxLength(30)]
    public string? category
    {
        get => _category; set
        {
            _category = value;
        }
    }
    private string? _category;
    [Column(TypeName = "decimal(6,2)")]
    [Required]
    public decimal price
    {
        get => _price; set
        {
            _price = value;
        }
    }
    private decimal _price;
    [Required]
    public int stock_quality
    {
        get => _stockQuality; set
        {
            _stockQuality = value;
        }
    }
    private int _stockQuality;
    [Column(TypeName = "timestamp")]
    public DateTime created_at
    {
        get => _createdAt; set
        {
            _createdAt = value;
        }
    }
    private DateTime _createdAt;
}

public class Inventory
{
    [Key]
    [Required]
    public int inventory_id
    {
        get => _inventoryId; set
        {
            _inventoryId = value;
        }
    }
    private int _inventoryId;
    [Required]
    public virtual Product Product
    {
        get => _Product; set
        {
            _Product = value;
        }
    }
    private Product _Product;
    [Required]
    public int quantity
    {
        get => _quantity; set
        {
            _quantity = value;
        }
    }
    private int _quantity;
    [Column(TypeName = "timestamp")]
    public DateTime last_updated
    {
        get => _lastUpdated; set
        {
            _lastUpdated = value;
        }
    }
    private DateTime _lastUpdated;
}