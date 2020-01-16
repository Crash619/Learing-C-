using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mthods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike",32);
            Console.ReadLine();
        }
        static void SayHi( String name,int age)
        {
            Console.WriteLine("Hello " +name+" Your age is:"+ age);
        }
    }
}
