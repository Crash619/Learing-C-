using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girrafe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Goerge";
            int characterAge = 70;
            

            Console.WriteLine("There once was a man name " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didnt like being " + characterAge);
            Console.WriteLine(characterName.Contains("Mike"));
            Console.ReadLine();


        }
    }
}
