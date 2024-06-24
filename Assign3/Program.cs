namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //    Console.WriteLine("Please Enter a number");
            //    string input = Console.ReadLine();
            //    int number;
            //    if (int.TryParse(input, out  number))
            //    {
            //        if (number % 3 == 0 && number % 4 == 0)
            //        {
            //            Console.WriteLine("Yes");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong Entry , Enter a number  .");
            //    }
            //Console.ReadKey();
            #endregion

            #region Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Please Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{ 
            //    if(number > 0) 
            //    {
            //        Console.WriteLine("Postive"); 
            //        }
            //    else
            //    {
            //        Console.WriteLine("Negative");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Wrong entry , Enter a number ");
            //}
            //Console.ReadKey();
            #endregion

            #region  Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int num1  , num2 ,  num3 ;
            //Console.WriteLine("Enter three numbers : ");

            //Console.WriteLine("Enter the first number ");
            //bool isNumber1 = int.TryParse(Console.ReadLine(), out num1);

            //Console.WriteLine("Enter the Second number ");
            //bool isNumber2 = int.TryParse(Console.ReadLine(), out num2);

            //Console.WriteLine("Enter the Third number ");
            //bool isNumber3 = int.TryParse(Console.ReadLine(), out num3);



            //if (isNumber1 &&  isNumber2 && isNumber3)
            //{
            //    int min = Math.Min(num1, Math.Min(num2, num3));
            //    int max = Math.Max(num1, Math.Max(num2, num3));
            //    Console.WriteLine($"Max Number is : {max}");
            //    Console.WriteLine($"Min Number is : {min}");

            //}
            //else
            //{
            //    Console.WriteLine("Wrong Entry , Enter numbers "); 

            //}
            //Console.ReadKey();
            #endregion

            #region Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Please Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    if (number % 2 == 0 )
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Entry , Enter a number  .");
            //}
            //Console.ReadKey();
            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Please Enter A Character : ");
            //String Input = Console.ReadLine().ToLower();

            //switch (Input)
            //{
            //    case "a":
            //    case "e":
            //    case "i":
            //    case "o":
            //    case "u":
            //        Console.WriteLine("Vowel");
            //        break; 
            //    default:
            //        Console.WriteLine("Consonant"); 
            //        break;

            //}
            //Console.ReadKey(); 

            #endregion

            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Please Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    for (int i = 1; i <= number; i++) 
            //    {
            //        Console.Write( $"{i} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Entry , Enter a number  .");
            //}
            //Console.ReadKey();

            #endregion

            #region  Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            //Console.WriteLine("Please Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write($"{i * number} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Entry , Enter a number  .");
            //}
            //Console.ReadKey();

            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Please Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //if (int.TryParse(input, out number))
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if(i %2 == 0)
            //        {
            //            Console.Write($"{i} ");

            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Entry , Enter a number  .");
            //}
            //Console.ReadKey();

            #endregion

            #region Write a program that takes two integers then prints the power.
            //int num1, num2; 

            //Console.WriteLine("Please Enter two numbers :");
            //Console.Write("Base  Number : ");
            //bool isNumber1 = int.TryParse(Console.ReadLine(), out num1);

            //Console.Write("Exponenet Number : ");
            //bool isNumber2 = int.TryParse(Console.ReadLine(), out num2);

            //if(isNumber1 && isNumber2)
            //{
            //    double power =  Math.Pow(num1 , num2);
            //    Console.WriteLine($"{num1} ^ {num2} = {power}");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong entry !!!!!");
            //}
            //Console.ReadKey(); 


            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int totalMarks = 0; 
            //Console.WriteLine("Pleasae Enter Marks : ");
            //int number; 
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Subject-{i} : ");
            //    while (!int.TryParse(Console.ReadLine(), out number ) || !(number > 0) || !(number < 100 )  )
            //    {
            //        Console.WriteLine("Please Enter a right number ");
            //    }
            //    totalMarks += number; 
            //}

            //float averageMarks = totalMarks / 5f;
            //float percentage = totalMarks / 500f * 100;

            //Console.WriteLine($"Total Marks = {totalMarks}");
            //Console.WriteLine($"Average Marks = {averageMarks}");
            //Console.WriteLine($"Percentage  = {percentage}");
            //Console.ReadKey(); 
            #endregion

            #region Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the number of the month : ");
            //int number;
            //bool isNumber = int.TryParse(Console.ReadLine(), out number);
            //if (!isNumber )
            //{
            //    Console.WriteLine("Wrong Entry Enter a right number :  ");
            //}
            //else
            //{
            //    switch (number)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine(31);
            //            break;
            //        case 4: 
            //        case 6:
            //        case 9: 
            //        case 11:
            //            Console.WriteLine(30);
            //            break;
            //        case 2:
            //            Console.WriteLine(29);
            //            break;
            //        default:
            //            Console.WriteLine("Enter a right month number "); 
            //            break;

            //    }
            //    }
            //Console.ReadKey();
            #endregion

            #region Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            // double GetCoordinate(String text )
            //{
            //    double number;
            //    Console.WriteLine($" enter {text} "  );
            //    while (!double.TryParse(Console.ReadLine() , out number ))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //    return number; 

            //} 

            //double x1  , x2 , x3 , y1 , y2 , y3 ;

            //x1 = GetCoordinate("x1");
            //y1 = GetCoordinate("y1");
            //x2 = GetCoordinate("x2");
            //y2 = GetCoordinate("y2");
            //x3 = GetCoordinate("x3");
            //y3 = GetCoordinate("y3");

            //double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on the same   line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points are not on the same line.");
            //}

            //Console.ReadKey();




            #endregion

            #region Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task
            //Console.WriteLine("Enter the number of hours to complete the task");
            //float hours;
            //while (!float.TryParse(Console.ReadLine() ,out  hours) && hours > 0)  {
            //    Console.WriteLine("Enter a right  number ");

            //}

            //if ( hours <= 3)
            //{
            //    Console.WriteLine(" highly efficient.");
            //}
            //else if (hours > 3 && hours <= 4)
            //{
            //    Console.WriteLine(" should increase their speed.");
            //}
            //else if (hours > 4 && hours <= 5)
            //{
            //    Console.WriteLine(" training to enhance their speed.");
            //}
            //else if (hours > 5)
            //{
            //    Console.WriteLine("Fire him.");
            //}
            //Console.ReadKey(); 
            #endregion

            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int number1 = 13;
            //int number2 = number1;
            //number1 = 14;
            //Console.WriteLine($"First Number is {number1}"); // 14
            //Console.WriteLine($"Second Number is {number2}"); // 13

            #endregion

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //int[] array1 = [1, 2, 3];
            //int[] array2 = array1;
            //array1[0] = 4;
            //Console.WriteLine($"First array is {string.Join(',', array1)}"); // [4, 2, 3 ]
            //Console.WriteLine($"Second array is {string.Join(',', array2)}");// [4, 2, 3  ]
            #endregion

            #region Choose
            //23 => b - A value 1 will be assigned to d.
            //24 => d - 6 1 
            //25 => d - 7 7 
            #endregion









        }
    }
}
