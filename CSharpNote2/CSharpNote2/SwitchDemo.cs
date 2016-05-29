using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SwitchDemo
    {
        public static void Main()
        {
            Console.Write("Enter 3 letters abbrevation for the day name => ");
            string str = Console.ReadLine();
            switch (str.ToLower())
            {
                case "mon":
                    Console.WriteLine("Monday");
                    break;
                case "tue":
                    Console.WriteLine("Tuesday");
                    break;
                case "wed":
                    Console.WriteLine("Wednesday");
                    break;
                case "thu":
                    Console.WriteLine("Thursday");
                    break;
                case "fri":
                    Console.WriteLine("Friday");
                    break;
                case "sat":
                    Console.WriteLine("Saturday");
                    break;
                case "sun":
                    Console.WriteLine("Sunday");
                    break;
                default:

                    Console.WriteLine("Invalid Option");
                    break;

            }
        }
    }
}
