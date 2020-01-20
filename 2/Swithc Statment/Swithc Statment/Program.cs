using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swithc_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(3));
            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Subday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 3:
                    dayName = "Tusday";
                    break;

                case 4:
                    dayName = "Wednesday";
                    break;

                case 5:
                    dayName = "Thursday";
                    break;

                case 6:
                    dayName = "Friday";
                    break;

                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid text";
                    break;

            }


            return dayName;
        }

    }
}
