using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV01.Generics
{
    internal class Employee : IComparable
    {
        public int Id;
        public string Name;
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        //public static bool operator ==(Employee a, Employee b)
        //{
        //    return  a.Equals(b) ;
        //}

        //public static bool operator !=(Employee a, Employee b)
        //{
        //    return !a.Equals(b);
        //}
        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj;
            return (this.Id == employee?.Id) && (this.Name == employee?.Name) && (this.Salary == employee?.Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode(), Name?.GetHashCode(), Salary.GetHashCode());
            //return this.Id.GetHashCode() + this.Name?.GetHashCode()??0 + this.Salary.GetHashCode() ; 


        }

        public int CompareTo(object? obj)
        {
            //Employee? PassedEmployee = (Employee?)obj;  // unsafe
            //                                            //Explicit casting 
            //                                            //May throw Exception

            #region Is conditional operator [True | False]
            //Will return true in two casses 
            //1 . obj is Employee 
            //2  . obj is and object from class Inherit From Employee


            //if(obj is Employee PassedEmployee)
            //    return this.Salary.CompareTo(PassedEmployee?.Salary);
            //return 1; 

            #endregion
            #region As Casting operator
            Employee? PassedEmployee = obj as Employee;
            return this.Salary.CompareTo(PassedEmployee?.Salary);
            //Casting happen in two casses 
            //1 . obj is Employee 
            //2  . obj is and object from class Inherit From Employee

            // If failed  return null 
            // Zero Exception  will be thrown


            #endregion


        }
    }
}
