using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assingment2
{
    internal class Student
    {
        int rollno,sub1,sub2,sub3,scored_marks;
        double per;
        String name;

        public Student()
        {
            rollno = 1;
            name = "prakash";
            sub1 = 86;
            sub2 = 77;
            sub3 = 76;
        }

        public Student(int rollNo, string name, int sub1, int sub2, int sub3)
        {
            this.rollno = rollNo;
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }

        public void CalculatePer()
        {
            scored_marks = (sub1 + sub2 + sub3);
            per = (scored_marks / 3);
        }

        public string DisplayDetails()
        {
            return $"RollNo= {rollno}, Name= {name}, Sub1= {sub1}, sub2={sub2}, sub3={sub3}, percentage={per}%";
        }
    }
}
