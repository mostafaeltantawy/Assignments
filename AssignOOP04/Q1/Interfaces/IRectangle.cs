using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP04.Q1.Interfaces
{
    public interface IRectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

    }
}
