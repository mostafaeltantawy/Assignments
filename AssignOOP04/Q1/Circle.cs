
using AssignOOP04.Q1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP04.Q1
{
    internal class Circle : ICircle
    {
        #region Props
        double diameter;
        public double Radius
        {
            get => diameter;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(" Diameter must be >= 0  ");
                }
                else
                {
                    diameter = value;
                    area = Math.Pow(diameter, 2) * Math.PI;
                }
            }
        }
        double area;
        public double Area { get => area; }

        #endregion

        #region Constructors
        public Circle(double diameter)
        {
            Radius = diameter;
        }
        public Circle()
        {

        }
        #endregion


        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Diameter  = {Radius} , Area = {Area}");
        }

        #endregion


    }
}
