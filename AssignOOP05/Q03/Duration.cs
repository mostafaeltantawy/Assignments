using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP05.Q03
{
    internal class Duration
    {
        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {


            Hours = hours > 0 ? hours : 0;
            if(minutes > 0)
            {
                Minutes = minutes >= 59 ? 59 : minutes ;
            }
            else
            {
                Minutes = 0; 
            }

            if (seconds > 0)
            {
                Seconds = seconds >=59 ? 59 : seconds;
            }
            else
            {
                Seconds = 0;
            }
            totalSeconds = Hours * 3600 + Minutes * 60 + Seconds;
        }

        public Duration(int seconds)
        {
            if (seconds < 0)
            {
                throw new ArgumentException("Seconds cannot be negative.");
            }
            totalSeconds = seconds;

            Hours = seconds / 3600;
            seconds %= 3600;

            Minutes = seconds / 60;
            seconds %= 60;

            Seconds = seconds;

        }

        #endregion

        #region Props


        private int totalSeconds;

        private int TotalSeconds
        {
            get { return totalSeconds; }
            set
            {
                totalSeconds = value;

                Hours = value / 3600;
                value %= 3600;

                Minutes = value / 60;
                value %= 60;

                Seconds = value;

            }
        }

        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes : {Minutes}, Seconds : {Seconds}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override bool Equals(object? obj)
        {

            if (obj is Duration) // The is operator is used to check if the run-time type of an object is compatible with the given type or not. 
            {
                Duration duration = (Duration)obj;
                return TotalSeconds == duration.TotalSeconds;
            } 
             
            return false;
        }
        #endregion

        #region Operators Overloading
        public static Duration operator +(Duration a, Duration b)
        {
            if (a is null && b is null)
                return new Duration(0, 0, 0);

            if (a is null)
            {
                return b is null ? new Duration(0, 0, 0) : b;
            }

            int totalSeconds = a.totalSeconds + b.totalSeconds;
            return new Duration(totalSeconds);
        }


        public static Duration operator -(Duration a, Duration b)
        {
            if (a is null && b is null)
                return new Duration(0, 0, 0);

            if (a is null)
            {
                return b is null ? new Duration(0, 0, 0) : b;
            }

            int totalSeconds = a.totalSeconds - b.totalSeconds;
            return new Duration(totalSeconds > 0 ? totalSeconds : 0);
        }
        public static Duration operator ++(Duration a)
        {
            a.TotalSeconds += 60; // trigger the TotalSeconds attribute to  reset the another fields 
            return new Duration(a.TotalSeconds);

        }

        public static Duration operator --(Duration a)
        {
            a.TotalSeconds -= 60; // trigger the TotalSeconds attribute to  reset the another fields 
            return new Duration(a.TotalSeconds);

        }

        public static bool operator >(Duration a, Duration b)
        {
            return a?.TotalSeconds > b?.TotalSeconds;

        }

        public static bool operator <(Duration a, Duration b)
        {
            return a?.TotalSeconds < b?.TotalSeconds;

        }
        public static bool operator >=(Duration a, Duration b)
        {
            return a?.TotalSeconds >= b?.TotalSeconds;

        }

        public static bool operator <=(Duration a, Duration b)
        {
            return a?.TotalSeconds <= b?.TotalSeconds;

        }
        #endregion

        #region Casting operator overloading
        public static implicit operator Duration(int sec)
        {
            return new Duration(sec);
        }

        public static implicit operator bool(Duration d) 
        {
            return d is not null;
        }

        public static explicit operator DateTime(Duration d)
        {
            
            return  DateTime.Now.AddSeconds(d?.totalSeconds??0);
        }
        #endregion




    }
}
