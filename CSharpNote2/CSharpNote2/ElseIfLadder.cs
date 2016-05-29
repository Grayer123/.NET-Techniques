using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ElseIfLadder
    {
        public static void Main()
        {
            Console.Write("Enter your grades =>");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 80)
            {
                Console.WriteLine("You have scored A grade");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You have scored B grade");
            }
            else if (grade >= 40)
            {
                Console.WriteLine("You have scored C grade");
            }
            else
            {
                Console.WriteLine("Better luck next time !!!");
            }
        }
    }
}
