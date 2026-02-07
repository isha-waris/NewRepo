using EMPLOYEEMANAGEMENTSYSTEM.API.Models;
using EMPLOYEEMANAGEMENTSYSTEM.API.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EMPLOYEEMANAGEMENTSYSTEM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _service.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            var employee = await _service.GetEmployeeByIdAsync(id);
            if (employee == null) return new NotFoundResult();
            return  Ok(employee);
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> Create(Employee employee)
        {
            employee.EmployeeId = 0;  

            var createdEmployee = await _service.AddEmployeeAsync(employee);
            return new CreatedAtActionResult(nameof(GetById), "Employee", new { id = createdEmployee.EmployeeId }, createdEmployee);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> Update(int id, Employee employee)
        {
            var updatedEmployee = await _service.UpdateEmployeeAsync(id, employee);
            if (updatedEmployee == null) return new NotFoundResult();
            return  Ok(updatedEmployee);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var success = await _service.DeleteEmployeeAsync(id);
            if (!success) return new NotFoundResult();
            return NoContent();
        }
    }
}
