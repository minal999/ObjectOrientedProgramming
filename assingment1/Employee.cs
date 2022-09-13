using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Employee
    {
        int EmployeeID;
        string Name;
        int Age;
        string Gender;
        double Salary;
        string Department;

        public void AddDetails()
        {
            EmployeeID = 1;
            Name = "Rakul";
            Age = 26;
            Gender = "female";
            Salary = 80778.31;
            Department = "Manager";

        }
        public string DisplayDetails()
        {
            return $"EmployeeID= {EmployeeID}, Name= {Name}, age= {Age}, Gender= {Gender}, Salary= {Salary}, Department= {Department}";
        }

    }

}
