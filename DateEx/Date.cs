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

        public void AddValue()
        {
            day = 13;
            month = "sept";
            year = 2022;

        }
        public string DisplayValue()
        {
            return $"Today's date is {day} / {month} / {year}";
        }
    }
}
