using System.Text;

namespace Assign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int number;
            //do
            //{
            //    Console.WriteLine("Please Enter a number : ");

            //} while (!int.TryParse(Console.ReadLine() , out  number ) || number < 0);

            //for (int i = 1; i <= number; i++) {
            //    Console.Write($"{i} "); 

            //}

            #endregion

            #region Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int number;
            //do
            //{
            //    Console.WriteLine("Please Enter a number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number) || number < 0);

            //for (int i = 1; i <= 12; i++) {
            //    Console.WriteLine($"{number} * {i} = {i* number}");

            //}

            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int number;
            //do
            //{
            //    Console.WriteLine("Please Enter a number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number) || number <= 1);

            //for (int i = 2; i <= number; i++) {
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Write a program that takes two integers then prints the power.
            //int baseNumber , exponentNumber;
            //do
            //{
            //    Console.WriteLine("Please Enter the base  number : ");

            //} while (!int.TryParse(Console.ReadLine(), out baseNumber) );

            //do
            //{
            //    Console.WriteLine("Please Enter the exponent  number : ");

            //} while (!int.TryParse(Console.ReadLine(), out exponentNumber));

            //Console.WriteLine($"{baseNumber} ^ {exponentNumber} = {Math.Pow(baseNumber , exponentNumber)}");
            #endregion

            #region Write a program to allow the user to enter a string and print the REVERSE of it.
            //string input; 
            //do
            //{
            //    Console.WriteLine("Please enter a string : ");
            //    input = Console.ReadLine();


            //} while (input == "");

            //char[] charsArray = input.ToCharArray(); 
            //Array.Reverse(charsArray);
            //String reversed = new String(charsArray);
            //Console.WriteLine($"Reversed String : {reversed}");


            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int start , end;
            //do
            //{
            //    Console.WriteLine("Please Enter the start range  number : ");

            //} while (!int.TryParse(Console.ReadLine(), out start) && start < 0 );

            //do
            //{
            //    Console.WriteLine("Please Enter the end range  number : ");

            //} while (!int.TryParse(Console.ReadLine(), out end) && end < 0);

            //while(start < end) {
            //    if (IsPrime(start)) {
            //        Console.WriteLine(start);
            //    }
            //    start++;


            //}

            //bool IsPrime(int number)
            //{
            //    if(number == 1) return false;
            //    if(number == 2) return true;
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0) return false;
            //    }

            //    return true;
            //}

            #endregion

            #region  Write a program in C# Sharp to convert a decimal number into binary without using an array.

            // https://www.youtube.com/watch?v=QAHyFa3gKKc&ab_channel=ALLABOUTELECTRONICS

            //    int number;
            //    string binaryNumber = "";  
            //    do
            //    {
            //        Console.WriteLine("Please Enter a number : ");

            //    } while (!int.TryParse(Console.ReadLine(), out number) || number < 0);

            //while (number > 0) {
            //    int reminder = number % 2;
            //    binaryNumber = $"{reminder}{binaryNumber}";
            //    number = number / 2;
            //}
            //Console.WriteLine(binaryNumber);




            #endregion

            #region  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int number;
            //do
            //{
            //    Console.WriteLine("Please Enter a number : ");

            //} while (!int.TryParse(Console.ReadLine(), out number) || number < 0);
            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();

            //}


            #endregion

            #region Write C# program that Extract a substring from a given string
            //string input;
            //int start, end; 

            //do
            //{
            //    Console.WriteLine("Please enter a string : ");
            //    input = Console.ReadLine();

            //} while (input == "" );

            //do
            //{ 
            //    Console.WriteLine("Please Enter a start index  : ");

            //} while (!int.TryParse(Console.ReadLine(), out start) ||  start < 0);

            //do
            //{
            //    Console.WriteLine("Please Enter a end index  : ");

            //} while (!int.TryParse(Console.ReadLine(), out end) || end >= input.Length);


            //Console.WriteLine(input.Substring(start , end-start +1 ));




            #endregion

            #region Write C# program that take two string variables and print them as one variable
            //string input1 , input2;

            //do
            //{
            //    Console.WriteLine("Please enter first string : ");
            //    input1 = Console.ReadLine();

            //} while (input1 == "");

            //do
            //{
            //    Console.WriteLine("Please enter second string : ");
            //    input2 = Console.ReadLine();

            //} while (input2 == "");

            //Console.WriteLine(input1 + input2); 
            #endregion


            #region Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] nums = { 1, 2, 3, 4, 5, 6,7 };

            //Console.WriteLine(ArraySum(nums));




            //int ArraySum(int[] arr) {
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++) { 
            //    sum += arr[i];
            //    }
            //    return sum;
            //}


            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] nums1 = { 19, 34, 123, 43, 5457, 11};
            //int[] nums2 = { 451, 34,  455, 234, 123 };

            //int[] SortedArrat = Merge(nums1, nums2);
            //foreach (int i in SortedArrat) {
            //    Console.WriteLine(i);
            //}



            //int[] Merge(int[] nums1, int[] nums2) { 
            //    Array.Sort(nums1);
            //    Array.Sort(nums2);
            //    int first = 0, second = 0 , res= 0 ;
            //    int[] result = new int[nums1.Length + nums2.Length];
            //    while (first < nums1.Length && second < nums2.Length) {
            //        if(nums1[first] <= nums2[second])
            //        {
            //            result[res] = nums1[first];
            //            first++;
            //            res++; 

            //        }
            //        else
            //        {
            //            result[res] = nums2[second];
            //            second++;   
            //            res++;
            //        }

            //    }
            //    while(first < nums1.Length)
            //    {
            //        result[res] = nums1[first];
            //        first++;
            //        res++;
            //    }
            //    while (second < nums2.Length)
            //    {
            //        result[res] = nums2[second];
            //        second++;
            //        res++;
            //    }
            //    return result; 



            //}

            #endregion

            #region Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 1, 2 };
            //Dictionary<int, int> result = ArrayFrequency(numbers) ;
            //foreach (var element in result)
            //{
            //    Console.WriteLine($"{element.Key} : {element.Value}");
            //}


            //Dictionary<int , int> ArrayFrequency(int[] arr ) {
            //    Dictionary<int, int> frequency = new Dictionary<int, int>();
            //    foreach ( int number in arr )
            //    {
            //        if( frequency.ContainsKey( number ) )
            //        {
            //            frequency[ number ]++;
            //        }
            //        else
            //        {
            //            frequency[number] = 1; 

            //        }

            //    }
            //    return frequency;
            //}
            #endregion

            #region Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] numbers = { 1, 2,  23, 2, 43, -1, 232, 50, 666 };

            //int max = 0, min = 0; 
            //foreach (int number in numbers) {
            //    if(number > max)
            //    {
            //        max = number;
            //    }
            //    if (number < min)
            //    {
            //        min = number;
            //    }
            //}

            //Console.WriteLine($"Max : {max} , Min:{min}");

            #endregion

            #region Write a program in C# Sharp to find the second largest element in an array.

            //int[] numbers = { 1, 2, 23, 2, 43, -1, 232, 52320, 666  , 555};

            //    int max = -999999999;
            //    int secondMax = -999999999;

            //    foreach (var number in numbers)
            //    {
            //    if (number > max)
            //    {
            //        max = number;

            //    }
            //    else if (number > secondMax) { 
            //        secondMax = number;
            //    }

            //    }
            //Console.WriteLine($"Max : {max} , Second Max  : {secondMax}");



            #endregion

            #region write a program find the longest distance between Two equal cells.
            //int[] numbers = { 7,0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3  };
            //Console.WriteLine(LongestDistance(numbers));


            //int LongestDistance(int[] arr)
            //{
            //    Dictionary<int, int> FirstAppearanceIndex = new Dictionary<int, int>();
            //    int maxDistance = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (!FirstAppearanceIndex.ContainsKey(arr[i]))
            //        {
            //            FirstAppearanceIndex[arr[i]] = i;
            //        }
            //        else
            //        {
            //            int firstAppearance = FirstAppearanceIndex[arr[i]];
            //            int distance = i - firstAppearance+1;
            //            maxDistance = distance > maxDistance ? distance : maxDistance;
            //        }

            //    }
            //    return maxDistance; 

            //}

            #endregion

            #region   Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int[,] array1 = new int[3, 3];
            //int[,] array2 = new int[3, 3];

            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value for element [{i}, {j}]: ");
            //        while (! int.TryParse(Console.ReadLine(), out array1[i, j]) )
            //        {
            //            Console.WriteLine("Enter valid number  : ");

            //        }

            //    }
            //}

            //// copy the array

            //for (int i = 0; i < array2.GetLength(1); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            ////print 
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write( $"{array2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region  Write a Program to Print One Dimensional Array in Reverse Order
            //int[] array = { 1, 2, 3, 4, 5 };
            //for (int i = array.Length -1; i >= 0; i--) {
            //    Console.WriteLine(array[i]);

            //}
               
            #endregion


            Console.ReadKey();
        }
    }
}
