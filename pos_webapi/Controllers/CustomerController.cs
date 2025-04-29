using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public CustomerController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<CustomerDTO> GetAllCustomers()
    {
        return from customer in _dbCtx.Customer
               select new CustomerDTO()
               {
                   CustomerID = customer.customer_id,
                   FirstName = customer.first_name,
                   LastName = customer.last_name,
                   Email = customer.email,
                   PhoneNumber = customer.phone_number,
                   CreatedAt = customer.created_at
               };
    }

    [HttpGet("{id}")]
    public ActionResult<CustomerDetailsDTO> GetSpecificCustomer(int id)
    {
        var customer = _dbCtx.Customer.Include(c => c.Sales).Where(c => c.customer_id == id).Select(c => c).First();
        if (customer == null)
        {
            return BadRequest("Customer not found");
        }
        var customerDetailsDTO = new CustomerDetailsDTO()
        {
            CustomerID = customer.customer_id,
            Email = customer.email,
            FullName = $"{customer.first_name} {customer.last_name}",
            PhoneNumber = customer.phone_number,
        };
        foreach (var sale in customer.Sales)
        {
            customerDetailsDTO.Purchased.Add(new PurchasedDTO()
            {
                SaleID = sale.sale_id,
                SaleDate = sale.sale_date,
                TotalAmount = sale.total_amount
            });
        }
        return Ok(customerDetailsDTO);
    }

    [HttpPost]
    public ActionResult<CustomerDTO> Post(CustomerDTO customerDTO)
    {
        var customer = new Customer()
        {
            customer_id = customerDTO.CustomerID,
            created_at = customerDTO.CreatedAt,
            email = customerDTO.Email,
            first_name = customerDTO.FirstName,
            last_name = customerDTO.LastName,
            phone_number = customerDTO.PhoneNumber
        };
        _dbCtx.Customer.Add(customer);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(GetAllCustomers), new { id = customerDTO.CustomerID }, customerDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, CustomerDTO customerDTO)
    {
        var customer = _dbCtx.Customer.Find(customerDTO.CustomerID);
        if (customer == null)
        {
            return NotFound();
        }
        if (id != customer.customer_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(customer).State = EntityState.Modified;
        customer.customer_id = customerDTO.CustomerID;
        customer.created_at = customerDTO.CreatedAt;
        customer.email = customerDTO.Email;
        customer.first_name = customerDTO.FirstName;
        customer.last_name = customerDTO.LastName;
        customer.phone_number = customerDTO.PhoneNumber;
        _dbCtx.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var customer = _dbCtx.Customer.Find(id);
        if (customer == null)
        {
            return NotFound();
        }
        _dbCtx.Customer.Remove(customer);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}
