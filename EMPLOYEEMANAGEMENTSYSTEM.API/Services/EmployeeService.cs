using EMPLOYEEMANAGEMENTSYSTEM.API.Models;
using EMPLOYEEMANAGEMENTSYSTEM.API.Services.Interfaces;
using EMPLOYEEMANAGEMENTSYSTEM.API.Repositories.Interfaces;
namespace EMPLOYEEMANAGEMENTSYSTEM.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _repo.GetAllAsync();
        }
        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            await _repo.AddAsync(employee);
            return employee;
        }
        public async Task<Employee?> UpdateEmployeeAsync(int id, Employee employee)
        {
            var existingEmployee = await _repo.GetByIdAsync(id);
            if (existingEmployee == null) return null;
            existingEmployee.Name = employee.Name;
            existingEmployee.Email = employee.Email;
            existingEmployee.Department = employee.Department;
            existingEmployee.DateOfJoining = employee.DateOfJoining;
            await _repo.UpdateAsync(existingEmployee);
            return existingEmployee;
        }
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var existingEmployee = await _repo.GetByIdAsync(id);
            if (existingEmployee == null) return false;
            await _repo.DeleteAsync(existingEmployee);
            return true;
        }
    }
}
