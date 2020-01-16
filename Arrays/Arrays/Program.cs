using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumber = { 4, 7, 8, 16, 19 };
            luckyNumber[2] = 600;
            Console.WriteLine(luckyNumber[2]);

            String[] friends = new string[5];
            friends[0] = "Mike";
            friends[1] = "John";
            Console.WriteLine(friends[1]);
            
            Console.WriteLine("what is your Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Good to see you " + name);



            Console.ReadLine();
        }
    }
}
