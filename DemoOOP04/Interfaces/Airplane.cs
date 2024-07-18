using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    internal class Airplane : Vehicle, IMovable , IFlyable
    {
        
        // Airplane Inherit From Vehicle and Implement Interface (Imavable , IFlyable)

        //Implement implicitly
        public void Backward()
        {
            Console.WriteLine("AirPlane Move Backward");
        }

        //Implement Excplicity

        void IMovable.Forward()
        {
            Console.WriteLine( "Airplane move Forward on Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane move Forward on Air");
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
