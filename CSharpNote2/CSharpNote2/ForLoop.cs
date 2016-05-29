using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /*
     * factorial of a number
     *   eg  5! = 5*4*3*2*1 =120
     *   
     * fibonacci series for homework
     * 0 1 1 2 3 5 8 13
     */
    class ForLoop
    {
        public static void Main()
        {
            Console.Write("Enter a number => ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of {0} is  {1}", number, factorial);
            Console.ReadKey();
        }
    }
}
