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

        int empid;
        //private static int count = 0;
        double bs, hra, da, pf, pt,total_salary,net_paid;
        string empname;

        //public Employee( string empname, double bs, double pt )
        //{
        //    count++;
        //    empid = count;
        //    this.empname = empname;
        //    this.bs = bs;
        //    this.pt = pt;
        //}
        //public static int DisplayCount()
        //{
        //    return count;
        //}

        public int EmployeeID
        {
            get { return empid; }
            set{ empid = value; }
        }
        public double Basic
        {
            get { return bs; }
            set { bs = value; }
        }
        public string EmployeeName
        {
            get { return empname; }
            set { empname = value; }
        }
        public double Pt
        {
            get { return pt; }
            set {  pt = value;}
        }
        public void CalculateSalary()
        {
            hra = 40 * bs / 100;
            da = 20 * bs / 100;
            pf = 12 * bs / 100;
            total_salary = bs + hra + da;
            net_paid = total_salary - pf - pt;
        }

        public override string ToString()
        {
            return $"EmployeeID: {empid}\nEmployee Name: {empname}\nBasic Salary: {bs}\nTotal Salary: {total_salary}\nNet Paid: {net_paid}";
        }
    }
}
