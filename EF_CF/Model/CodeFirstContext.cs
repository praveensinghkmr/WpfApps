using System.Data.Entity;

namespace EF_CF.Model
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
