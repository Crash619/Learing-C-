using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Lips_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            String Color, PluralNoun, Food;

            Console.WriteLine("Plese Choose a color: ");
            Color = Console.ReadLine();

            Console.WriteLine("Plese Choose a Plural Noun: ");
            PluralNoun = Console.ReadLine();

            Console.WriteLine("Plese Choose a food: ");
            Food = Console.ReadLine();

            Console.WriteLine("Roses are "+Color);
            Console.WriteLine( PluralNoun+" are Blue");
            Console.WriteLine("I eat "+Food);

            Console.ReadLine();
        }
    }
}
