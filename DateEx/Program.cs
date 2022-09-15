using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DateEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date { Day=16,Month="july",Year=2021};
            
            Console.WriteLine(date);
        

        }
    }
}
