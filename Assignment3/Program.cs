using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Details:");
            Employee employee = new Employee(1, "Heena", 80000);
            employee.CalculateSalary();
            Console.WriteLine(employee.Details());
        }
    }
}
