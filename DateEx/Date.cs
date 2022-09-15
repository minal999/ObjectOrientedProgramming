using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx
{
    internal class Date
    {
        int day, year;
        string month;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {  year = value;}
        }
        public override string ToString()
        {
            return $"Today's date is {day} / {month} / {year}";
        }
    }
}
