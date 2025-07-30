using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.First_Project
{
    internal class Duration
    {
        public int Hours { get; set; }  
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
             totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }


        public override string ToString()
        {
            string result = "";

            if (Hours > 0)
            {
                result += $"Hours: {Hours}";
            }

            if (Minutes > 0 || Hours > 0)
            
                result += $"Minutes : {Minutes}, ";
              result += $"Seconds : {Seconds}";

            return result;

        }

        public int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() + d2.ToTotalSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        { 
           int ToTotalSeconds = d.ToTotalSeconds() + seconds;
            return new Duration(ToTotalSeconds);

        }
        public static Duration operator +(int seconds , Duration d)
        {

            return d + seconds;
        }

        public static Duration operator ++ (Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            int total = d.ToTotalSeconds() - 60;
            return new Duration(total < 0 ? 0 : total);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int result = d1.ToTotalSeconds() - d2.ToTotalSeconds();
            return new Duration(result < 0 ? 0 : result);


        }

        public static bool operator >(Duration d1, Duration d2)

        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

    }
}
