using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    internal struct Point
    {
        public int X;
        public int Y;

        // By default => Compiler will always generate Parameterless Constuctor that intialize attributes with default  values 
        // And still generate it although define a user defined constructor

        // When create a user defined counstructor in struct should intialize all attributes

        public Point(int _x , int _y)
        {
            X = _x;
            Y = _y;
        }

        public Point(int number )
        {
            X = Y = number;
        }

        //public Point()
        //{
        //    x = 1;
        //    y = 2;    
        //}

        public override string ToString() 
        {
            return $"({X} , {Y})"; 
        }


    }

}
