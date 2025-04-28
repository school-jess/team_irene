using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class InventoryController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public InventoryController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<Inventory> Get()
    {
        return _dbCtx.Inventory
            .Include(i => i.Product)
            .ToList();
    }

    [HttpPost]
    public ActionResult<Inventory> Post(Inventory inventory)
    {
        var product = _dbCtx.Product.Find(inventory.product_id);
        if (product == null)
        {
            return BadRequest("Product not found");
        }
        inventory.Product = product;
        _dbCtx.Inventory.Add(inventory);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = inventory.inventory_id }, inventory);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Inventory inventory)
    {
        if (id != inventory.inventory_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(inventory).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.Inventory.Any(inventory => inventory.inventory_id == id))
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
        var inventory = _dbCtx.Inventory.Find(id);
        if (inventory == null)
        {
            return NotFound();
        }
        _dbCtx.Inventory.Remove(inventory);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}