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
       
        
        public Student()
        {
            studentID = 1;
            name = "Kuldeep";
            age = 25;
            gender = "male";
            percentage = 80.31;
        }

        public Student(int studentID, string name, int age, string gender, double percentage)
        {
            studentID = 1;
            name = "Kuldeep";
            age = 25;
            gender = "male";
            percentage = 80.31;
            this.studentID = studentID;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.percentage = percentage;
        }

        public string displayDetails()
        {
            return $"Student ID ={studentID}, Name ={name}, Age ={age}, Gender ={gender}, Percentage ={percentage}";
        }

        
    }
}
