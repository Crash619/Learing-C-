using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry poter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Cats Fights";
            book2.author = "Peter";
            book2.pages = 650;

            Console.WriteLine( book1.title+" by "+ book1.author+" has "+ book1.pages+" pages.");
            Console.WriteLine(book2.title + " by " + book2.author + " has " + book2.pages + " pages.");
            Console.ReadLine();
        }
    }
}
