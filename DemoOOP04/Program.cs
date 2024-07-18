using DemoOOP04.Icloneable;
using DemoOOP04.Interfaces;
using System.Text;

namespace DemoOOP04
{
    internal class Program
    {
        static void Print10NumbersFromSeries(ISeries series)
        {
            if (series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }

        static void Main(string[] args)
        {

            #region Interface
            //IMyType myType = new IMyType(); // invalid
            //IMyType myType; // can refer to an object from a class or interface thet implement the interface

            //MyType myType1= new MyType();
            //myType1.Id = 234;
            //myType1.MyFun(20); 

            //IMyType myType = new MyType();
            //myType.Id = 234;
            //myType.MyFun(20);

            //myType.Print(); 
            #endregion


            #region interface Ex01
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            #endregion

            #region Interfaces Ex02 [Implement interfaces [Implicitly - Explicitly] ]

            //Car car = new Car();
            //car.Backward(); 

            //Airplane airplane = new Airplane();
            //airplane.Backward();
            ////airplane.Forward();  // Invalid

            //IMovable movablePlane = new Airplane(); 
            //movablePlane.Forward();

            //IFlyable Flyableplane = new Airplane();
            //Flyableplane.Forward();  

            #endregion

            #region Shallow Copy And Deep Copy


            #region Array of value type 

            //[Identity] Mean Address  , [Object state] the object itself 
            //int[] Arr01 = { 1, 2, 3, 4, 5 };
            //int[] Arr02 = new int[3];
            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;  // Shallow copy [Happen in stack]

            //Console.WriteLine("After   Arr02 = Arr01 ");

            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr02 = {Arr02.GetHashCode()}");


            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr02[0] = 100;

            //Console.WriteLine("After Arr02[0] = 100; ");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion


            #region Deep Copy [Heap]
            //Arr02 = (int[]) Arr01.Clone(); // Deep copy [Happen im heap]
            //                               //Create new object with different and new Identity
            //                               //The object will be thew same object state [Data] of caller [Arr01]
            //                               //return and object

            //Console.WriteLine("After Arr02 = (int[]) Arr01.Clone() ");

            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr02 = {Arr02.GetHashCode()}");


            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr02[0] = 100;

            //Console.WriteLine("After Arr02[0] = 100; ");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            #endregion








            #endregion


            #region Array of reference type 

            #region Array of string [Immutable]
            //string[] Names01 = { "Omar" };
            //string[] Names02 = new string[1];
            //Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");

            #region Shallow Copy
            //Names02 = Names01; //Sahllow Copy [in stack]

            //Console.WriteLine("After  Names02 = Names01 ");

            //Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names01[0] = "Mostafa";

            //Console.WriteLine("After Names01[0] = \"Mostafa\" ");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            #endregion

            #region Deep Copy

            //Names02 = (string[]) Names01.Clone();

            //Console.WriteLine("After Names02 = (string[]) Names01.Clone(); ");

            //Console.WriteLine($"HC of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names01[0] = "Mostafa";

            //Console.WriteLine("After Names01[0] = \"Mostafa\" ");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            #endregion




            #endregion

            #region Array of StringBuilder [Mutable]
            //StringBuilder[] Names01 = new StringBuilder[1] { new StringBuilder("Omar") };
            //StringBuilder[] Names02 = new StringBuilder[1];

            #region Shallow Copy 
            //Console.WriteLine($"HC of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Names02.GetHashCode()}");

            //Names02 = Names01;
            //Console.WriteLine("After Names02 = Names01 ");
            //Console.WriteLine($"HC of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names02[0].Append(" Mostafa");

            //Console.WriteLine("After  Names02[0].Append(\" Mostafa\") ");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");




            #endregion

            #region Deep Copy

            //Console.WriteLine($"HC of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Names02.GetHashCode()}");

            //Names02 = (StringBuilder[])Names01.Clone(); 

            //Console.WriteLine("After  Names02 = (StringBuilder[]) Names01.Clone()");

            //Console.WriteLine($"HC of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");

            //Names02[0].Append(" Mostafa");

            //Console.WriteLine("After  Names02[0].Append(\" Mostafa\") ");

            //Console.WriteLine($"Names01[0] = {Names01[0]}");
            //Console.WriteLine($"Names02[0] = {Names02[0]}");
            #endregion

            #endregion

            #endregion


            #endregion

            #region ICloneable

            //Employee employee01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Mostafa",
            //    Salary = 1232m
            //};


            //Employee employee02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Ali",
            //    Salary = 34312m
            //};


            //Console.WriteLine($"HC Of Enployee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee01}");


            //Console.WriteLine($"HC Of Enployee01 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee02}");


            #region Shallow Copy And DeepCopy

            #region Shallow Copy [Stack]

            //employee02 = employee01;

            //Console.WriteLine("===================== After employee02 = employee01 =========================== ");

            //Console.WriteLine($"HC Of Enployee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee01}");


            //Console.WriteLine($"HC Of Enployee01 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee02}");

            //employee01.Id = 2302;
            //employee01.Name = "Osama";
            //employee01.Salary = 3000;

            //Console.WriteLine("---------------- After edit employee01 ------------------------------");

            //Console.WriteLine($"Employee01 = {employee01}");


            //Console.WriteLine($"Employee01 = {employee02}");






            #endregion



            #region Deep Copy 
            //employee02 =(Employee) employee01.Clone();


            //Console.WriteLine( "---------------- After Deep Copy -----------------------");


            //Console.WriteLine($"HC Of Enployee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee01}");


            //Console.WriteLine($"HC Of Enployee01 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee02}");

            //employee02.Id = 2312341;
            //employee02.Name = "Zalta";
            //employee02.Salary = 100000;

            //Console.WriteLine("-------- After edit employee02 -------------");


            //Console.WriteLine($"Employee01 = {employee01}");

            //Console.WriteLine($"Employee01 = {employee02}");

            //// 2 ways of deep copy User defined datatype 
            //// 1. Clone 
            //// 2. Copy Constructor

            //employee02 = new Employee(employee01);

            //Console.WriteLine($"HC Of Enployee01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee01}");


            //Console.WriteLine($"HC Of Enployee01 = {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee02}");

            #endregion




            #endregion



            #endregion

            #region ICompareable

            //int[] numbers = { 453, 4231, 231, 4221, 235, 1234, 23, 1 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Employee[] employees = new Employee[] 
            //{
            //    new Employee(){Id = 100 , Name = "mostafa" , Salary = 1000} ,
            //    new Employee(){Id = 90 , Name = "Ali" , Salary = 900} , 
            //    new Employee(){Id = 200 , Name = "Osama" , Salary = 9000}

            //};

            //Array.Sort(employees);

            //foreach (Employee employee in employees) 
            //{
            //    Console.WriteLine(employee);
            //}


            #endregion

            #region ICopmarer

            Employee[] employees = new Employee[]
            {
                new Employee(){Id = 100 , Name = "mostafa" , Salary = 1000} ,
                new Employee(){Id = 90 , Name = "Ali" , Salary = 900} ,
                new Employee(){Id = 200 , Name = "Osama" , Salary = 9000}

            };

            Array.Sort(employees , new EmployeeIdComparer());

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            #endregion





        }
    }
}

