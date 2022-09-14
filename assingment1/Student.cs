using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Student
    {
        int studentID;
        string name;
        int age;
        string gender;
        double percentage;
       
        
        public void AddDetails()
        {
            studentID = 1;
            name = "Kuldeep";
            age = 25;
            gender = "male";
            percentage = 80.31;
        }

        public string displayDetails()
        {
            return $"Student ID ={studentID}, Name ={name}, Age ={age}, Gender ={gender}, Percentage ={percentage}";
        }

        
    }
}
