using Demo8.Binding;
using Demo8.Polymorphism;

namespace Demo8
{
    internal class Program
    {

        #region Overloading

        // Overloading just for readability
        public static int Sum(int x , int y)
        {
            return x + y; 
        }

        public static double Sum(double x , double y)
        {

        return x + y; 
        }

        public static int Sum(int x , int y , int z )
        {
            return x + y + z ;
        }
        #endregion

        public static void ProcessEmployee(Employee employee)
        {
            if(employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }

        static void Main(string[] args)
        {
            #region Polymorohism [Overloading]
            //int Result = Sum(1, 2);
            //Console.WriteLine($"REsult = {Result}");
            //int Result2 = Sum(1, 2 , 3);
            //Console.WriteLine($"REsult = {Result2}");
            //double Result3 = Sum(1 , 2.1);
            //Console.WriteLine($"REsult = {Result3}");
            #endregion

            #region Polymorohism [overriding]
            // Support with class only 
            // Function over riding Must be with relationship [Inheritance]
            //TypeA typeA = new TypeA(1);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(1, 2);
            //typeB.MyFun01(); 
            //typeB.MyFun02();


            #endregion

            #region Binding
            //// Ref From parent => object From child
            //TypeA refBase = new TypeB(1, 2);
            //refBase.A = 23;
            ////refBase.B = 49; // Invalid
            //refBase.MyFun01(); // override using new [Static binding ]
            //refBase.MyFun02();
            #endregion

            #region Not binding 
            ////TypeB ChildRef =(TypeB) new TypeA(1);// Invalid
            //TypeB ChildRef = (TypeB)new TypeA(1); // not binding [Casting] 
            ////Unsafe
            ///
            //TypeA typeA = new TypeA(1);
            //TypeB typeB = (TypeB)typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);
            ////InavlidCastException

            //TypeA typeA = new TypeB(1, 2); 
            //TypeB typeB = (TypeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);


            #endregion

            #region Ex01

            //FulltimeEmployee fulltimeEmployee = new FulltimeEmployee(10 , "Mostafa" , 25 , 4000);
            //ProcessEmployee( fulltimeEmployee );

            //ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
            //{
            //    Id = 20 , 
            //    Name = "Ali" ,
            //    Age = 25 , 
            //    HourRate = 2.5M , 
            //    CountOfHours = 20 
            //};

            //ProcessEmployee(parttimeEmployee); 



            #endregion

            #region Ex02
           // TypeA typeA = new TypeC(1  , 2  , 3 );

           //typeA.A = 10;
           ////typeA.B = 20; // invalid
           ////typeA.c = 200; // invalid

           // typeA.MyFun01();
           // typeA.MyFun02();

           // TypeB typeB = new TypeC(1, 2, 3);


           // typeB.A = 10;
           // typeB.B = 20; 
           // //typeB.c = 200; // invalid

           // typeB.MyFun01();
           // typeB.MyFun02();


            //TypeA typeA = new TypeE(1, 2, 3 , 4 , 5 );
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFun02(); 
            //typeB.MyFun02();
            //typeC.MyFun02();


            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

            //typeD.MyFun02();






            #endregion



        }
    }
}
