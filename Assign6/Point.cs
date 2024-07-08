using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    internal struct Point
    {
        public double X , Y;
        public Point(double x , double y )
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"( {X} , {Y} )"; 
        }
    }
}
