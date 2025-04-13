using pos_library.models;
using pos_library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public ActionResult<Employee> Post(Employee employee)
    {
        _dbCtx.Employee.Add(employee);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = employee.employee_id }, employee);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Employee employee)
    {
        if (id != employee.employee_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(employee).State = EntityState.Modified;
        try
        {
            _dbCtx.SaveChanges();
        }
        catch (DbUpdateException)
        {
            if (!_dbCtx.Employee.Any(employee => employee.employee_id == id))
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
        var employee = _dbCtx.Employee.Find(id);
        if (employee == null)
        {
            return NotFound();
        }
        _dbCtx.Employee.Remove(employee);
        _dbCtx.SaveChanges();
        return NoContent();
    }
}