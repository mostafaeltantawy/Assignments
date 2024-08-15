using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignLINQ02
{
    internal class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x == null) return (y == null) ? 0 : -1;
            if (y == null) return 1;
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
