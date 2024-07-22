using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Static
{

    // static class contain static members
    // Cannot creat object from it
    // no inheritance


    internal static class Utility
    {
        //Class member instructor 
        // Static constructor
        // only one in the class 
        // doesn't have access modifier 
        // didn't take parameters use only for intialize static fields 
        //it will be called with the first usage of the class 

        static Utility()
        {
            //pi = 3.14; 
        }

   



        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        // Compiler will always intialize the class member attribute with default value 
        const double pi = 3.14 ;

        public static double PI
        {
            get { return pi; }
        }



        public static  double CalcCircleArea(double R)
        {
            return PI * R * R;
        }
    }
}
