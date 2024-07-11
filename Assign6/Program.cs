namespace Assign6
{
    // # 1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    enum Permission : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8,
    }

    enum Color
    {
        Red, Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (var Day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(Day);
            //}
            #endregion

            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season

            string input;
            Season season;

            do
            {
                Console.WriteLine("Enter A season : ");
                input = Console.ReadLine();

            } while (input == null);


            if (Enum.TryParse<Season>(input, true, out season))
            {

                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring is from March to May.");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer is from June to August.");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn is from September to November.");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter is from December to February.");
                        break;
                    default: // put default case cause of it will parse a numric number and return true 
                        Console.WriteLine("Invalid");
                        break;

                }



            }
            else
            {
                Console.WriteLine("Wrong entry !");
            }



            #endregion


            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permission permissions = (Permission)6;
            //if ((permissions & Permission.Read) == Permission.Read)
            //{
            //    Console.WriteLine("Read Permission exist");
            //}
            //else
            //{
            //    Console.WriteLine("Read Permission doesn't exist");
            //}

            #endregion

            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not

            //string input;
            //do
            //{
            //    Console.WriteLine("Please enter a color : " );
            //    input = Console.ReadLine();

            //} while (input == null);

            //if (Enum.TryParse<Color>(input,true, out Color color)) {
            //    if (color == Color.Red || color == Color.Blue || color == Color.Green)
            //    {
            //        Console.WriteLine("Is a primary color");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Isn't a primary color");
            //}


            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point point1 = ReadPoint("first");
            //Point point2 = ReadPoint("second");

            //double Distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"The distance between {point1} and {point2} = {Distance}");

            #endregion
        }

        static Point ReadPoint(string PointNumber)
        {
            double XCor, YCor;
            do
            {
                Console.WriteLine($"Enter {PointNumber} X corodinate : ");

            } while (!double.TryParse(Console.ReadLine(), out XCor));

            do
            {
                Console.WriteLine($"Enter {PointNumber} y corodinate : ");

            } while (!double.TryParse(Console.ReadLine(), out YCor));

            return new Point(XCor, YCor);

        }
    }
}
