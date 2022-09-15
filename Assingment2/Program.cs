using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee();
            //Console.WriteLine("Employee1 Details:");
            //employee1.CalculateSalary();
            //Console.WriteLine(employee1.DisplayDetails());

            //Console.WriteLine("Employee@ Details:");
            //Employee employee2 = new Employee(2, 45000, 5000, "Kunal");
            //employee2.CalculateSalary();
            //Console.WriteLine(employee2.DisplayDetails());


            Student student1 = new Student();
            Console.WriteLine("Student1 Details:");
            student1.CalculatePer();
            Console.WriteLine(student1.DisplayDetails());

            Console.WriteLine("Student2 Details:");
            Student student2 = new Student(2, "Biswa", 85, 94, 70);
            student2.CalculatePer();
            Console.WriteLine(student2.DisplayDetails());


            //Circle circle = new Circle(2.5);
            //circle.CalculateArea();
            //Console.WriteLine(circle.Display());

            //Rectangle rectangle = new Rectangle(12, 4);
            //rectangle.CalculatePerimeter();
            //Console.WriteLine(rectangle.Display());



        }
    }
}
