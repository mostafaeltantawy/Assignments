using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV03
{
    internal class NumbersConditionalFuncs
    {
        public static bool  CheckDivisibleBy7(int number)
        {
            return number %7 == 0; 
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }


    }
}
