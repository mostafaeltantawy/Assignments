using AssignOOP04.Q1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP04.Q1
{
    internal class Rectangle : IRectangle
    {
        #region props
        double width;
        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be >= 0  ");

                }
                else
                {
                    width = value;
                    area = width * height;
                }
            }
        }

        double height;
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be >= 0  ");

                }
                else
                {
                    height = value;
                    area = width * height;
                }

            }
        }

        double area;

        public double Area { get => area; }

        #endregion



        #region Constructors
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle() { }

        #endregion


        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Width = {width} , Height = {height} , Area = {area} ");

        }

        #endregion

    }
}
