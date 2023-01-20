using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmp
{
    internal class Emp
    {
        private int empid;
        private string empname;
        private double salary;


        //constructor
        public Emp()
        {
            empid = 1;
            empname = "Amit";
            salary = 40000;
        }
        public Emp(int e, string enm, double sal)
        {
            empid = e;
            empname = enm;
            salary = sal; ;
        }
        public string Display()
        {
            return $"Empid {empid} Empname {empname} Salary {salary}";
        }

    }
}
