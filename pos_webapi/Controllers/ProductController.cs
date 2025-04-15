using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public ProductController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _dbCtx.Product;
    }

    [HttpPost]
    public ActionResult<Product> Post(Product product)
    {
        _dbCtx.Product.Add(product);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = product.product_id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Product product)
    {
        if (id != product.product_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(product).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.Product.Any(product => product.product_id == id))
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
        var product = _dbCtx.Product.Find(id);
        if (product == null)
        {
            return NotFound();
        }
        _dbCtx.Product.Remove(product);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}