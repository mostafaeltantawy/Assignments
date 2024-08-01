using System.Collections;
using System.Globalization;

namespace DemoADV02
{
    internal class Program
    {
        private static int SumArrayList(ArrayList array)
        {
            int Sum = 0;
            if (array is not null)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    Sum += (int) array[i];
                }
            }
            return Sum;
        }

        public static int SumList(List<int> list) 
        {
            int Sum = 0;
            if(list is not null)
            {
                for(int i = 0;i < list.Count; i++)
                {
                    Sum +=  list[i];
                }
            }
            return Sum ;
        }

     
        static void Main(string[] args)
        {
            #region ArrayList[Non-generic]
            //ArrayList arrayList = new ArrayList(); //Size = 0 

            //Console.WriteLine($"Number of Elemnents {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //arrayList.Add(1);
            //Console.WriteLine($"Number of Elemnents {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //// when it full capacity a new array will be created in the heap moving the old elemnts in it and add the new element
            //// the old array will bo un reachable object 
            //arrayList.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"Number of Elemnents {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //ArrayList arrayList1 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Number of Elemnents {arrayList1.Count} , Capacity : {arrayList1.Capacity}");

            //arrayList1.Add(1);
            //Console.WriteLine($"Number of Elemnents {arrayList1.Count} , Capacity : {arrayList1.Capacity}");

            //arrayList1.TrimToSize(); // deallocate the unused bytes  by creating a new array in the heap its size is the count of the original array
            //                         // and copy the old array elemnts
            //                         // The original array is unreachable object
            //Console.WriteLine($"Number of Elemnents {arrayList1.Count} , Capacity : {arrayList1.Capacity}");

            //arrayList.Add(1); //casting (1) value type to (Object) Reference type 
            //Boxing

            //arrayList.Add("Mostafa"); // casting  // Heterogenous
            //Console.WriteLine($"Number of Elemnents {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //foreach (int i in arrayList)
            //{
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int resul = SumList(arrayList);

            #endregion

            #region Generic Collections
            #region List   => new version of arraylist but with generics
            ////List<int> list = new List<int>();
            ////Console.WriteLine($"Count of the list : {list.Count} , capacity of the list : {list.Capacity} ");
            ////list.Add(1);
            ////list.Add(2);
            ////Console.WriteLine($"Count of the list : {list.Count} , capacity of the list : {list.Capacity} ");
            ////list.AddRange(new int[] {3, 4});
            ////Console.WriteLine($"Count of the list : {list.Count} , capacity of the list : {list.Capacity} ");

            ////list.Add(5);
            ////Console.WriteLine($"Count of the list : {list.Count} , capacity of the list : {list.Capacity} ");
            //////  3 * 4[size of int] = 12  unused bytes 

            ////list.TrimExcess(); // the same behavior of array list by creating a new array with the size of count elemnts 
            ////Console.WriteLine($"Count of the list : {list.Count} , capacity of the list : {list.Capacity} ");

            //List<int> numbers = new List<int>(5) { 1 , 2 , 3, 4 , 5  };
            ////Console.WriteLine($"Count of the list : {numbers.Count} , capacity of the list : {numbers.Capacity} ");
            //numbers.Add(6);
            ////Console.WriteLine($"Count of the list : {numbers.Count} , capacity of the list : {numbers.Capacity} ");

            //foreach (int num in numbers) {
            //    Console.WriteLine(num);
            //}

            //numbers[3] = 40; // use indexer to set a value in place that have a value
            //for (int i = 0; i < numbers.Count; i++) 
            //{
            //    Console.WriteLine(numbers[i]); // Use indexer to get value 
            //}
            ////numbers[6] = 1; //invalid ArgumentOutOfRangeException
            ////// You can't use the indexer of list to add element 
            /////
            //int result = SumList(numbers);
            //Console.WriteLine(result );

            #endregion



            #region List Methods
            //List<int> Numbers = new List<int>() { 1 , 2, 3 , 4 };
            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");
            //Numbers.Add(5); // Add one element 
            //Numbers.AddRange(new int[] { 6, 7 }); // Add range 
            ////Both Add and AddRange add from the end
            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");

            ////foreach (int num in Numbers)
            ////    Console.Write($" {num}"); // 1 2 3 4 5 6 7

            //Numbers.Insert(6, 8);
            //Console.WriteLine("-----------------------");
            ////foreach (int num in Numbers)
            ////    Console.Write($" {num}"); // 1 2 3 4 5 6 8 7
            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");
            //Console.WriteLine("-----------------------");

            //Numbers.InsertRange(4, new int[] { 9, 10 });
            ////foreach (int num in Numbers)
            ////    Console.Write($" {num}"); // 1 2 3 4 9 10 5 6 8
            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");

            //int index = Numbers.BinarySearch(5);
            ////Console.WriteLine(index);

            ////Numbers.Clear();
            ////Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");

            //Console.WriteLine(Numbers.Contains(9));

            //List<int> Numbers = new List<int>() { 1, 2, 3 , 4  };
            //int[] array = new int[10];
            //int[] array = new int[2];


            //Numbers.CopyTo(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);

            //}

            //Numbers.CopyTo(array, 4);

            //Numbers.CopyTo(1  , array , 5 , 3 );
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);

            //}

            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4  ,  5 , 4 , 3 ,2 , 5 , 11 };
            //Console.WriteLine(Numbers.IndexOf(5));
            //Console.WriteLine(Numbers.LastIndexOf(5));

            //Numbers.Remove(3); // Remove the firrst item
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);

            //}



            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");

            //Numbers.EnsureCapacity(9); // 4 => 8 => 10  // it only double in the first time and then if the capacity after duplication desn't satsify it will make at equal to the number
            //Console.WriteLine($"Count of list = {Numbers.Count} , Capacit of the list : {Numbers.Capacity}");











            #endregion

            #region LinkedList 
            //LinkedList<int> list = new LinkedList<int>();
            ////Console.WriteLine(list.Count);

            // list.AddFirst(12);
            ////Console.WriteLine(list.Count);
            ////list.AddFirst(113);
            //list.AddLast(132);

            //LinkedListNode<int> listNode = list.Find(12); 
            //list.AddAfter(listNode , 12341);
            //list.AddBefore(listNode, 100);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            ////foreach (int i in stack)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //stack.Peek(); // return the value of the element on the top of the stack without remove it 
            ////foreach (int i in stack)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //Console.WriteLine( stack.Pop());
            //Console.WriteLine(stack.Pop()); 
            ////Console.WriteLine(stack.Pop());// remove and return the object on top of the stack
            ////Console.WriteLine(stack.Pop());// exception

            //if(stack.TryPop(out int element))
            //    Console.WriteLine(element);

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Qeuee
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            ////foreach(int i in queue)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //queue.Peek();

            ////foreach (int i in queue)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //queue.Dequeue();

            ////foreach (int i in queue)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //if (queue.TryDequeue(out int value)) 
            //{
            //    Console.WriteLine(value);
            //}


            #endregion

            #endregion


        }
    }
    }

