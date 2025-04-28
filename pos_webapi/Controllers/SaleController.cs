using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class SaleController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public SaleController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<SaleDTO> Get()
    {
        return from sale in _dbCtx.Sale
               select new SaleDTO()
               {
                   SaleID = sale.sale_id,
                   CustomerName = $"{sale.Customer.first_name} {sale.Customer.last_name}",
                   EmployeeName = $"{sale.Employee.first_name} {sale.Employee.last_name}",
                   SaleDate = sale.sale_date,
                   TotalAmount = sale.total_amount
               };
    }

    [HttpPost]
    public ActionResult<SaleDTO> Post(Sale sale)
    {
        var customer = _dbCtx.Customer.Find(sale.customer_id);
        var employee = _dbCtx.Employee.Find(sale.employee_id);
        if (customer == null)
        {
            return BadRequest("Customer not found");
        }
        if (employee == null)
        {
            return BadRequest("Employee not found");
        }
        sale.Customer = customer;
        sale.Employee = employee;
        _dbCtx.Sale.Add(sale);
        _dbCtx.SaveChanges();
        var saleDTO = new SaleDTO()
        {
            SaleID = sale.sale_id,
            CustomerName = $"{customer.first_name} {customer.last_name}",
            EmployeeName = $"{employee.first_name} {employee.last_name}",
            SaleDate = sale.sale_date,
            TotalAmount = sale.total_amount
        };
        return CreatedAtAction(nameof(Get), new { id = sale.sale_id }, sale);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Sale sale)
    {
        if (id != sale.sale_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(sale).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.Sale.Any(sale => sale.sale_id == id))
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
        var sale = _dbCtx.Sale.Find(id);
        if (sale == null)
        {
            return NotFound();
        }
        _dbCtx.Sale.Remove(sale);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}