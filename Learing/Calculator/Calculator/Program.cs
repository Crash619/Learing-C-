using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Please Enter the First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Please Enter theSecond Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(num1 + num2);


            Console.ReadLine();
        }
    }
}
