using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckNumbers = { 1, 2, 3, 5, 6, 8, 6, 4 };
            

            for ( int i = 0; i<luckNumbers.Length; i++)
            {
                Console.WriteLine(luckNumbers[i]);
                  
            }

            Console.ReadLine();
        }
    }
}
