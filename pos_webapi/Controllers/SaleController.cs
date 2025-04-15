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
    public IEnumerable<Sale> Get()
    {
        return _dbCtx.Sale;
    }

    [HttpPost]
    public ActionResult<Sale> Post(Sale sale)
    {
        _dbCtx.Sale.Add(sale);
        _dbCtx.SaveChanges();
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