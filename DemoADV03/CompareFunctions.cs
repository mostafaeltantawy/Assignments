using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV03
{
    internal class CompareFunctions
    {
        public static bool CompareGreater(int x , int y)
            => x > y;

        public static bool CompareLess(int x, int y)
            => x < y;

        public static bool CompareString(string x, string y)
            => x?.Length > y?.Length;
            
    }
}
