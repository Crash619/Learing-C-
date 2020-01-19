using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Please Chose and Operator: ");
            string OP = Console.ReadLine();

            Console.WriteLine("Please Enter  your Second Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
             if (OP == "+"){
                Console.WriteLine(num1 + num2);
            }
             else if( OP == "*")
            {
                Console.WriteLine(num1 * num2);
            }
             else if( OP == "/")
            {
                Console.WriteLine(num1 / num2);
            }
             else if( OP == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadLine();
        }
    }
}
