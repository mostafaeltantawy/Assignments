using AssignADV04.Enums;


namespace AssignADV04
{
    internal class SalesPerson : Employee
    {

        public int Quota { get; set; }
        public SalesPerson(int employeeID, DateTime birthDate, int achievedTarget, int vacationStock = 30, int quota = 40) : base(employeeID, birthDate, vacationStock)
        {
            Quota = quota;
            AchievedTarget = achievedTarget;
        }
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int quota)
        {
            Quota = quota;
            return AchievedTarget >= Quota;
        }
        public override void EndOfYearOperation()
        {
            if (!CheckTarget(Quota))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FaliedToAchieveTarget });
            }
        }


    }
}
