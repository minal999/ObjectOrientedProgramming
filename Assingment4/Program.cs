using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student{StudentID = 1, Name = "Jazz", Sub1 = 76,Sub2 = 84,Sub3 = 94};
            student1.Result();
            Console.WriteLine(student1);
        }
    }
}
