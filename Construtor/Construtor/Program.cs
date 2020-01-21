using Construtor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry poter", "JK Rowling",400 );
           

            Book book2 = new Book("Cats Fights", "Peter", 650);

            Console.WriteLine(book1.title);

           
            Console.ReadLine();
        }
    }

    internal class BOOK
    {
    }
}
