using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Models
{
    // View MOdel : Class represent data that will be rendered
    internal class EmployeeViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static explicit operator EmployeeViewModel(Employee employee)
        {
            string[]? names = employee?.FullName?.Split(' '); 
            return new EmployeeViewModel() 
            {
                Email = employee?.Email ?? string.Empty,
                FirstName = names?.Length > 0 ? names[0] : string.Empty,
                LastName = names?.Length > 1 ? names[1] : string.Empty,
            };
        }

    }
}
