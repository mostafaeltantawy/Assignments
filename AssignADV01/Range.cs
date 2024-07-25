

using System.Numerics;

namespace AssignADV01
{
    internal class Range<T> where T :   IComparable<T>, ISubtractionOperators<T, T, T>
    {


        public T Minimum { get; }
        public T Maximum { get; }


        public Range(T minimum, T maximum)
        {
            if (minimum == null || maximum == null) throw new ArgumentNullException("Minimum and Maximum mustn't be null");
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum should be less than maximum");
            }
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T Value)
        {
            return Value?.CompareTo(Minimum) >= 0 && Value?.CompareTo(Maximum) <= 0;
        }

        public T Length()
        {
            return Maximum - Minimum ;
        }


    }
}
