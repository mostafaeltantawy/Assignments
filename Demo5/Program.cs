namespace Demo5
{
    internal class Program
    {
        public static void PrintShape(int Count = 10, string Pattern = "*_*")
        {
            for (int i = 0; i < Count; i++)
                Console.WriteLine(Pattern);


        }
        //static void Swap(int x, int y) {
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        //static int SumArray( ref  int[] nums)
        //{
        //    int sum = 0;
        //    if (nums != null)
        //    { 
        //        nums = new int[]{20 , 30 , 40 , 50 };
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            sum += nums[i];
        //        }
        //    }

        //    return sum;
        //}
        static int SumArray(int x, int y, params int[] nums) // the params should be the last parameter

        {
            int sum = 0;
            if (nums != null)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
            }

            return sum;
        }


        static void SumMul(int x, int y, ref int sum, ref int mul)
        {
            sum = x + y;
            mul = x - y;
        }
        static void Main(string[] args)
        {
            #region Boxing-Unboxing
            //object o1;
            //o1 = "AHMED"; //casting 
            //o1 = 1;  // VALUE TYPE  => REFERENCE TYPE === Boxing
            //o1 = 'A';  // Reference TYPE  => value TYPE === unboxing  

            //int x = 10;
            //object obj = x; // Boxing [Safe casting ] parent => child

            //object obj2 = "mostafa";
            //int y = (int) obj2; // [Unsafe casting ] unboxing , Parent => child
            //Console.WriteLine(y); // invalidCastException


            #endregion

            #region Nullable Type 
            // Null as a value type only with reference type 

            #region Value type

            #region ex01
            // int x = null; //invalid 
            // int x => allow only int values 

            // int? x = null; // valid
            //int? x => allow null values and int 

            //int? y = null;
            //int x = 10;
            //int? z = y; // valid 
            //int?w = x; //valid 
            //x = y; // invalid

            // int? number; // Nullable<int> number

            #endregion

            #region ex02
            //int x = 10;
            //int? y = /*(int?)*/x; // Valid Implicit Casting
            //                      //  safe casting 

            //int? Number01 = null;
            //int Number02 = (int)Number01; // Explicit Casting
            //                              // Unsafe
            //                              //InvalidOperationException

            //Console.WriteLine(Number02);
            #endregion

            #region ex03
            //int l; 
            //int? k = null;
            //if (k != null) {
            //    l = (int) k ; //casting
            //}
            //else
            //{
            //    l = 0 ;
            //}
            ////-----------------------------------
            //if (k.HasValue)
            //{
            //    l = k.Value; // not csting

            //}
            //else
            //{
            //    l = 0 ;
            //}

            //l = k.HasValue? k.Value : 0 ;
            //l = k!= null ? (int)k : 0 ;
            #endregion






            #endregion

            #region Refrences Type 
            // Null is default type of refrence type

            #region ex01
            //string Message = "Hi";
            //Message = null;  // valid with warning
            //Message = null!;  // ! => null forgiveness operator
            //Console.WriteLine(Message);

            //string? Message02 = null; // valid withoyut warning

            //Console.WriteLine(Message02);
            #endregion

            #region ex02
            //Employee employee = new Employee(); 
            //employee.FirstName = "Test";

            //string NotNull = "hello";
            //string? NullableString = default; // null

            ////NullableString = NotNull ; //valid
            //NotNull = NullableString; 

            #endregion

            #endregion



            #endregion

            #region Null Propagation Operator ?
            #region EX01
            //double x = default;
            //Console.WriteLine(x);

            //int[] Numbers = default; // null
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item); // NUllReferenceException
            //}

            //for (int i = 0;(Numbers != null) && i < Numbers.Length; i++)
            //    Console.WriteLine(Numbers[i]);

            //for (int i = 0; i < Numbers?.Length; i++)
            //    Console.WriteLine(Numbers[i]);

            // Numbers?.Length 
            //Numbers = null => (Numbers?.length) => null
            // numbers != null => Numbers?.length => length

            //if(Numbers != null)
            //{
            //    for (int i = 0; i < Numbers?.Length; i++)
            //        Console.WriteLine(Numbers[i]);
            //}

            //int length = Numbers?.Length ?? 0;
            #endregion

            #region Ex02

            //Employee employee01 = new Employee();
            //employee01.Department = new Department();
            //employee01.Department.Name = 'IT'; 

            ////if (employee01 != null)
            ////{
            ////    if (employee01.Department != null) 
            ////    {
            ////        Console.WriteLine(employee01.Department.Name);

            ////    }

            ////}

            //Console.WriteLine(employee01?.Department?.Name ?? "Department Not Found");
            #endregion









            #endregion

            #region Functions
            #region ex01
            //PrintShape(); // Without parameteres
            //PrintShape(15, ":)"); // Passing Parameters wih order
            //PrintShape(Pattern: ":)" , Count: 2); // Passing parameters By name
            //PrintShape(20);  // Using Default

            //Console.WriteLine("Hello Route\nWelcome \t Mo");
            //// \n => new line
            //// \t => tab 
            //string path = "C:\\Users\\Lenovo\\source\\repos\\Assignments\\Demo5\\Employee.cs";
            //Console.WriteLine(path);
            //PrintShape(10  , @"/*\");

            // skip \ => \\
            // Skip \ => @





            #endregion

            #region Ex02
            #region Passing by value 
            //int[] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine(Numbers[0]);
            //SumArray(Numbers);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing by ref
            //int[] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine(Numbers[0]);
            //SumArray(ref Numbers);
            //Console.WriteLine(Numbers[0]);
            #endregion


            #endregion

            #region Passing patrameters 

            #region Passing value Type paramaters

            #region Passing by value

            //int a = 10, b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region Passing by reference

            //int a = 10, b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a,  ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion



            #endregion

            #region Passing reference type parameteres

            #region Passing by value 
            //int[] num = { 1, 2, 3 };
            //int result = SumArray(num);
            //Console.WriteLine(result);
            //Console.WriteLine(num[0]);

            #endregion

            #region Passing by ref
            //int[] Numbers = { 1, 2, 3, 4, 5, };
            //Console.WriteLine(Numbers[0]);
            //int res =  SumArray( ref Numbers);
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(res);
            #endregion
            #endregion

            #region Passing by out
            //int a = 10; int b = 20;
            //int SumResult = 0, MulResult = 0;
            ////SumMul(a, b,out SumResult,out MulResult); // Passing by out 

            //// out => out parameter 
            //// ref => input - output parameter & Must be intialized



            //Console.WriteLine(SumResult);
            //Console.WriteLine(MulResult);

            #endregion

            #region Passing by params
            //int res = SumArray(1, 2, 3, 4, 5, 6, 7); 
            //Console.WriteLine(res);
            //int a = 10 ; int b = 20; int c = 30  , d=60;
            //string name = "test"; 

            //Console.WriteLine("{0} + {1} + {2} = {3} {4} ",a , b  , c , d ,name);


            #endregion


            #endregion
            #endregion


        }
    }
}
