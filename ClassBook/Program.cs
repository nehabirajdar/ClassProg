using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            string result = book.Display();
            Console.WriteLine(result);

            Book book2 = new Book(10, "Suraj", 15000);
            Console.WriteLine(book2.Display());

        }
    }
}
