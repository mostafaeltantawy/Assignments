using Day_01_G03;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace AssignLINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = ListGenerator.ProductsList;
            var CustomerList = ListGenerator.CustomersList;
            var Dictionary = File.ReadLines("C:\\Users\\Lenovo\\source\\repos\\Assignments\\AssignLINQ02\\dictionary_english.txt").ToList();



            #region Restriction Operators
            // 1. Find all products that are out of stock.

            //var result = ProductList.Where(product => product.UnitsInStock == 0);

            // 2.  Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductList.Where(product => product.UnitsInStock != 0 &&  product.UnitPrice > 3);

            // 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((item, index) => item.Length < index);

            #endregion

            #region Element operators

            // 1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(product => product.UnitsInStock !=0);

            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);


            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(number => number > 5).ElementAt(1);

            #endregion

            #region Aggregate Operators
            // 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(number => number % 2 != 0);


            //2. Return a list of customers and how many orders each has.

            //var result = CustomerList.Select(customer => $"{customer.CustomerName} : {customer.Orders.Count()}");



            //3. Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(product => product.Category).Select(category => $"{category.Key} : {category.Count()}");


            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();



            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //long result = Dictionary.Sum(word => word.Length);

            //6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = Dictionary.Min(word => word.Length);


            //7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = Dictionary.Max(word => word.Length);


            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result =(int) Dictionary.Average(word => word.Length);

            //9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(product => product.Category).Select(category => $"{category.Key} : {category.Where(product => product.UnitsInStock != 0).Count()}");


            //10. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(product => product.Category).Select(category => new { category = category.Key , CheapestPrice = category.Min(product => product.UnitPrice) });


            //11. Get the products with the cheapest price in each category (Use Let) 
            //var result = from product in ProductList
            //            group product by product.Category into categoryGroup
            //            let minPrice = categoryGroup.Min(product => product.UnitPrice)
            //            select new
            //            {
            //                Category = categoryGroup.Key,
            //                CheapestPrice = minPrice
            //            };







            //12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(product => product.Category).Select(category => new { category = category.Key, CheapestPrice = category.Max(product => product.UnitPrice) });



            //13. Get the products with the most expensive price in each category.
            //var result = ProductList.GroupBy(product => product.Category).Select(category => new { category = category.Key, CheapestPriceProduct = category.MaxBy(product => product.UnitPrice) });


            //14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(product => product.Category).Select(category => new { category = category.Key, AveragePrice = category.Average(product => product.UnitPrice) });





            #endregion

            #region  Ordering Operators

            //1. Sort a list of products by name
            //var result = ProductList.OrderBy(product => product.ProductName);

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(name => name , new CaseInsensitiveComparer()); 

            //3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(product => product.UnitsInStock); 

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(digit => digit.Length).ThenBy(digit => digit);

            //5.5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(word=>word.Length).ThenBy(word=>word , StringComparer.OrdinalIgnoreCase);

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(product => product.Category).ThenByDescending(product => product.UnitPrice);

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result  = Arr.OrderBy(word => word.Length).ThenByDescending(word => word  , StringComparer.OrdinalIgnoreCase);

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //  string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //  var result = Arr
            //.Where(word => Regex.IsMatch(word, "^.i"))
            //.Reverse(); 









            #endregion

            #region Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(product =>product.ProductName);

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Select(product => new{name = product.ProductName , Price = product.UnitPrice });

            //4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((number, index) => $"{number} : {number == index}"); 

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };

            // var result = numbersA
            //.SelectMany(a => numbersB, (a, b) => new { a, b })
            //.Where(pair => pair.a < pair.b)
            //.Select(pair => $"{pair.a} is less than  {pair.b}");

            //6. Select all orders where the order total is less than 500.00
            //var result = CustomerList.SelectMany(customer => customer.Orders).Where(order => order.Total < 500); 

            //7. Select all orders where the order was made in 1998 or later.
            //var result = CustomerList.SelectMany(customer => customer.Orders).Where(order => order.OrderDate < new DateTime(1998 ,1 ,1));







            #endregion

            #region  Set Operators

            //1.Find the unique Category names from Product List
            //var result = ProductList.Select(product => product.Category).Distinct();

            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //                           .Concat(CustomerList.Select(customer => customer.CustomerName[0]))
            //                           .Distinct();



            //3.Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //                           .Intersect(CustomerList.Select(customer => customer.CustomerName[0]));


            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //                          .Except(CustomerList.Select(customer => customer.CustomerName[0]));

            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(product => product.ProductName.Length > 3 ? product.ProductName[^3..] : product.ProductName)
            //    .Concat(CustomerList.Select(customer => customer.CustomerName.Length > 3 ? customer.CustomerName[^3..] : customer.CustomerName)); 

            #endregion

            #region Partitioning Operators

            //1.Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(customer => customer.City == "Washington").Take(3);

            //2.Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(customer => customer.City == "Washington").Skip(2);



            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((number, index) => number != index); 

            //4 . Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(number => number % 3 != 0);

            //5 . Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((number, index) => number > index);


            #endregion

            #region Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var result = Dictionary.Any(word => word.Contains("ei"));
            //Console.WriteLine(result);

            // 2 Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(product => product.Category).Where(category => category.Any(product => product.UnitsInStock == 0));

            //3.Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(product => product.Category).Where(category => category.All(product => product.UnitsInStock != 0));

            #endregion

            #region Grouping Operators
            //1.Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(number => number % 5);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine($"Nubmers with a reminder of {item.Key} when divided by 5 : ");
            //    foreach (var number in item)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //2. Uses group by to partition a list of words by their first letter.  Use dictionary_english.txt for Input
            //var result = Dictionary.GroupBy(word => word[0]); 

            //3 . Use Group By with a custom comparer that matches words that are consists of the same Characters Together
           // string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
           // var result = Arr
           //.GroupBy(word => word, new CustomStringComoparer());


           // foreach (var category in result)
           // {
           //     foreach (var word in category)
           //     {
           //         Console.WriteLine(word);
           //     }
           //     Console.WriteLine("------------------");

           // }


            #endregion


        }
    }
}
