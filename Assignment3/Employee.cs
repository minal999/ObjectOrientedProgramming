using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Employee
    {

        int empid, bs;
        double hra, da, pf, pt = 200,total_salary,net_paid;
        string empname;

        public Employee(int empid, string empname, int bs)
        {
            this.empid = empid;
            this.empname = empname;
            this.bs = bs;
        }
        public void CalculateSalary()
        {
            hra = 40 * bs / 100;
            da = 20 * bs / 100;
            pf = 12 * bs / 100;
            total_salary = bs + hra + da;
            net_paid = total_salary - pf - pt;
        }

        public string Details()
        {
            return $"EmployeeID: {empid}\nEmployee Name: {empname}\nBasic Salary: {bs}\nTotal Salary: {total_salary}\nNet Paid: {net_paid}";
        }
    }
}
