using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 3 },
                {4, 5 },
                {6, 7 },
            };
            Console.WriteLine(numberGrid[2, 1]);
            Console.ReadLine();
        }
    }
}
