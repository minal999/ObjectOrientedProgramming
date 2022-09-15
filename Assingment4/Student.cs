using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Student
    {
        int studentID;
        string name;
        double percentage,scored_marks,sub1,sub2,sub3;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Sub1
        {
            get { return sub1;}
            set { sub1 = value; }
        }
        public double Sub2
        {
            get { return sub2; }
            set { sub2 = value; }
        }
        public double Sub3
        {
            get { return sub3;}
            set { sub3 = value; }
        }
        public void Result()
        {
            scored_marks = (sub1+sub2+sub3);
            percentage=(scored_marks/3);
        }
        public override string ToString()
        {
            return $"Student ID ={studentID}, Name ={name}, Percentage ={percentage}";
        }

    }
}
