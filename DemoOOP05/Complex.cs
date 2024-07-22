using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        #region Operators Overloading

        // + 
        // non private - static
        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex()
            {
                Real = (x?.Real ?? 0) + (y?.Real ?? 0),
                Imag = (x?.Imag ?? 0) + (y?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex()
            {
                Real = (x?.Real ?? 0) - (y?.Real ?? 0),
                Imag = (x?.Imag ?? 0) - (y?.Imag ?? 0)
            };
        }

        public static Complex operator ++(Complex x)
        {
            return new Complex()
            {
                Real = (x?.Real ?? 0) + 1,
                Imag = x?.Imag ?? 0

            };
        }

        public static Complex operator --(Complex x)
        {
            return new Complex()
            {
                Real = (x?.Real ?? 0) - 1,
                Imag = x?.Imag ?? 0

            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            else
                return left.Real > right.Real;

        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            else
                return left.Real < right.Real;

        }
        #endregion

        #region Casting Operator OverLoading

        public static explicit operator int(Complex x)
        {
            return x?.Real ?? 0;
        }

        // Implicit  work as implicit and explicit but the explicit is the recommeneded
        public static implicit operator string(Complex x)
        {
            return x?.ToString() ?? string.Empty ;
        }
        #endregion

    }
}
