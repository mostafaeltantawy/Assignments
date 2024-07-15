using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Polymorphism
{
    internal class TypeA
    {
     

        public int A { get; set; }
        //Complier will Generate backing field
        public TypeA(int a)
        {
            A = a;
        } 

        // object member functions [Non Static]

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
}
