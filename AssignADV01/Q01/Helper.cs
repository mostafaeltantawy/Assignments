using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV01.Q01
{
    static class Helper<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool swapped = false; //Swap flag
                    for (int k = 0; k < array.Length - i - 1; k++)
                    {
                        if (array[k].CompareTo(array[k + 1]) == 1)
                        {
                            Helper<T>.SWAP(ref array[k], ref array[k + 1]);
                            swapped = true;
                        }
                    }
                    if (!swapped) // if there is no swap happen that is mean array is sorted so break from the loop 
                        break;
                }
            }



        }
        public static void SWAP(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
    }

}

