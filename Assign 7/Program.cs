using Assign_7.Classes;
using Assign_7.Structs;

namespace Assign_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person [] persons = [new Person("Mostafa", 23), new Person("Ahmed", 20), new Person("Osama", 19)];
            //foreach (Person person in persons) 
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region#2 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];
            ////Taking input
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    persons[i] = TakePersonDate(i);
            //}


            ////Find max age 
            //Person max = persons[0];

            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > max.Age)
            //    {
            //        max = persons[i];
            //    }
            //}

            //Console.WriteLine($"Maximum age person  : {max}");


            #endregion

            #region #3
            Employee[] employees = [
                new Employee(12, "Mostafa" ,7000 ,SecurityLevel.Developer, Gender.Male , new HiringDate(12 , 10 , 2023)) ,
                new Employee(10, "Osama" ,5000 ,SecurityLevel.Guest, Gender.Male , new HiringDate(12 , 10 , 1990)) , // ENTER WRONG VALUES HERE 
                new Employee(23, "Sara" ,9000 ,(SecurityLevel) 15, Gender.Male , new HiringDate(43 , 100 , 2003)) , // ENTER WRONG VALUES HERE
                ];

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            InsertionSortByHiringDate(employees); // NO BOXING OR UNBOXING HAPOEN


            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }



            #endregion


        }


        // #2
        static Person TakePersonDate(int order)
        {
            int age;
            string name;

            do
            {
                Console.WriteLine($"Enter User #{order + 1} name : ");
                name = Console.ReadLine();
            } while (name == null || name == "");

            do
            {
                Console.WriteLine($"Enter User #{order + 1} age : ");

            } while ((!int.TryParse(Console.ReadLine(), out age)) || age < 0);

            return new Person(name, age);

        }




        // #3 iNSERTION SORT 

        static void InsertionSortByHiringDate(Employee[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                Employee temp = arr[i];
                int j = i - 1;

                while (j >= 0 && CompareHiringDates(arr[j].HiringDate, temp.HiringDate) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }


        static int CompareHiringDates(HiringDate date1, HiringDate date2)
        {
           
            int yearComparison = date1.Year.CompareTo(date2.Year);
            if (yearComparison != 0)
                return yearComparison;

            
            int monthComparison = date1.Month.CompareTo(date2.Month);
            if (monthComparison != 0)
                return monthComparison;

      
            return date1.Day.CompareTo(date2.Day);
        }





    }
}
