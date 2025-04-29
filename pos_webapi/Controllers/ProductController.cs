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
    public IEnumerable<ProductDTO> GetAllProducts()
    {
        return from product in _dbCtx.Product
               select new ProductDTO()
               {
                   ProductID = product.product_id,
                   Category = product.category,
                   CreatedAt = product.created_at,
                   Price = product.price,
                   ProductName = product.product_name,
                   StockQuality = product.stock_quality
               };
    }

    [HttpPost]
    public ActionResult<ProductDTO> Post(ProductDTO productDTO)
    {
        var product = new Product()
        {
            category = productDTO.Category,
            created_at = productDTO.CreatedAt,
            price = productDTO.Price,
            product_id = productDTO.ProductID,
            product_name = productDTO.ProductName,
            stock_quality = productDTO.StockQuality
        };
        _dbCtx.Product.Add(product);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(GetAllProducts), new { id = product.product_id }, productDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, ProductDTO productDTO)
    {
        var product = _dbCtx.Product.Find(productDTO.ProductID);
        if (product == null)
        {
            return NotFound();
        }
        if (id != product.product_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(product).State = EntityState.Modified;
        product.category = productDTO.Category;
        product.created_at = productDTO.CreatedAt;
        product.price = productDTO.Price;
        product.product_id = productDTO.ProductID;
        product.product_name = productDTO.ProductName;
        product.stock_quality = productDTO.StockQuality;
        _dbCtx.SaveChanges();
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