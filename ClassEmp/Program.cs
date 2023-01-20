using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            string result = emp.Display();
            Console.WriteLine(result);
            
            Emp emp2 = new Emp(10, "Suraj", 15000);
            Console.WriteLine(emp2.Display());

        }
    }
}
