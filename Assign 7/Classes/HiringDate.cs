namespace Assign_7.Classes
{
    internal class HiringDate
    {
        #region Attributes
        private int day;
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 31)
                {
                    day = 1;

                }
                else
                {
                    day = value;

                }

            }

        }

        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    month = 1;
                }
                else
                {
                    month = value;

                }

            }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value > 2000 ? value : 2000; }
        }

        #endregion

        #region Constructors
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion


        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        #endregion

    }
}
