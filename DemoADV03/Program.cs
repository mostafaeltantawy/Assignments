namespace DemoADV03
{
    public delegate int StringFuncDelegate(string s);
    public delegate bool ConditionFunc<T>(T n);

    // New Class [Delegate] 
    // Can Reference one or more function 
    // Could be static or non static 
    // but they should ne have the same signature without considration of name or accwess modifier

    #region Built in Delefate 
    // 1.predicate
    // refer to function that take one parameter and must return bool


    // 2. func 
    // can refer to [0 - 16] parameters and must return
    // 
    // 3. Action 
    // can take parameters to [0 - 16] an must be void
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            // Delegate is a C# Language Feature 
            // Has 2 Usages
            // 1. Pointer to Function
            // 2. Event - Driven Programming
            // 3. Functional Programming

            //int x = StringFunctions.CountUpperCase  //Invalid

            //StringFuncDelegate stringFuncDelegate = StringFunctions.CountUpperCase;

            //stringFuncDelegate += StringFunctions.CountLowerCase;
            //stringFuncDelegate -= StringFunctions.CountLowerCase;

            //int num = stringFuncDelegate.Invoke("LololoL");


            //Console.WriteLine(num); 
            #endregion

            #region Ex01
            int[] ints = { 1, 2,  11, 2 , 43, 12,4123,42 ,  3 };

            //SortingAlgorithms.BubbleSortAsc(ints);
            //SortingAlgorithms.BubbleSort(ints , CompareFunctions.CompareGreater);
            //SortingAlgorithms.BubbleSort(ints, CompareFunctions.CompareLess);



            //foreach (int i in ints) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Ex02

            //string[] Names = { "Mostafa", "Mohamed", "Ali", "Nacho", "Osama", "Yi" };
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunctions.CompareString);
            //foreach (string s in Names)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region ex03
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            ////List<int> Result = Helper.GetOddNumbers(Numbers);
            ////List<int> Result = Helper.GetEvenNumbers(Numbers);
            //List<int> Result = Helper<int>.GetElementsBasedOnFunctions(Numbers, NumbersConditionalFuncs.CheckDivisibleBy7);

            //foreach (int i in Result)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> Names = new List<string> { "Mostafa", "Mohamed", "Ali", "Nacho", "Osama", "Yi" };

            //List<string> Result2 = Helper<string>.GetElementsBasedOnFunctions(Names, Helper<string>.ChecKStringLengthIs5);

            //foreach (string i in Result2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Built in delegates
            //Predicate<int> predicate = TestingFunctions.Test01;

            //Console.WriteLine(predicate.Invoke(42)  );

            //Func<int, string> Func = TestingFunctions.Test02;

            //Action action = TestingFunctions.Test03; // Non generic , Take 0 parameters and return void 

            //Action<int> action = TestingFunctions.Test04 ; // 
            //action(4); 

            #endregion

            #region Anonymous method and lambda expression


            #region Anonymous
            //Predicate<int> predicate = delegate (int x) { return x > 0  ;};

            //Func<int, string> Func = delegate (int x) { return x.ToString();  }; 
            #endregion
            #region Lambda

            //Predicate<int> predicate = (int x) => x > 0; 

            //Func<int, string> Func =  (int x) => x.ToString();

            //Action action = () => Console.WriteLine("Hello"); ; 


            #endregion


            #endregion

            #region var 
            var predicate = (int x) => true;

            var action = () => Console.WriteLine("Hello"); ;

            #endregion





        }
    }

    //class TestingFunctions
    //{
    //    public static bool Test01(int x)
    //    {
    //        return x > 0;
    //    }
    //    public static string Test02(int x)
    //    {
    //        return x.ToString();
    //    }

    //    public static void Test03()
    //    {
    //        Console.WriteLine("lol"); ;
    //    }

    //    public static void Test04(int x )
    //    {
    //        Console.WriteLine(x ); ;
    //    }
    //}

}
