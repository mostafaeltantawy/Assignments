using System.Collections;

namespace AssignADV02
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Q1
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, "Mostafa", 5, 6, true };
            //Q1.ReverseList(list);
            //foreach (object i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2
            //List<int> list = new List<int>() { 1 ,2 ,3 ,4 ,5 , 6, 7, 8, 9 ,10 , 11,12,13 };
            //List<int> PrimeList = Q2.GetEvenNumbersList(list);
            //foreach (int num in PrimeList) 
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region Q3
            FixedSizeList<string> Names = new FixedSizeList<string>(3);
            Names.Add("Mostafa");
            Names.Add("Ali");
            Names.Add("Osama");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Names.Get(i));
            }
            Names.Add("Mohamed");


            #endregion

        }
    }
}
