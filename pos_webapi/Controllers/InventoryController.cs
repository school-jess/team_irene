using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;

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
        return _dbCtx.Inventory;
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