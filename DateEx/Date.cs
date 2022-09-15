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
            { year = value; }
        }
        //public int Day { get; set; }
        //public string Month { get; set; }
        //public  int Year { get; set; }

        //public Date(int day,string month,int year)
        //{
        //       this.Day = day;
        //    this.Month = month;
        //        this.Year = year;
        //}
        public override string ToString()
        {
            return $"Today's date is {day} / {month} / {year}";
        }
    }
}
