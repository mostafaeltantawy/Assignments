using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Polymorphism
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }



       public new void MyFun01() // new version [Masking]
        {
            Console.WriteLine("I am derived [grand child]");
        }



        public override void MyFun02()
        {
            Console.WriteLine($"Type C : A = {A} , B = {B} , C = {C}");
        }

    }
    }

