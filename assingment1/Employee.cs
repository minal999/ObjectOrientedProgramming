﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Employee
    {
        int employeeID;
        string name;
        int age;
        string gender;
        double salary;
        string department;

        public void AddDetails()
        {
            employeeID = 1;
            name = "Rakul";
            age = 26;
            gender = "female";
            salary = 80778.31;
            department = "Manager";

        }
        public string DisplayDetails()
        {
            return $"EmployeeID= {employeeID}, Name= {name}, age= {age}, Gender= {gender}, Salary= {salary}, Department= {department}";
        }

    }

}
