using DemoOOP05.Abstraction;
using DemoOOP05.Partial;
using DemoOOP05.Sealed;
using DemoOOP05.Static;

namespace DemoOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator overloading
            //Complex C1 = new Complex() { Real = 3, Imag = 5 };

            //Console.WriteLine(C1);

            //Complex C2 = default;

            ////Console.WriteLine(C2);

            //Complex C3 = default;



            #region Binary Operator overlodaing

            //Complex C3 = C1 + C2;
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(C3);

            //Complex C3 = C1 - C2;
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(C3);

            //C3 += C1;
            //Console.WriteLine(C3);

            #endregion

            #region Unary operator overloading
            //C3 = ++C1;  // prefix 
            //C3 = C1++;  // prefix 
            //C3 = --C1; 

            //Console.WriteLine(C1);
            //Console.WriteLine(C3);

            #endregion

            #region Relational operators overloading
            //if(C1 > C2)
            //    Console.WriteLine("C1 Is Gretaer than C2");
            //else
            //    Console.WriteLine("C2 is geater than C1");

            #endregion


            #endregion

            #region Casting Operator overloading
            //object obj = 2;
            //int X = (int)obj;

            //Complex C1 = new Complex() { Real = 2 , Imag = 4 };
            ////int Y =(int) C1; 
            ////Console.WriteLine(Y);

            //string S1 = C1;
            //Console.WriteLine(S1);
            #endregion

            #region Mapping
            //Employee employee = new Employee()
            //{
            //    Id = 1,
            //    FullName = "Mostafa Eltantawy" ,
            //    Password = "llololo" , 
            //    Email = "dfasdf@gmail.com" , 
            //    SecurityStamp = Guid.NewGuid(),
            //};

            //EmployeeViewModel employeeViewModel = new EmployeeViewModel();

            //employeeViewModel = (EmployeeViewModel) employee;

            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);

            #endregion

            #region Abstraction

            //Rectangle rectangle = new Rectangle() 
            //{
            //     Dim01 = 10, Dim02 = 20,
            //};

            //decimal RecArea = rectangle.CalcArea();
            //decimal RecPerimeter = rectangle.Perimeter; 
            //Console.WriteLine(RecArea);
            //Console.WriteLine(RecPerimeter);

            //Circle circle = new Circle(30); 
            //decimal cirlceArea = circle.CalcArea();
            //Console.WriteLine(cirlceArea);
            #endregion

            #region Static
            //Utility U01 = new Utility(10, 20);
            ////Console.WriteLine($"Cm => Inch =  {U01.CmToInch(254)} ");

            //Utility U02 = new Utility(1000, 2900);
            ////Console.WriteLine($"Cm => Inch =  {U02.CmToInch(254)} ");
            ////Console.WriteLine($"Cm => Inch =  {Utility.CmToInch(254)} ");
            ////Console.WriteLine(U01.CalcCircleArea(10));
            ////Console.WriteLine(U02.CalcCircleArea(10));

            //Console.WriteLine(Utility.CalcCircleArea(10));





            #endregion

            #region Partial
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Mostafa";
            employee.Age = 30;
            employee.Salary = 2312;
            employee.print(); 
            #endregion


        }
    }
}
