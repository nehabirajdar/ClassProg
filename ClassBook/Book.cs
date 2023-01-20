using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    internal class Book
    {
        private int Bookno;
        private string Bookname;
        private double Price;


        //constructor
        public Book()
        {
            Bookno = 1;
            Bookname = "Fire Wings";
            Price = 400;
        }
        public Book(int b, string bnm, double price )
        {
            Bookno = b;
            Bookname = bnm;
            Price = price; ;
        }
        public string Display()
        {
            return $"Bookno {Bookno} Bookname {Bookname} price {Price}";
        }


    }
}
