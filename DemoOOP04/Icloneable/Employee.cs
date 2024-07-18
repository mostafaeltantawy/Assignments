using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Icloneable
{
    public class Employee : ICloneable , IComparable
    { 
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Salary{ get; set; }

        public Employee(Employee employee ) 
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;   

        }
        public Employee()
        {
                
        }


        //Deep Copy
        public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}"; 
        }

        public int CompareTo(object? obj)
        {
            // +ve => this.salary > obj.Salary
            // -ve => this.salary < obj.Salary 
            // 0 => this.salary == obj.Salary 

            Employee PassedEmployee = (Employee) obj; 
            if (this.Salary > PassedEmployee.Salary)
            
                return 1;
            else if (this.Salary > PassedEmployee.Salary)
                return -1;
            else return 0;
            
        }
    }
}
