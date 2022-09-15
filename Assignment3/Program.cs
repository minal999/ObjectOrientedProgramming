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
            Employee employee1 = new Employee {EmployeeID=1,EmployeeName="yami",Basic=28000,Pt=500};
            //Employee employee = new Employee("Heena", 80000,200);
            employee1.CalculateSalary();
            //Console.WriteLine(employee.Details());
            //Console.WriteLine(Employee.DisplayCount());
            Console.WriteLine(employee1);
        }
    }
}
