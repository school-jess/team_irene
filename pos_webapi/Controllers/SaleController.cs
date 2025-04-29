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
    public IEnumerable<SaleDTO> GetAllSales()
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
    public ActionResult<SaleDTO> Post(SaleCreationDTO saleCreationDTO)
    {
        var customer = _dbCtx.Customer.Find(saleCreationDTO.CustomerID);
        var employee = _dbCtx.Employee.Find(saleCreationDTO.EmployeeID);
        if (customer == null)
        {
            return BadRequest("Customer not found");
        }
        if (employee == null)
        {
            return BadRequest("Employee not found");
        }
        var sale = new Sale()
        {
            sale_id = saleCreationDTO.SaleID,
            customer_id = saleCreationDTO.SaleID,
            total_amount = saleCreationDTO.TotalAmount,
            sale_date = saleCreationDTO.SaleDate,
            employee_id = employee.employee_id,
            Customer = customer,
            Employee = employee
        };
        _dbCtx.Sale.Add(sale);
        _dbCtx.SaveChanges();
        var saleDTO = new SaleDTO()
        {
            SaleID = saleCreationDTO.SaleID,
            CustomerName = $"{customer.first_name} {customer.last_name}",
            EmployeeName = $"{employee.first_name} {employee.last_name}",
            SaleDate = saleCreationDTO.SaleDate,
            TotalAmount = saleCreationDTO.TotalAmount
        };
        return CreatedAtAction(nameof(GetAllSales), new { id = saleDTO.SaleID }, saleDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, SaleCreationDTO saleCreationDTO)
    {
        var sale = _dbCtx.Sale.Find(saleCreationDTO.SaleID);
        if (sale == null)
        {
            return NotFound();
        }
        if (id != sale.sale_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(sale).State = EntityState.Modified;
        _dbCtx.SaveChanges();
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