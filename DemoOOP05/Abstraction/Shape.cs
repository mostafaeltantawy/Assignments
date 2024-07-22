using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Abstraction
{
    internal abstract class Shape
    {
        //Abstract class : Is a partial Implementaion to another class 
        //Can not create an object from it
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Perimeter { get; }

        public abstract decimal CalcArea();
    }

    abstract class RecBase : Shape
    {


        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Rectangle [Concrete class] => Fully implemented class

    class Rectangle : RecBase
    {
        public override decimal Perimeter => (Dim01 + Dim02) * 2;


    }

    class Square : RecBase
    {
        public Square(decimal dim)
        {
            Dim01 = Dim02 = dim;
        }
        public override decimal Perimeter => Dim01 * 4;


    }

    class Circle : Shape
    {
        public Circle(decimal Radius)
        {
            Dim01 = Dim02 = Radius;
        }
        public override decimal Perimeter => 2 * Dim02 * 3.14m;

        public override decimal CalcArea()
        {
           return Dim01*Dim01*3.14m;
        }
    }


}
