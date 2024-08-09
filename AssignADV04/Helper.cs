using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV04
{
    internal class Helper
    {
        public static int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            // Check if the birthday has occurred yet this year
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
