using AssignOOP05.Q01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP05
{
    static class Utility
    {
       public  static Point3D ReadPoint(string PointString)
        {
            double x, y, z;

            do
            {
                Console.WriteLine($"Please Enter X-Cordinate of {PointString} : ");

            } while (!double.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.WriteLine($"Please Enter Y-Cordinate of  {PointString} : ");

            } while (!double.TryParse(Console.ReadLine(), out y));
            do
            {
                Console.WriteLine($"Please Enter Z-Cordinate of {PointString} : ");

            } while (!double.TryParse(Console.ReadLine(), out z));

            return new Point3D(x, y, z);
        }
    }
}
