using AssignADV01.Q01;

namespace AssignADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 [Optimized Bubble Sort]

            ////int[] nums = { 1, 2, 3 };  
            ////Helper<int>.BubbleSort(nums);

            //int[] nums2 = { 11, 2, 9 , 109 , -23};
            //Helper<int>.BubbleSort(nums2);
            //foreach (int i in nums2) 
            //    Console.WriteLine(i);




            #endregion

            #region Q2 

            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine(intRange.Length());
            Console.WriteLine(intRange.IsInRange(5));
            Console.WriteLine(intRange.IsInRange(11));


            // Test with doubles
            Range<double> doubleRange = new Range<double>(1.5, 5.5);
            Console.WriteLine(doubleRange.Length());
            Console.WriteLine(doubleRange.IsInRange(3.0));
            Console.WriteLine(doubleRange.IsInRange(6.0));

            #endregion
        }
    }
}
