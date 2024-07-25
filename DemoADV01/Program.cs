using DemoADV01.Generics;

namespace DemoADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics [SWAP]


            //int A = 10, B = 30;
            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine("After SWAP");

            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");

            //double X = 10.45, Y = 30.23;
            //Console.WriteLine($"A = {X} ");
            //Console.WriteLine($"B = {Y} ");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine("After SWAP");

            //Console.WriteLine($"A = {A} ");
            //Console.WriteLine($"B = {B} ");

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(22, 30);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            #endregion

            #region Generics [Search]
            //int[] numbers = { 1, 2, 32, 14, 5, 6, 73, 8, 9, 10, 21, };

            //int index = Helper<int>.SearchArray(numbers, 73);
            //Console.WriteLine(index);
            #region In value type [Struct]
            ////Equals compare object state 

            //Employee E01 = new Employee() { Id = 10, Name = "Mostafa", Salary = 1000 };
            //Employee E02 = new Employee() { Id = 10, Name = "Zalta", Salary = 1000 };
            ////if (E01 == E02)
            ////{
            ////    Console.WriteLine("Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Equal");
            ////}

            ////if (E01.Equals(E02))
            ////{
            ////    Console.WriteLine("Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Equal");
            ////}


            //Employee[] empolyess =
            //{
            //    new Employee() { Id = 10,Name ="ali" ,   Salary = 1000 },
            //    E02,
            //    E01
            //};

            //int index = Helper<Employee>.SearchArray(empolyess,  E01/*new Employee() { Id = 12, Name = "osama", Salary = 9000 }*/);
            //Console.WriteLine(index);

            #endregion

            #region In Reference Type 
            //Employee E01 = new Employee() { Id = 10, Name = "Mostafa", Salary = 1000 };
            //Employee E02 = new Employee() { Id = 10, Name = "Mostafa", Salary = 1000 };

            //Console.WriteLine($"HC EMP01 = {E01.GetHashCode()}");
            //Console.WriteLine($"HC EMP02 = {E02.GetHashCode()}");

            ////if (E01 == E02) // valid // it compare references  [Identity]
            ////{
            ////    Console.WriteLine("Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Not Equal");
            ////}

            //if (E01.Equals(E02))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}
            #endregion





            #endregion

            #region Generics [Sort] 
            //int[] Numbers = { 12, 25, 3, 6, 9, 5, 20, 1, 2, 10 };

            //foreach (int num in Numbers)
            //    Console.WriteLine($" {num}");
            //Helper<int>.BubbleSort( Numbers );

            //foreach (int num in Numbers)
            //    Console.WriteLine($" {num}");

            //Employee[] employees = new Employee[]
            //{
            //    new Employee(){Id = 10 , Name = "Mostafa" , Salary = 12323 } ,
            //    new Employee(){Id = 20 , Name = "Mohamed" , Salary = 7000 } ,
            //    new Employee(){Id = 30 , Name = "Ali" , Salary = 2000 } ,
            //    new Employee(){Id = 40 , Name = "Osama" , Salary = 5000 } ,

            //};

            //Helper<Employee>.BubbleSort( employees );
            //foreach ( Employee employee in employees )
            //    Console.WriteLine(employee);

            #endregion

            

        }
    }
}
