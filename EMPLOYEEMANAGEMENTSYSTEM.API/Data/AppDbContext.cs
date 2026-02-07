using Microsoft.EntityFrameworkCore;
using EMPLOYEEMANAGEMENTSYSTEM.API.Models;
namespace EMPLOYEEMANAGEMENTSYSTEM.API.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
