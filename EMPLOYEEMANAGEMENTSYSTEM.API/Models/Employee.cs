namespace EMPLOYEEMANAGEMENTSYSTEM.API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }= null!;
        public string Email { get; set; }= null!;
        public string Department { get; set; }= null!;
        public DateTime DateOfJoining { get; set; }

    }
}
