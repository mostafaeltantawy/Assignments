namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // When passing  by value you pass a copy of the vlaue but whe you passing by reference you pass the original memeory address to the value any modification inside the function
            // will affect the original one  . 
            //int number = 10;
            //PassByValue(number);
            //Console.WriteLine($"after passing by value :{number}");
            //PassByReference(ref number);
            //Console.WriteLine($"after passing by reference :{number}");
            #endregion

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //When passing a reference type by value you take a copy of the reference to the same object as original one , but with passing it by ref you passing the actual memory location of the reference
            // it self if you change it the actual reference will change to anothe object

            //int[] nums = {0 , 0 , 0 , 0 , 0 };
            //PassReferenceTypeByValue(nums);

            //Console.WriteLine($"after passing by value :");

            //foreach (var item in nums)
            //    Console.WriteLine(item);

            //PassReferenceTypeByRef(ref nums);

            //Console.WriteLine($"after passing by reference :");

            //foreach (var item in nums)
            //    Console.WriteLine(item);



            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int sum, sub;
            //SumAndSubstractionOf4Numbers(1, 2, 3,  4,out sum, out sub);
            //Console.WriteLine($"Sum  = {sum}\nSub={sub}");
            ////Tuples
            //(int sumResult, int subResult) = SumAndSubstractionOf4Numbers2(10, 20, 30, 40);
            //Console.WriteLine($"Sum  = {sumResult}\nSub={subResult}");



            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.WriteLine(SumOfDigits(19));



            #endregion

            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not

            //Console.WriteLine(IsPrime(13));


            #endregion

            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = { 1, 2, 3, -2, 5, 6, 7, 8, 9 };
            //int min = numbers[0];
            //int max = numbers[0];
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Min Value = {min} \nMax Value = {max}");
            #endregion

            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(10));
            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.WriteLine(ChangeChar(1 , "MOSTAFA"  , 'U'));

            #endregion


        }

        // #1
        static void PassByValue(int value)
        {
            value = 0;
        }
        static void PassByReference(ref int value)
        {
            value = 0;
        }

        // #2

        static void PassReferenceTypeByValue(int[] arr)
        {
            arr = new int[] { 1, 2, 3, 4 };
        }
        static void PassReferenceTypeByRef(ref int[] arr)
        {
            arr = new int[] { 1, 2, 3, 4 };
        }

        // #3 
        static void SumAndSubstractionOf4Numbers(int number1, int number2, int number3, int number4, out int sum, out int sub)
        {
            sum = number1 + number2 + number3 + number4;
            sub = number1 - number2 - number3 - number4;
        }
        // Another implementation with tuples 

        static (int sum, int sub) SumAndSubstractionOf4Numbers2(int number1, int number2, int number3, int number4)
        {
            int sum = number1 + number2 + number3 + number4;
            int sub = number1 - number2 - number3 - number4;
            return (sum, sub);

        }

        // #4 
        static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        // #5 

        static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // #6 
        static void MinMaxArray(int[] numbers, ref int min, ref int max)
        {
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
        }

        // #7
        static long Factorial(int num)
        {

            if (num == 0 || num == 1) return 1;

            long fact = 1;

            while (num > 1)
            {
                fact *= num;
                num--;
            }
            return fact;

        }

        // #8 
        static string ChangeChar(int index, string text, char newChar)
        {
            char[] charArray = text.ToCharArray();

            if (index > charArray.Length - 1)
            {
                return text;
            }
            charArray[index] = newChar;
            return new string(charArray);

        }










    }
}
