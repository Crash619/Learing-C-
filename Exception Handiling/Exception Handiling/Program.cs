using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handiling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a Number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();


        }
    }
}
