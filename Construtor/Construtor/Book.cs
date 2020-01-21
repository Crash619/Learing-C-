using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    class Book
    {
        public string title;// Class artibutes part of the book
        public string author;// Class artibutes part of the book
        public int pages;// Class artibutes part of the book

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Console.WriteLine(  );
        }
    }
}
