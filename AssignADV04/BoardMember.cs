using AssignADV04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV04
{
    internal class BoardMember : Employee
    {
        public BoardMember(int employeeID, DateTime birthDate, int vacationStock = 30) : base(employeeID, birthDate, vacationStock)
        {
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resign });
        }

        public override void EndOfYearOperation()
        {
   
        }
    }
}
