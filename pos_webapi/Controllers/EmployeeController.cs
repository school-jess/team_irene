using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;

namespace pos_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly DatabaseCtx _dbCtx;
    public EmployeeController(DatabaseCtx dbCtx)
    {
        _dbCtx = dbCtx;
    }

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        return _dbCtx.Employee;
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