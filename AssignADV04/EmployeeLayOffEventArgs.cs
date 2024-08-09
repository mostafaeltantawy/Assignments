using AssignADV04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV04
{
    public class EmployeeLayOffEventArgs :EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
