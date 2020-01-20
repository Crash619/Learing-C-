using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gussing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraff";
            string guss = "";
            int gussCount = 0;
            int gussLimit = 3;
            bool outOfGusses = false;

            while( guss != secretWord && !outOfGusses)
            {
                if (gussCount < gussLimit)
                {
                    Console.Write(" Enter yor Guess: ");
                    guss = Console.ReadLine();
                    gussCount++;

                }
                else
                {
                    outOfGusses = true;
                }
                

             }
             if(outOfGusses)
             {
                Console.WriteLine(" You Lose!!!");
                }
             else
                {
                Console.WriteLine("You win");
             }
            



            Console.ReadLine();


        }
    }
}
