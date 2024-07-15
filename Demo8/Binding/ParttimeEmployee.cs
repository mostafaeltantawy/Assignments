using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Binding
{
    public class ParttimeEmployee : Employee
    {
     

        public int CountOfHours { get; set; }
        public decimal  HourRate { get; set; }

     

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am a ParttimeEmployee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age} , CountOfHours = {CountOfHours} , hourRate = {HourRate}");
        }


    }
}
