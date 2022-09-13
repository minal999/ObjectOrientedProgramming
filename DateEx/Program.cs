using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.AddValue();
            Console.WriteLine(date.DisplayValue());
        }
    }
}
