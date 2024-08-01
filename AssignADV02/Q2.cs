

namespace AssignADV02
{
    internal class Q2
    {
        public static List<int> GetEvenNumbersList(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                int CurrentNumber = list[i];
                if (CurrentNumber %2 == 0 )
                {
                    result.Add(CurrentNumber);
                }
            }
            result.TrimExcess(); 

            return result ;

        }

    }
}
