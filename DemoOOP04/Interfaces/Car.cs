using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    internal class Car : Vehicle, IMovable
    {

        //Forward()
        //Backward()
        //left()
        //Right
        public void Backward()
        {
            Console.WriteLine("Car Move Backward on Ground");
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
