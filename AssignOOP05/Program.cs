
using AssignOOP05.Q01;
using AssignOOP05.Q02;
using AssignOOP05.Q03;

namespace AssignOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1

            #region Override the ToString Function to produce this output:
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P);

            #endregion

            #region Read from the User the Coordinates for 2 points P1, P2  ant use  '=='
            //Point3D P1 = Utility.ReadPoint("#1");
            //Point3D P2 = Utility.ReadPoint("#2");

            //if (P1 == P2) // it doesn't work prop because it Compares to objects not to points so it nead to be overloading
            //    Console.WriteLine("Same Point ");
            //else
            //    Console.WriteLine("Different Point ");

            #endregion

            #region Implement IComparable
            //    Point3D[] points = {
            //    new Point3D(3, 5, 1),
            //    new Point3D(1, 2, 9),
            //    new Point3D(2, 2, 5),
            //    new Point3D(3, 2, 7),
            //    new Point3D(1, 5, 4),
            //    null
            //};

            //    foreach (Point3D point in points)
            //    {
            //        if (point is null)
            //            Console.WriteLine("OOOOOOOOOOOOO");

            //        Console.WriteLine(point);
            //    }

            #endregion

            #region Implement ICloneable 
            //Point3D point = new Point3D(10, 10, 10);
            //Point3D point2 =  (Point3D)point.Clone();
            //Console.WriteLine($"HASHCODE OF POINT : {point.GetHashCode()}");
            //Console.WriteLine($"HASHCODE OF POINT2 : {point2.GetHashCode()}");


            #endregion




            #endregion

            #region #2
            //Console.WriteLine(Maths.Add(3, 4));
            //Console.WriteLine(Maths.Subtract(3, 4));
            //Console.WriteLine(Maths.Multiply(3, 4));
            //Console.WriteLine(Maths.Divide(3, 4));

            #endregion

            #region #3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);



            //Console.WriteLine(D1 + D2);

            //Console.WriteLine(D1 + 7800); // Achieved by implicit casting
            //Console.WriteLine(666 + D1); // Achieved by implicit casting

            ////Duration D5 = ++D1;

            ////Console.WriteLine(D1);
            ////Console.WriteLine(D5);

            //Duration D6 = --D1;
            //Console.WriteLine(D1);
            //Console.WriteLine(D6);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //Console.WriteLine(D1 > D2);
            //Console.WriteLine(D1 <= D2);
            //if (D1)
            //{
            //    Console.WriteLine("the object existed");
            //}

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);





            #endregion

        }


    }

}
