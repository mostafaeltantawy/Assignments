using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV03
{
    internal class Helper<T>
    {
        //    public static List<int> GetNumbersBasedOnFunctions(List<int> numbers , NumberConditionFunc func) 
        //    {
        //        List<int> result = new List<int>();
        //        if (numbers is not null) 
        //        {
        //            foreach (int n in numbers) 
        //            {
        //                if(func(n))
        //                {
        //                    result.Add(n);
        //                }
        //            }
        //        }
        //        return result;
        //    }

        public static List<T> GetElementsBasedOnFunctions(List<T> numbers, Predicate<T> func)
        {
            List<T> result = new List<T>();
            if (numbers is not null)
            {
                foreach (T n in numbers)
                {
                    if (func(n))
                    {
                        result.Add(n);
                    }
                }
            }
            return result;
        }


        //public static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> result = new List<int>();
        //    if (numbers is not null)
        //    {
        //        foreach (int n in numbers)
        //        {
        //            if (n % 2 == 0)
        //            {
        //                result.Add(n);
        //            }
        //        }
        //    }
        //    return result;
        //}

        public static bool ChecKStringLengthIs5(string str) 
        {
            if (!string.IsNullOrEmpty(str)) 
            {
               return str.Length >=5;
            }
            return false;
        }
    }
}
