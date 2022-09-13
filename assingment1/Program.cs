using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddDetails();
            Console.WriteLine(student.displayDetails());

            Employee employee = new Employee();
            employee.AddDetails();
            Console.WriteLine(employee.DisplayDetails());
        }
    }
}
