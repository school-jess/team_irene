using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;

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
    public IEnumerable<Customer> Get()
    {
        return _dbCtx.Customer;
    }

    [HttpPost]
    public ActionResult<Customer> Post(Customer customer)
    {
        _dbCtx.Customer.Add(customer);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = customer.customer_id }, customer);
    }

    [HttpPut]
    public void Put()
    {
    }

    [HttpPatch]
    public void Patch()
    {
    }

    [HttpDelete]
    public void Delete()
    {
    }
}