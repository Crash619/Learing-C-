using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_and_setter
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie(" The avaengers", " Joss Wehdon", "PG-13");
            Movie shrek = new Movie(" Shrek", " Adam Adamson", "PG-13");

            shrek.Rating = "PG-13";

            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
