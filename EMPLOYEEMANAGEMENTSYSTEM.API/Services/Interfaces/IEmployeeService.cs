using EMPLOYEEMANAGEMENTSYSTEM.API.Models;
namespace EMPLOYEEMANAGEMENTSYSTEM.API.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<Employee?> UpdateEmployeeAsync(int id, Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
