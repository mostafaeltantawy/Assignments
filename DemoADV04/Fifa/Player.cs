using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV04.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }    
        public void Run()
        {
            Console.WriteLine($"{Name} is Running");
        }
    }
}
