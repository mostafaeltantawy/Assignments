using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP05.Q01
{
    public class Point3D : IComparable , ICloneable
    {
        #region Constructors
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D() : this(0, 0, 0)
        {

        }
        public Point3D(double x) : this(x, 0, 0)
        {

        }
        public Point3D(double x, double y) : this(x, y, 0)
        {

        }

        #endregion

        #region Prop
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }



        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"Point coordinates :( {X} , {Y} , {Z} )  ";
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;

            Point3D point = (Point3D)obj;

            int result = X.CompareTo(point.X);

            if (result == 0)
            {
                result = Y.CompareTo(point.Y);
            }

            return result;

        }

        public object Clone()
        {
            return new Point3D(X , Y , Z);
        }
        #endregion

        #region Operators overloading

        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left is null || right is null)
                return false;
            return left?.X == right?.X && left?.Y == right?.Y && left?.Z == right?.Z;
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }
        #endregion


    }
}
