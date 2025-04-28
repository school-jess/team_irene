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
    public IEnumerable<SaleDetailDTO> GetAllSaleDetails()
    {
        return from saleDetail in _dbCtx.SaleDetail
               select new SaleDetailDTO()
               {
                   SaleDetailID = saleDetail.sale_detail_id,
                   SaleID = saleDetail.sale_id,
                   ProductName = saleDetail.Product.product_name,
                   Quantity = saleDetail.quantity,
                   UnitPrice = saleDetail.unit_price
               };
    }

    [HttpPost]
    public ActionResult<SaleDetailDTO> Post(SaleDetailCreationDTO saleDetailCreationDTO)
    {
        var sale = _dbCtx.Sale.Find(saleDetailCreationDTO.SaleID);
        var product = _dbCtx.Product.Find(saleDetailCreationDTO.ProductID);
        if (sale == null)
        {
            return BadRequest("Sale doesn't exists");
        }
        if (product == null)
        {
            return BadRequest("Product doesn't exists");
        }
        var saleDetail = new SaleDetail()
        {
            sale_id = saleDetailCreationDTO.SaleID,
            Product = product,
            Sale = sale,
            product_id = product.product_id,
            quantity = saleDetailCreationDTO.Quantity,
            sale_detail_id = saleDetailCreationDTO.SaleDetailID,
            unit_price = saleDetailCreationDTO.UnitPrice
        };
        _dbCtx.SaleDetail.Add(saleDetail);
        _dbCtx.SaveChanges();
        var saleDetailDTO = new SaleDetailDTO()
        {
            SaleDetailID = saleDetailCreationDTO.SaleDetailID,
            ProductName = product.product_name,
            SaleID = sale.sale_id,
            Quantity = saleDetailCreationDTO.Quantity,
            UnitPrice = saleDetailCreationDTO.UnitPrice
        };
        return CreatedAtAction(nameof(Get), new { id = saleDetailDTO.SaleDetailID }, saleDetailDTO);
    }

    // [HttpPut("{id}")]
    // public IActionResult Put(int id, SaleDetailDTO saleDetailDTO)
    // {
    //     var saleDetail = _dbCtx.Sale.Find(saleDetailDTO.SaleID);
    //     if (saleDetail == null)
    //     {
    //         return NotFound();
    //     }
    //     if (id != saleDetail.sale_id)
    //     {
    //         return BadRequest();
    //     }
    //     _dbCtx.Entry(saleDetail).State = EntityState.Modified;
    //     _dbCtx.SaveChanges();
    //     return NoContent();
    // }

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