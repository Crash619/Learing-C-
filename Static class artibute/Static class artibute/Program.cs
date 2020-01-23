using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class_artibute
{
    class Program
    {
        static void Main(string[] args)
        {

            Song Holiday = new Song(" Holiday", " Greed day", 200);
            Console.WriteLine(Song.songCount);
            Song Kashmir = new Song(" Kashmir", " Led zipeline",150);


            Console.WriteLine(Kashmir.getSongCount());
           

            Console.ReadLine();
        }
    }
}
