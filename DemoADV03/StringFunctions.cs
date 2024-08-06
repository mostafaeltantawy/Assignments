using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV03
{
    internal class StringFunctions
    {
        public static int CountUpperCase(string s)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(s))

                for (int i = 0; i < s.Length; i++)

                    if (char.IsUpper(s[i]))
                        count++;


            return count;
        }
        public static int CountLowerCase(string s)
        {
            int count = 0;
            if (!string.IsNullOrWhiteSpace(s))

                for (int i = 0; i < s.Length; i++)

                    if (char.IsLower(s[i]))
                        count++;


            return count;
        }
    }
}
