using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pos_library.models;

public class Customer
{
    [Key]
    public int customer_id
    {
        get => _customerId; set
        {
            _customerId = value;
        }
    }
    private int _customerId;
    [MaxLength(20)]
    public string first_name
    {
        get => _firstName; set
        {
            _firstName = value;
        }
    }
    private string _firstName;
    [MaxLength(20)]
    public string last_name
    {
        get => _lastName; set
        {
            _lastName = value;
        }
    }
    private string _lastName;
    [MaxLength(255)]
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
    public int sale_id
    {
        get => _saleId; set
        {
            _saleId = value;
        }
    }
    private int _saleId;
    public virtual Customer Customer
    {
        get => _Customer; set
        {
            _Customer = value;
        }
    }
    private Customer _Customer;
    public virtual Employee Employee
    {
        get => _Employee; set
        {
            _Employee = value;
        }
    }
    private Employee _Employee;
    public DateTime sale_date
    {
        get => _saleDate; set
        {
            _saleDate = value;
        }
    }
    private DateTime _saleDate;
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
    public int employee_id
    {
        get => _employeeId; set
        {
            _employeeId = value;
        }
    }
    private int _employeeId;
    [MaxLength(20)]
    public string first_name
    {
        get => _firstName; set
        {
            _firstName = value;
        }
    }
    private string _firstName;
    [MaxLength(20)]
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
    public int sales_detail_id
    {
        get => _salesDetailId; set
        {
            _salesDetailId = value;
        }
    }
    private int _salesDetailId;
    public virtual Sale Sale
    {
        get => _Sale; set
        {
            _Sale = value;
        }
    }
    private Sale _Sale;
    public virtual Product Product
    {
        get => _Product; set
        {
            _Product = value;
        }
    }
    private Product _Product;
    public int quantity
    {
        get => _quantity; set
        {
            _quantity = value;
        }
    }
    private int _quantity;
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
    public int product_id
    {
        get => _productId; set
        {
            _productId = value;
        }
    }
    private int _productId;
    [MaxLength(30)]
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
    public decimal price
    {
        get => _price; set
        {
            _price = value;
        }
    }
    private decimal _price;
    public int stock_quality
    {
        get => _stockQuality; set
        {
            _stockQuality = value;
        }
    }
    private int _stockQuality;
}

public class Inventory
{
    [Key]
    public int inventory_id
    {
        get => _inventoryId; set
        {
            _inventoryId = value;
        }
    }
    private int _inventoryId;
    public virtual Product Product
    {
        get => _Product; set
        {
            _Product = value;
        }
    }
    private Product _Product;
    public int quantity
    {
        get => _quantity; set
        {
            _quantity = value;
        }
    }
    private int _quantity;
    public DateTime last_updated
    {
        get => _lastUpdated; set
        {
            _lastUpdated = value;
        }
    }
    private DateTime _lastUpdated;
}