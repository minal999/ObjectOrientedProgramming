using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.studentID = 1;
            student1.name = "Kajal";
            student1.sub1 = 90;
            student1.sub2 = 88;
            student1.sub3 = 80;
            student1.Result();
            Console.WriteLine(student1);
            //Console.WriteLine($"Student Details:\n Student ID:{student1.StudentID}\nStudent Name:{student1.Name}\n Student Percentage:{student1.percentage}");
        }
    }
}
