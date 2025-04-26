using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class SaleDetailController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public SaleDetailController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<Sale> Get()
    {
        return _dbCtx.Sale;
    }

    [HttpPost]
    public ActionResult<SaleDetail> Post(SaleDetail saleDetail)
    {
        _dbCtx.SaleDetail.Add(saleDetail);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = saleDetail.sale_detail_id }, saleDetail);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, SaleDetail saleDetail)
    {
        if (id != saleDetail.sale_detail_id)
        {

            return BadRequest();
        }
        _dbCtx.Entry(saleDetail).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.SaleDetail.Any(sale => sale.sale_detail_id == id))
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
        var sale = _dbCtx.SaleDetail.Find(id);
        if (sale == null)
        {
            return NotFound();
        }
        _dbCtx.SaleDetail.Remove(sale);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}