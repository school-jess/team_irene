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
    public IEnumerable<EmployeeDTO> GetAllEmployees()
    {
        return from employee in _dbCtx.Employee
               select new EmployeeDTO()
               {
                   EmployeeID = employee.employee_id,
                   FirstName = employee.first_name,
                   LastName = employee.last_name,
                   Position = employee.position,
                   HireDate = employee.hire_date,
                   CreatedAt = employee.created_at
               };
    }

    [HttpGet("{id}")]
    public ActionResult<EmployeeDetailsDTO> GetSpecificeEmployee(int id)
    {
        var employee = _dbCtx.Employee.Find(id);
        if (employee == null)
        {
            return BadRequest("Customer not found");
        }
        var employeeDetailsDTO = new EmployeeDetailsDTO()
        {
            EmployeeID = employee.employee_id,
            FullName = $"{employee.first_name} {employee.last_name}",
        };
        foreach (var sale in employee.Sales)
        {
            employeeDetailsDTO.Purchased.Add(new PurchasedDTO()
            {
                SaleID = sale.sale_id,
                SaleDate = sale.sale_date,
                TotalAmount = sale.total_amount
            });
        }
        return Ok(employeeDetailsDTO);
    }

    [HttpPost]
    public ActionResult<EmployeeDTO> Post(EmployeeDTO employeeDTO)
    {
        var employee = new Employee()
        {
            employee_id = employeeDTO.EmployeeID,
            first_name = employeeDTO.FirstName,
            last_name = employeeDTO.LastName,
            position = employeeDTO.Position,
            hire_date = employeeDTO.HireDate,
            created_at = employeeDTO.CreatedAt
        };
        _dbCtx.Employee.Add(employee);
        _dbCtx.SaveChanges();
        return CreatedAtAction(nameof(GetAllEmployees), new { id = employeeDTO.EmployeeID }, employeeDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, EmployeeDTO employeeDTO)
    {
        var employee = _dbCtx.Employee.Find(employeeDTO.EmployeeID);
        if (employee == null)
        {
            return NotFound();
        }
        if (id != employee.employee_id)
        {
            return BadRequest();
        }
        _dbCtx.Entry(employee).State = EntityState.Modified;
        employee.employee_id = employeeDTO.EmployeeID;
        employee.first_name = employeeDTO.FirstName;
        employee.last_name = employeeDTO.LastName;
        employee.position = employeeDTO.Position;
        employee.hire_date = employeeDTO.HireDate;
        employee.created_at = employeeDTO.CreatedAt;
        _dbCtx.SaveChanges();
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