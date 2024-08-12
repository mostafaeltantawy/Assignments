﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ01
{
    internal static class IntExtension
    {
        public static int Reverse(this int Number)
        {
            int ReverseNumber = 0, LastDigit;

            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReverseNumber = ReverseNumber * 10 + LastDigit;
                Number /= 10;
            }
            return ReverseNumber;
        }
    }
}