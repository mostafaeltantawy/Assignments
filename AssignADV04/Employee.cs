using AssignADV04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV04
{
    class Employee
    {
        #region Props
        private DateTime _birthDate;
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get => _birthDate;
            private set
            {
                if (Helper.CalculateAge(value) > 18)
                {
                    _birthDate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The age should be greater than 18");
                }
            }
        }
        public int VacationStock { get; private set; }

        #endregion


        #region Constructors
        public Employee(int employeeID, DateTime birthDate, int vacationStock = 30)
        {
            EmployeeID = employeeID;
            BirthDate = birthDate;
            VacationStock = vacationStock;
        }

        #endregion

        #region Events
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Employee ID : {EmployeeID}";
        }
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            if (To > From)
            {
                TimeSpan period = To.Date - From.Date;

                if (period.Days <= VacationStock)
                {
                    VacationStock -= period.Days;
                    return true;
                }
            }
            return false;
        }
        public virtual void  EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.NegativeVacationStock });
            }
            else if (Helper.CalculateAge(BirthDate) >= 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAboveSixty });
            }
        }

        #endregion

    }

}
