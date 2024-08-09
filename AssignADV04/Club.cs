using AssignADV04.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV04
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee emp)
        {
            if(emp is not null)
            {
                Members.Add(emp);
                emp.EmployeeLayOff += RemoveMember;

            }
            else
            {
                throw new ArgumentNullException("Employee Couldn't be null"); 
            }
           
        }
    
        public void RemoveMember (object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.NegativeVacationStock || e.Cause == LayOffCause.Resign || e.Cause == LayOffCause.FaliedToAchieveTarget)
            {
                Members.Remove(sender as Employee);
            }
        }

        public void DisplayStaff()
        {
            foreach (Employee member in Members)
            {
                Console.WriteLine(member);
            }
        }
    }
}
