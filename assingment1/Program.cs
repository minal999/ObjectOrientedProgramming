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
            Student student1 = new Student();
            Console.WriteLine($"Student1 Details:");
            Console.WriteLine(student1.displayDetails());
            Console.WriteLine($"Student2 Details:");
            Student student2 = new Student(2,"deepa",28,"Female",74.60);
            Console.WriteLine(student2.displayDetails());
            

            Employee employee1 = new Employee();
            Console.WriteLine($"Employee1 Details:");
            Console.WriteLine(employee1.DisplayDetails());
            Console.WriteLine($"Employee2 Details:");
            Employee employee2 = new Employee(2,"vaishali",42,"Female",60500,"Tester");
            Console.WriteLine(employee2.DisplayDetails());
        }
    }
}
