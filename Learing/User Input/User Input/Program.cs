using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
             String name = Console.ReadLine();
            Console.WriteLine(" Please Enter Your Age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello " + name +" You are "+age);
            Console.ReadLine();
        }
    }
}
