using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assingment2
{
    internal class Employee
    {
        int empid,basic_salary,allowance,total_Salary;
        String empname;
        int pf;

        public Employee()
        {
            empid = 1;
            empname = "Ram";
            basic_salary = 100000;
            allowance = 25000;
        }
        public Employee(int empid, int basic_salary, int allowance, string empname)
        {
            this.empid = empid;
            this.basic_salary = basic_salary;
            this.allowance = allowance;
            this.empname = empname;
        }
        public void CalculateSalary()
        {

            pf = 12 * basic_salary / 100;
            total_Salary=((basic_salary+allowance)-pf);
        }
        public string DisplayDetails()
        {
            return $"EmployeeID= {empid}, Name= {empname}, basic_salary= {basic_salary}, Allowance={allowance},Toatal_Salary={total_Salary}";
        }

    }
}
