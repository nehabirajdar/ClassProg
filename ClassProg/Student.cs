using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProg
{
    public class Student

    {
        private int rollno;
        private string name;
        private double percentage;


        //constructor
        public Student()
        {
            rollno = 1;
            name = "Test";
            percentage = 40;
        }
        public Student(int r, string nm, double per)
        {
            rollno = r;
            name = nm;
            percentage = per;
        }
        public string Display()
        {
            return $"Roll No {rollno} name {name} percentage {percentage}";
        }
    }



}

