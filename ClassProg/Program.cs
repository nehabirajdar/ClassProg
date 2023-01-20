using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            string result = stud.Display();
            Console.WriteLine(result);
            // 4    5      8
            Student stud2 = new Student(101, "Suraj", 77.77);
            Console.WriteLine(stud2.Display());

        }
    }
}
