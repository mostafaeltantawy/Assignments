using Common6; 
namespace Demo6
{
    // What access modifiers allowed inside namespace ? 
    // 1 . class 
    // 2 . struct 
    // 3 . interface 
    // 4 . enum


    // access modifier allowed in namespace 
    // 1 . internal
    // 2 . public 



    [Flags]
    public enum Permission : byte
    {
        Delete = 1 , Execute = 2 , Read = 4, Write = 8
    }
    public enum Gender
    {
        Male , Female
    }

    public enum Grade
    {
        A , B , C , D , E ,F 
    }

    class Employee
    {
        public string Name;
        public int Age;
        public Gender Gender;
        public decimal Salary;
        public Permission Permissions; 

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exception Handling
            #region ex01

            //try
            //{
            //    DoProtectiveCode();

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //    // throw new Exception(ex.StackTrace); // will block code execution
            //}
            //finally
            //{
            //    // close , delete , release , deaalocate unmanged resources
            //    Console.WriteLine("Finally");
            //}





            #endregion
            #endregion

            #region Access Modifiers

            #region Ex01

            //TypeA obj = new TypeA();
            //TypeB obj = new TypeB();  // Invalid because of its protection level [internal]

            #endregion

            #region Ex02

            TypeA obj = new TypeA();
            //obj.X = 1; // Invalid
            //obj.Y = 1; // Invalid

            obj.Z = 1;

            #endregion

            #endregion

            #region Enum 

            #region Ex01
            Grade X = Grade.A;

            Grade Y = (Grade)2; // Explicit casting

            Console.WriteLine(Y); // c

            Grade z = (Grade)10;// Explicit casting
            Console.WriteLine(z); // 10

            #endregion

            #region Ex04
            //Employee  employee = new Employee();
            //employee.Name = "Mostafa"; 
            //employee.Gender = Gender.Male;
            //employee.Permissions = (Permission) 2;
            //Console.WriteLine(employee.Permissions);
            //employee.Permissions = (Permission)7;
            //Console.WriteLine(employee.Permissions);

            //// If you want to add permissin (write)
            //// Do XOR operation

            //employee.Permissions = employee.Permissions ^ Permission.Write;
            //Console.WriteLine(employee.Permissions);

            //// If you want to remove permissin (Read)
            //// Do XOR operation

            //employee.Permissions = employee.Permissions ^ Permission.Read;
            //Console.WriteLine(employee.Permissions);

            //// if i wanna add an existing operator it will delete it


            //// if you wnat to check if read is existed or not
            //// do and operation (&)

            //// if Read is existed => return delete 
            //// if read is not existed => Return random value 

            ////if((employee.Permissions & Permission.Read) == Permission.Read)
            ////{
            ////    Console.WriteLine("Read is existed ");
            ////}
            ////else
            ////{
            ////    employee.Permissions = employee.Permissions ^ Permission.Read;
            ////}
            ////Console.WriteLine(employee.Permissions);

            //// if you want to check if permission is existed or not 
            //// if Existed => do nothing
            //// if not existed add 
            //// OR operation | 

            //employee.Permissions = employee.Permissions | Permission.Read;
            //Console.WriteLine(employee.Permissions);






            #endregion

            #endregion

            #region Struct
            #region ex

            //Point P1; // Declare variable type Point then the clr will allocate unintialized bytes in stack

            ////P1.X = 10;
            ////P1.Y = 20;
            ////Console.WriteLine(P1.X);
            ////Console.WriteLine(P1.Y);

            //P1 = new Point(1 ,2); // new is just only for constructor selection

            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);
            //Console.WriteLine(P1.ToString()); // it only inherit from (value type) -> that inherit from (object)
            //Console.WriteLine(P1); // it only inherit from (value type) -> that inherit from (object)



            #endregion

            #endregion
        }
        static void DoProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;

            do
            {
                Console.WriteLine("Enter the first number : ");
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);

            do
            {
                Console.WriteLine("Enter the Second number : ");
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0);

            Z = X / Y;

            int[] Numbers = { 1, 2, 3 };
            if (Numbers?.Length > 10)
            {
                Numbers[10] = 100;
            }
        }
    }

   
}
