using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV04.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }
        public void Look() 
        {
            Console.WriteLine($"Refree : {Name} is looking");
        }
    }
}
