using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;

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