using Day_01_G03;
using System.Collections;
using System.Text.RegularExpressions;

namespace DemoLINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = ListGenerator.ProductsList;
            var CustomerList = ListGenerator.CustomersList;
            #region Filteration [Restrictions] operators [Where - OfType]


            #region Where
            //var outOfStockProducts = ProductList.Where(product => product.UnitsInStock == 0);

            //outOfStockProducts = from product in ProductList 
            //                     where product.UnitsInStock == 0
            //                     select product;

            //outOfStockProducts = ProductList.Where(product => product.UnitsInStock == 0 && product.Category == "Meat/Poultry");


            //outOfStockProducts = from product in ProductList
            //                     where product.UnitsInStock == 0 && product.Category == "Meat/Poultry"
            //                     select product; 
            #endregion

            #region Indexed where
            // Indexed Where 
            // Valid only with fluent syntax , can't write it with query syntax

            //var result = ProductList.Where((product, index) => index < 20 && product.UnitsInStock == 0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region OfType

            //ArrayList mixedList = new ArrayList() { 1 , 2 , "Mostafa" , "Osama" , 12,34};
            //List<int> number = mixedList.OfType<int>().ToList();
            //foreach (int numberItem in number) 
            //{
            //    Console.WriteLine(numberItem);
            //}

            #endregion






            #endregion

            #region Tranformation (Projection) Operators [Select - SelectMany]
            #region Select
            //var productsNames = ProductList.Select(product => product.ProductName);

            //productsNames = from product in ProductList
            //                select product.ProductName; 
            #endregion

            #region IndexedSelect
            // Indexed Select 
            // Valid only with fluent syntax , can't write it with query syntax

            //var productsNames = ProductList.Where(product => product.UnitsInStock == 0)
            //                               .Select((product, index) => $"{product.ProductName} , {index}"); 
            #endregion

            #region MultiSelect

            //var products = ProductList.Where(product => product.UnitsInStock == 0)
            //                            .Select(product => new
            //                        {
            //                            Id = product.ProductID,
            //                            Name = product.ProductName,
            //                            Price = product.UnitPrice
            //                        });

            //products = from product in ProductList
            //           where product.UnitsInStock == 0
            //           select new
            //           {
            //               Id = product.ProductID,
            //               Name = product.ProductName,
            //               Price = product.UnitPrice
            //           };

            #endregion

            #region SelectMany

            //var customers = CustomerList.SelectMany(customer => customer.Orders);
            //var customers = CustomerList.SelectMany((customer , index )=> customer.Orders); 
            //var customers = CustomerList.SelectMany(customer  => customer.Orders , (customer , order) => new {}); 

            //customers = from customer in CustomerList
            //            from order in customer.Orders
            //            select order;

            //var students = new[]
            //{
            //    new {Name = "Mostafa" , Grades = new int []{85 , 70 ,80 } }, 
            //    new {Name = "Ali" , Grades = new int []{823 , 701 ,1280 } }, 
            //    new {Name = "Mostafa" , Grades = new int []{2385 , 12370 ,12380 } }, 
            //};

            //var studentsGrades = students.SelectMany(student => student.Grades, (student, grade) => new { Name = student.Name, Grade = grade }); 

            #endregion


            #endregion

            #region OrderingOperators
            //var orderedProduct = ProductList.OrderBy(product => product.UnitPrice);
            //var orderedProduct = ProductList.OrderBy(product => product.UnitPrice).ThenBy(product => product.UnitsInStock);

            //orderedProduct = from product in ProductList
            //                 orderby product.UnitPrice, product.UnitsInStock descending
            //                 select product;

            //foreach (var product in orderedProduct)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region ElementOperators - ImmediateExecution
            //Valid only in fluent syntax

            //List<Product> products = new List<Product>();

            //var product = ProductList.First();
            //var product =  products.First(); // Throw Exceprion
            //var product = products.FirstOrDefault();
            //var product = ProductList.First(product => product.UnitsInStock == 0 );

            //var product = ProductList.Last(product => product.UnitsInStock == 14); 
            //var product = ProductList.LastOrDefault(product => product.UnitsInStock == 14);
            //Console.WriteLine(product);

            //var product = ProductList.ElementAt(3);

            //product = ProductList.ElementAt(new Index(5, true));

            // ElementaAt will Throw exception if the collection is empty or the index is Greater than the size of the Collection

            //product = ProductList.ElementAtOrDefault(1000);

            //var product = ProductList.Single();

            // Single 
            // Will throw exception if the sequence contains more than one Element 
            // Will throw exception if the sequence contains no element 
            // will work only if the sequence contains just contains one element 

            //var product = ProductList.SingleOrDefault();
            // SingleOrDefault 
            // Will throw exception if the sequence contains more than one Element 
            // will work only if the sequence contains just contains one element or sequence is empty 

            //Sinle with delegate 
            // Will work only if there is a item mathc the condition 
            // anything will throw exception
            //var product = ProductList.SingleOrDefault(product => product.UnitsInStock == 0); 



            //Console.WriteLine(product);


            #endregion

            #region Aggregate Operators - Immediate Execution

            //var count = ProductList.Count;
            //count = ProductList.Count(product => product.UnitsInStock==0);

            //Console.WriteLine(count);

            //var max = ProductList.Max(product => product.UnitPrice);
            //var max = ProductList.Max();
            //var max = ProductList.MaxBy(product => product.UnitPrice); 
            //Console.WriteLine(max);

            //var min = ProductList.MinBy(product => product.UnitPrice);
            //Console.WriteLine(min);

            //var sum = ProductList.Sum(product => product.UnitPrice);

            //Console.WriteLine(sum);

            //var average = ProductList.Average(product => product.UnitsInStock);

            //List<int> numbers = new List<int>() {1  , 2,3,98 ,45,234,123,125123,2423,12426 };
            //List<String> text = new List<String>() {"Mohamed " , "Eltantawy" };
            ////var result = numbers.Aggregate((X, Y) => X * Y);

            //var result =  text.Aggregate("Mostafa " , (x, y) => x + y);

            //Console.WriteLine(result);

            #endregion

            #region Casting operators - Immediate Execution

            //List<Product> products = ProductList.Where(product => product.UnitsInStock == 0 ).ToList();

            //Product[] products = ProductList.Where(product => product.UnitsInStock == 0).ToArray();

            ////Dictionary<long, Product> products = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID  ); 
            //Dictionary<long, string> products = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID , product => product.ProductName);


            //foreach (var product in products) 
            //{
            //    Console.WriteLine(product);
            //}

            //HashSet<Product> products = ProductList.Where(product => product.UnitsInStock == 0).ToHashSet();


            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}



            #endregion

            #region Generation Operators
            // The only way to work with generation operator by using enumerable class and call static method

            //var range = Enumerable.Range(1, 100);

            //var repeat = Enumerable.Repeat(new { Name = "ali" }, 10);

            //var empty = Enumerable.Empty<int>().ToList();   // new  List<int>();

            //foreach (var item in repeat) 
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Set Operators - Union Family

            //var sequence = Enumerable.Range(0, 100); 
            //var sequence2 = Enumerable.Range(50, 100); 
            //var result = sequence.Union(sequence2); // without duplicates 
            //var result = sequence.Concat(sequence2).Distinct();

            //var result =sequence.Intersect(sequence2);
            //var result =sequence.Except(sequence2);


            //foreach (var item in result) 
            //{
            //    Console.Write($"{item}, ");
            //}




            #endregion

            #region Quantifier Operators -> return boolean


            //var sequence = Enumerable.Range(0, 100);
            //var sequence2 = Enumerable.Range(0, 100);

            //List<Product> list = new List<Product>();

            //bool flag = ProductList.Any();
            ////flag = list.Any();
            //flag = ProductList.Any(product => product.UnitsInStock == 100000);

            //var flag = list.All(product => product.UnitsInStock == 0); 

            //bool flag = sequence.SequenceEqual(sequence2);
            //Console.WriteLine(flag);

            #endregion

            #region Transformation operators (Projection) - Zip operator
            //List<string> names  = ["Ahmed" , "Ali" , "Osama" , "Hossam" , "Mostafa"];
            //List<int> numbers = Enumerable.Range(0, 10).ToList();

            ////var result = names.Zip(numbers);
            //var result = names.Zip(numbers , new List<int> {10 , 20 , 30  });

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}   

            #endregion

            #region Partitioning Operators

            // Pagination

            //var result = ProductList.Take(5);
            //var result = ProductList.Where(product => product.UnitsInStock == 0).TakeLast(5);
            //var result = ProductList.Skip(5);
            //var result = ProductList.SkipLast(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //int PageIndex = 3, PageSize = 10;

            //var result = ProductList.Skip((PageIndex - 1) * PageSize)
            //                        .Take(PageSize);

            //List<int> numbers = [5 ,  7, 8,6, 31,2,1];

            //var result = numbers.TakeWhile((number , index) => number > index ) ;

            //result = numbers.SkipWhile(number => number % 3 != 0); 


            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Let / Into

            //List<string> names = ["Ahmed", "Mostafa", "Osama", "Mahmoud", "Nadia", "Kareem"];

            //var result = from name in names
            //             select Regex.Replace(name, "[aeiouAEIOU]", "")
            //             into newName
            //             where newName.Length >= 3
            //             select newName;

            //var result = from name in names
            //             let newName = Regex.Replace(name, "[aeiouAEIOU]", "")
            //             where newName.Length >= 3
            //             select newName;

            //var result = names.Select(name => Regex.Replace(name, "[aeiouAEIOU]", ""))
            //                   .Where(name => name.Length >= 3);

            //foreach (string name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Chunk
            //var ChunkProducts = ProductList.Chunk(5);

            //foreach (var Products in ChunkProducts) 
            //{
            //    foreach (var product in Products) 
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("----------------------------------------------------------------");

            //}
            #endregion

            #region Cast

            //IEnumerable<object> objects = [1, 2, 4,"Mostafa" , 5, 6, 7];

            //IEnumerable<int> numbersOnly = objects.OfType<int>();

            //IEnumerable<string> numbers = objects.Cast<string>().ToList();

            //foreach (var number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Contains

            //List<string> names = ["Ahmed", "Mostafa", "Osama", "Mahmoud", "Nadia", "Kareem"];

            //bool isExist = names.Contains("Ahmed");

            //isExist = ProductList.Select(product => product.Category).Contains("Produce");
            //Console.WriteLine(isExist);

            #endregion

            #region Append & Prepend

            //var products = ProductList.Append(new Product()
            //{
            //    ProductID = 13241,
            //    Category = "Produce" ,
            //    ProductName = "Append"
            //});

            //products = products.Prepend(new Product()
            //{
            //    ProductID = 100,
            //    Category = "Produce",
            //    ProductName = "Prepend"
            //});

            //foreach (var product in products) {
            //    Console.WriteLine(product);
            //}

            #endregion

            #region LongCount
            //var count = ProductList.LongCount();
            #endregion






            #region Grouping operators [GroupBy]

            //var productsGroups = ProductList.GroupBy(product => product.Category);
            //productsGroups = from product in ProductList
            //                 group product by product.Category; 

            //foreach (var Group in productsGroups)
            //{
            //    Console.WriteLine(Group.Key);
            //    foreach (var product in Group)
            //    {
            //        {
            //            Console.WriteLine(product);
            //        }


            //    }
            //    Console.WriteLine("------------------------------------------------------------------------------------------------------------");

            //}

            //var Groups = ProductList.GroupBy(product => product.Category)
            //                        .Where(productGroup => productGroup.Count() > 10)
            //                        .Select(productGroup => new {Category = productGroup.Key , Count = productGroup.Count()  });

            //Groups = from product in ProductList
            //         group product by product.Category
            //         into productGroup
            //         where productGroup.Count() > 10
            //         select new { Category = productGroup.Key, Count = productGroup.Count() }; 


            //foreach (var Group in Groups)
            //{
            //    Console.WriteLine(Group);
            //}





            #endregion

            #region MixedSyntax (Query syntax).FluentSyntax

            //var result = (from product in ProductList
            //              where product.UnitsInStock == 0
            //              select product).FirstOrDefault();

            //Console.WriteLine(result);
            #endregion

        }
    }
}
