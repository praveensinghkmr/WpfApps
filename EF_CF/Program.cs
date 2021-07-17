using EF_CF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department
            {
                Name = "waert",
                Employees = new List<Employee>
                {
                    new Employee() {Name = "Jack"},
                    new Employee() {Name = "Kim"},
                    new Employee() {Name = "Shen"}
                }
            };
            DataAccessHelper dbHelper = new DataAccessHelper();
            dbHelper.AddDepartment(department);
            var addedDepartment = dbHelper.FetchDepartments().FirstOrDefault();
            if (addedDepartment != null)
            {
                Console.WriteLine("Department Name is: " + addedDepartment.Name + Environment.NewLine);
                Console.WriteLine("Department Employees are: " + Environment.NewLine);

                foreach (var addedDepartmentEmployee in addedDepartment.Employees)
                {
                    Console.WriteLine(addedDepartmentEmployee.Name + Environment.NewLine);
                }

                Console.ReadLine();
            }
        }
    }
}
