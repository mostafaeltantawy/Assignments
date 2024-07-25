using DemoADV01.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV01
{
    //in case generic type declared on the class or struct  level the compiler cannot detect the type of T 

    internal class Helper <T> where T : Employee , IComparable<T> , IComparer<T>   , new()
    {
        //public static T Sum (T X  , T Y )
        //{
        //    return X + Y;  /// Invalid
        //}

        //T Salary { get; set; }
        #region Non Generics
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}


        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void SWAP(ref Point X, ref Point Y)
        //{
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;
        //}



        // public static int SearchArray(int[] array , int value)
        //{
        //    if (array != null)
        //    {
        //        for (int i = 0; i < array.Length; i++) 
        //        {
        //            if(array[i] == value)
        //            {
        //                return i;
        //            }
        //        }

        //    }
        //    return -1; 
        //}


        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for(int k  = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k + 1]) == 1  )
                        {
                            Helper<T>.SWAP(ref array[k],ref array[k+ 1]); 
                        }
                    }
                }
            }

        }

        #endregion

        #region Generics
        //in case generic type declared on the method level the compiler can detect the type of T Based of passed parameter 


        public static void SWAP(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }

        //public static int SearchArray(T[] array, T value)
        //{
        //    if (array != null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (value.Equals(array[i]))
        //            {
        //                return i;
        //            }
        //        }

        //    }
        //    return -1;
        ////}
        #endregion



    }
}
