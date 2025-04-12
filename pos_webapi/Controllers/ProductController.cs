using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;

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
    public void Post()
    {
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