using Microsoft.EntityFrameworkCore;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Models
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CodeFirstApproach.Models.ErrorViewModel> ErrorViewModel { get; set; } = default!;
    }
}
