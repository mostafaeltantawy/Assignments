using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Partial
{
    internal partial class Employee
    {
        public void print() {
            Console.WriteLine("I am Employee");
        }

        public partial void Test()
        {
            Console.WriteLine("test");
        }
    }
}
