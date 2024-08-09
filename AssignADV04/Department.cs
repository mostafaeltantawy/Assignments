using AssignADV04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AssignADV04
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();


        public void DisplayStaff()
        {
            foreach (Employee emp in Staff)
            {
                Console.WriteLine(emp);
            }
        }
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.NegativeVacationStock || e.Cause == LayOffCause.AgeAboveSixty)
            {
                Staff.Remove(sender as Employee);
            }
        }
    }
}
