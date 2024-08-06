using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV03
{
    public delegate TResult CompareFunction<in T , out  TResult>(T x , T y);
    internal class SortingAlgorithms<T>
    {
        #region Non-generic
        //public static void BubbleSort(int[] array , CompareFunction compareFunction)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (compareFunction(array[j]  , array[j+1]))
        //                    Swap(ref array[j], ref array[j + 1]);
        //            }
        //        }
        //    }
        //}

        #endregion
        public static void BubbleSort(T[] array, Func<T , T , bool> compareFunction)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (compareFunction(array[j], array[j + 1]))
                            Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        //public static void BubbleSortDesc(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j] < array[j + 1])
        //                    Swap(ref array[j], ref array[j + 1]);
        //            }
        //        }
        //    }
        //}

        private static void Swap(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
