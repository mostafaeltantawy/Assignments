using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
     interface IMyType
    {
        public int Id { get; set; }

        public void MyFun(int x);

        public void Print()
        {
            Console.WriteLine( "Default implemented method insode interface");
        }

    }
}
