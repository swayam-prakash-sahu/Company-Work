using ASPDotNetCoreMVC1.Models;

namespace ASPDotNetCoreMVC1.Models
{
    public class EmployeeDbContext
    {
        public EmployeeDbContext()
        {

        }

        public List<Employee> Employees = new List<Employee>
        {
             new Employee { Id =1, Name = "John", Salary = 50000, Department = "HR", Gender = "Male" },
             new Employee { Id =2, Name = "Mary", Salary = 60000, Department = "Payroll", Gender = "Female"  },
             new Employee { Id = 3, Name = "Bob", Salary = 40000, Department = "IT", Gender = "Male" },
             new Employee { Id = 4, Name = "Alice", Salary = 70000, Department = "Support", Gender = "Female" }
        };
    }
}
