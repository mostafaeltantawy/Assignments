using Day_01_G03;
using System.Globalization;

namespace DemoLINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#  : Implicitly type local variable  [var , Dynamic]
            #region Var
            //var Data01 = "Ahmed";  // Compiler will detect the data type based on the intial value
            // When using it the variable must be intialized 
            // Cant use it an a parameter or return type


            //var x = null; // Invalid

            //Data01 = 123; //Invalid

            #endregion

            #region Dynamic
            //dynamic Data02 = "Mostafa"; //Like Var in js
            //                            // Could change the type during the runtime
            //                            //CLR will detect datetype of local variable based on last value , at runtime 
            //                            // Don't need to be intialized
            //                           //Compilation: No type checking is done.The compiler accepts the code and defers all type resolution and method/ property binding to runtime.
            //Data02 = 1231;

            ////Data02.length(); 

            //Console.WriteLine(Data02.GetType());


            ////dynamic x;
            ////Console.WriteLine( x); 


            #endregion

            #region Extension Methods

            //int Number = 12345;

            ////Console.WriteLine(IntExtension.Reverse(Number));
            //Console.WriteLine(Number.Reverse());
            #endregion

            #region Anonymous
            //var Emp01 = new { A = 1, B = "String" }; //Anonymous type
            //Console.WriteLine(Emp01);

            //var Emp02 = new {A=2 ,B="String1"};

            //Emp01.A = 123; // Anonymous type is immutable - Can't change the value after creation .
            //Console.WriteLine(Emp02);
            //Console.WriteLine(Emp01.GetType());
            //Console.WriteLine(Emp02.GetType());

            // The same anonymous as long as : 
            // 1. The same property name .[Case sensitive] .
            // 2. The same property order
            // 3. The same datatypes

            //var Emp02 = Emp01 with { A =12 }; // New feature

            //var Emp02 = Emp01;
            //Console.WriteLine(Emp02);

            //if (Emp01.Equals(Emp02))
            //{
            //    Console.WriteLine("Eqauls");
            //}
            //else
            //{
            //    Console.WriteLine("Not EQual");



            //}

            // It used in something like joins
            #endregion

            #region LINQ : Language Integrated Query
            // +40 extension  Methods (LINQ operators) using against any data [Data in sequence]
            // 13 Category 
            // LINQ Operators exists in class -----> "Enumerable" <-----

            //Sequence : object from class Implement interface "IEnumerable"

            // Local Sequence :  data collection that exists in memory.
            // Remote sequence :  refers to data that is not stored in memory but is instead retrieved from an external source such as a database, a web service, or a file.

            // Input sequence -- > LINQ operator ------> output sequence 
            // Input sequence -- > LINQ operator ------> one value 
            //                -- > LINQ operator ------> one value 

            // -------------

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////var Even = Enumerable.Where(list, x => x % 2 ==0);
            //var Even = list.Where(x =>  x % 2 == 0);    

            //foreach (var e in Even) {
            //    Console.WriteLine(e);
            //}


            //var Result = Enumerable.Range(1, 10);

            #region LINQ Syntax : 

            // 1. Fluent Syntax
            // use LINQ method 
            // 1.1. LINQ operator As => class member method through class "Enumerable"

            //List<int> list = [1, 2, 3, 5, 6, 7, 12, 23, 123, 352];

            //Where 
            //var result = Enumerable.Where(list, N => N % 2 == 0);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            // 1.2. LINQ operator As => Extension Method throuqh the sequence [Recommended]

            //var result = list.Where(n=>n%2==0); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}






            // 2. Query Syntax [Query Expresssion] like SQL Stryle 
            // start with "from"
            // end with "Select" or "Group by"
            // Query syntax easier than fluent [Join , Group by , let , into ]

            //List<int> list = [1, 2, 3, 5, 6, 7, 12, 23, 123, 352];

            //var Result = from Num in list
            //             where Num % 2 != 0 
            //             select Num;


            //foreach (var item in Result) 
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region LINQ Execution Ways 

            // 1 . Differed Execution way : 10 category 
            // 2 . Immidiate Execution Way : 3 category [Elements operator  - Casting operator - Aggeregate operator  ]

            //List<int> list = [1, 2, 3, 5, 6, 7, 12, 23, 123, 352];

            //var reasult = list.Where(n => n%2 == 0)/*.ToList()*/; // is differed 
            //list.AddRange([15, 1234, 23421, 242]);

            //foreach (int i in reasult) 
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #endregion


            Console.WriteLine(ListGenerator.ProductsList[0]);
            Console.WriteLine(ListGenerator.CustomersList[0]);


        }
        public static dynamic AnyType(dynamic Data) { return Data; }

    }
}
