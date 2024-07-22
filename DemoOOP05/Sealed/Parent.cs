using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }


        // sealed Mehtod  -> can be inherited but cannot be overriden
        public virtual void print()
        {
            Console.WriteLine("I am Parent ");
        }
    }
    class Child : Parent
    {
        public sealed override int Salary
        {
            get => base.Salary; set
            {
                base.Salary = value < 5000 ? 5000 : value;

            }
        }
        public sealed override void print()
        {
            Console.WriteLine("I am Child"); ;
        }

    }

    internal sealed class GrandChild : Child
    {
        public new void print()
        {
            Console.WriteLine("I am grand child");
        }

    }
}
