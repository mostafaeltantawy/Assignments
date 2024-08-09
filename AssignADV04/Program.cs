namespace AssignADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee(12, new DateTime(1980, 1, 1));
            Employee Emp2 = new Employee(13, new DateTime(1960, 1, 1));
            Employee Emp3 = new Employee(14, new DateTime(1963, 1, 1));
            Employee Emp4 = new Employee(15, new DateTime(1972, 1, 1));
            Employee Emp5 = new Employee(16, new DateTime(2000, 10, 1), -2);
            #region Department
            Department HrDepartment = new Department { DeptID = 1, DeptName = "Human Resources" };


            HrDepartment.AddStaff(Emp1);
            HrDepartment.AddStaff(Emp2);
            HrDepartment.AddStaff(Emp3);
            HrDepartment.AddStaff(Emp4);
            HrDepartment.AddStaff(Emp5);

            HrDepartment.DisplayStaff();
            Console.WriteLine("-------------------------After end of Year Operation----------------------");
            Emp1.EndOfYearOperation();
            Emp2.EndOfYearOperation();
            Emp3.EndOfYearOperation();
            Emp4.EndOfYearOperation();
            Emp5.EndOfYearOperation();

            HrDepartment.DisplayStaff();
            #endregion
            Console.WriteLine("--------------------Club--------------------");
            #region Club
            Club club = new Club { ClubID = 1, ClubName = "Company Club" };
            //Employee Emp06 = new SalesPerson(123, new DateTime(1950, 10, 1), 50);            
            Employee Emp06 = new SalesPerson(123, new DateTime(2000, 10, 1), 20);
            BoardMember Emp07 = new BoardMember(1523, new DateTime(2000, 10, 1) , -60); 
            club.AddMember(Emp1);
            club.AddMember(Emp2);
            club.AddMember(Emp3);
            club.AddMember(Emp4);
            club.AddMember(Emp5);
            club.AddMember(Emp06);
            club.AddMember(Emp07);


            club.DisplayStaff();
            Console.WriteLine("-------------------------After end of Year Operation----------------------");
            Emp1.EndOfYearOperation();
            Emp2.EndOfYearOperation();
            Emp3.EndOfYearOperation();
            Emp4.EndOfYearOperation();
            Emp5.EndOfYearOperation();
            Emp06.EndOfYearOperation();
            Emp07.EndOfYearOperation();

            club.DisplayStaff();

            Console.WriteLine("-----------------After reasign-------------------------------");
            Emp07.Resign();
            club.DisplayStaff(); 

            #endregion






        }
    }
}
