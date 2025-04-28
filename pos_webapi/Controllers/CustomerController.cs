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
    public IEnumerable<CustomerDTO> Get()
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

    [HttpPost]
    public ActionResult<CustomerDTO> Post(Customer customer)
    {
        _dbCtx.Customer.Add(customer);
        _dbCtx.SaveChanges();
        var customerDTO = new CustomerDTO()
        {
            CustomerID = customer.customer_id,
            FirstName = customer.first_name,
            LastName = customer.last_name,
            Email = customer.email,
            PhoneNumber = customer.phone_number,
            CreatedAt = customer.created_at
        };
        return CreatedAtAction(nameof(Get), new { id = customer.customer_id }, customerDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Customer customer)
    {
        if (id != customer.customer_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(customer).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.Customer.Any(customer => customer.customer_id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
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
