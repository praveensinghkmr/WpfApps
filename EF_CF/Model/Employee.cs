﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Departments { get; set; }
    }
}
