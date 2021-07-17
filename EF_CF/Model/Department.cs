using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
