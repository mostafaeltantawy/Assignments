using Assign_7.Classes;
using Microsoft.VisualBasic;


namespace Assign_7

{
    #region Enums
    enum Gender
    {
        Male, Female
    }

    [Flags]
    enum SecurityLevel
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8
    }

    #endregion

    internal class Employee
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }

        double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value > 6000 ? value : 6000;
                
            }
        }

        public SecurityLevel SecurityLevel { get; set; }

        public Gender Gender { get; }


        public HiringDate HiringDate { get; set; }

        #endregion


        #region Constuctors
        public Employee(int id, string name, double salary, SecurityLevel securityLevel, Gender gender, HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            SecurityLevel = securityLevel;
            Gender = gender;
            HiringDate = hiringDate;
        }

        public Employee(int id, string name, Gender gender, HiringDate hiringDate) : this(id, name, 6000, SecurityLevel.Guest, gender, hiringDate)
        {}

        #endregion


        #region Methods
        public override string ToString()
        {
            return string.Format("Id : {0}\nName : {1}\nSalary : {2:c}\nSecurity level : {3}\nGender : {4}\nHiring Date : {5}", Id, Name, salary, SecurityLevel, Gender, HiringDate);

        }

        #endregion

        






    }
}
