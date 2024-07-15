using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Polymorphism
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a , int b):base(a)
        {
            B = b;

        }

        //overriding
        // Usnig [new]
        // Static binding happen during compilation 
        // Binding functin call on the refrence type  not the object type 

       public new void MyFun01() // new version [Masking]
        {
            Console.WriteLine("I am derived [child]");
        }


        // Using [override]
        //Function must be inherited from parent 
        //Dynamic Binding [Late Binding ]
        // Dynamic binding works during run time 
        // clr Will bind function call based on object type 


        public override void MyFun02()
        {
            Console.WriteLine($"Type B : A = {A} , B = {B}");
        }
    }
}
