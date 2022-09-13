using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Student
    {
        int StudentID;
        string Name;
        int Age;
        string Gender;
        double Percentage;
       
        
        public void AddDetails()
        {
            StudentID = 1;
            Name = "Kuldeep";
            Age = 25;
            Gender = "male";
            Percentage = 80.31;
        }

        public string displayDetails()
        {
            return $"Student ID ={StudentID}, Name ={Name}, Age ={Age}, Gender ={Gender}, Percentage ={Percentage}";
        }

        
    }
}
