using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class student
    {
        public int studentID;
        public string name;
        public double percentage, scored_marks,sub1,sub2,sub3;

        public int StudentID { get; set; }
        public String Name { get; set; }
        public double Sub1 { get; set; }
        public double Sub2 { get; set; }
        public double Sub3 { get; set; }

        //public student(int studentID, string name, double sub1, double sub2, double sub3)
        //{

        //    this.StudentID = studentID;
        //    this.Name = name;
        //    this.Sub1 = sub1;
        //    this.Sub2 = sub2;
        //    this.Sub3 = sub3;
        //}

        public void Result()
        {
            scored_marks = (sub1 + sub2 + sub3);
            percentage = (scored_marks / 3);
        }
        public override string ToString()
        {
            return $"Student ID ={studentID}, Name ={name}, Percentage ={percentage}";
        }
    }
}
