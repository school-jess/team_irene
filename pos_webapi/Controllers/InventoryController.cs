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
    public IEnumerable<InventoryDTO> GetAllInventories()
    {
        return from inventory in _dbCtx.Inventory
               select new InventoryDTO()
               {
                   InventoryID = inventory.inventory_id,
                   LastUpdated = inventory.last_updated,
                   ProductName = inventory.Product.product_name,
                   Quantity = inventory.quantity
               };
    }

    [HttpPost]
    public ActionResult<InventoryDTO> Post(InventoryCreationDTO inventoryCreationDTO)
    {
        var product = _dbCtx.Product.Find(inventoryCreationDTO.ProductID);
        if (product == null)
        {
            return BadRequest("Product not found");
        }
        var inventory = new Inventory()
        {
            inventory_id = inventoryCreationDTO.InventoryID,
            last_updated = inventoryCreationDTO.LastUpdated,
            Product = product,
            product_id = product.product_id,
            quantity = inventoryCreationDTO.Quantity
        };
        _dbCtx.Inventory.Add(inventory);
        _dbCtx.SaveChanges();
        var inventoryDTO = new InventoryDTO()
        {
            InventoryID = inventoryCreationDTO.InventoryID,
            LastUpdated = inventoryCreationDTO.LastUpdated,
            ProductName = product.product_name,
            Quantity = inventoryCreationDTO.Quantity
        };
        return CreatedAtAction(nameof(GetAllInventories), new { id = inventory.inventory_id }, inventoryDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, InventoryCreationDTO inventoryCreationDTO)
    {
        var inventory = _dbCtx.Inventory.Find(inventoryCreationDTO.InventoryID);
        if (inventory == null)
        {
            return NotFound();
        }
        if (id != inventory.inventory_id)
        {
            return BadRequest();
        }
        var product = _dbCtx.Product.Find(inventoryCreationDTO.ProductID);
        _dbCtx.Entry(inventory).State = EntityState.Modified;
        inventory.inventory_id = inventoryCreationDTO.InventoryID;
        inventory.product_id = inventoryCreationDTO.ProductID;
        inventory.Product = product;
        inventory.last_updated = inventoryCreationDTO.LastUpdated;
        inventory.quantity = inventoryCreationDTO.Quantity;
        _dbCtx.SaveChanges();
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