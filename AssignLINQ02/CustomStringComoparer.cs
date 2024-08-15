using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLINQ02
{
    internal class CustomStringComoparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
                return false;

            return String.Concat(x.OrderBy(c => c)) == String.Concat(y.OrderBy(c => c));
        }

        public int GetHashCode(string obj)
        {
            if (obj == null)
                return 0;

            return String.Concat(obj.OrderBy(c => c)).GetHashCode();
        }
    }
}
