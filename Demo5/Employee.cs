using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    internal class Employee
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }

        public Department Department { get; set; }
    }
    class Department
    {
        public int Code { get; set; }

        public string Name { get; set; }
    }

}
