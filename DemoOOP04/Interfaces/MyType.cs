using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{

    // class : class => inherit
    // class : interface => implement
    // struct : interface => implement
    // interface : interface => inherit
    internal class MyType : IMyType
    {
        public int Id { get ; set ; }

        // Non static [Object member function]
        public void MyFun(int x)
        {
            Console.WriteLine($"X = {x} ,  id = {Id}");
        }
    }
}
