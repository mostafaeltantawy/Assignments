
namespace C_Assing_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that allows the user to enter a number then print it.
            int number;
            Console.WriteLine("Please Enter a number :  ");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                Console.WriteLine($"Your Number is : {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }


            #endregion

            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int number1 = 13;
            int number2 = number1;
            number1 = 14;
            Console.WriteLine($"First Number is {number1}"); // 14
            Console.WriteLine($"Second Number is {number2}"); // 13
            #endregion

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] array1 = [1, 2, 3];
            int[] array2 = array1;
            array1[0] = 4;
            Console.WriteLine($"First array is {string.Join(',', array1)}"); // [4, 2, 3 ]
            Console.WriteLine($"Second array is {string.Join(',', array2)}");// [4, 2, 3  ]
            #endregion


            Console.ReadKey();

        }
    }
}