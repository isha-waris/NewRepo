using EMPLOYEEMANAGEMENTSYSTEM.API.Models;
namespace EMPLOYEEMANAGEMENTSYSTEM.API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Employee employee);
    }
}
