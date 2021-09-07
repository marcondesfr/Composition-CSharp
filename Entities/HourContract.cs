using System;

namespace Composition.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        { }
        public HourContract(DateTime date, double valuepehour, int hours)
        {
            Date = date;
            ValuePerHour = valuepehour;
            Hours = hours;    
        }

        public double TotalHours()
        {
            return Hours * ValuePerHour;
        }
    }
}