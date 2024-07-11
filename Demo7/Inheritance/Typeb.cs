using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7.Inheritance
{
    internal class TypeB : TypeA
    {
        public void Print()
        {
            //Without inheritance 
            //TypeA typeA = new TypeA();
            //typeA.X = 10;  //Invalid [Private ]
            //typeA.Y = 20; // invalid [Private]
            //typeA.Z = 30; // Valid [internal]
            //typeA.M = 34; //invalid[Private]

            //with inheritance

           // X = 10;  //valid [Private ]
           // Y = 20; // valid [Private]
           //Z = 30; // Valid [internal]
           //M = 34; //invalid[Private]
        }
    }
}
