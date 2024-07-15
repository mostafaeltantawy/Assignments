using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Polymorphism
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a, int b, int c , int d) : base(a, b, c)
        {
            D = d;

        }

        public new void MyFun01() // new version [Masking]
        {
            Console.WriteLine("I am derived [Grand grand child]");
        }



        public new virtual void MyFun02()
        {
            Console.WriteLine($"Type D : A = {A} , B = {B} , C = {C} , D = {D}");
        }



    }
}
