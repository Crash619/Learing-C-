using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are male and Tall");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("you are a male but not tall");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are not a male but tal");
            }
            else
            {
                Console.WriteLine("you are not male or tall");

            }
            Console.ReadLine();
                
            }
        }
    }

