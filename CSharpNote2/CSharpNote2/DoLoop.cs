using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DoLoop
    {
        public static void Main()
        {
            Console.Write("Enter a number => ");
            int number = Convert.ToInt32(Console.ReadLine());
            int loopVariable = 1;
            do
            {
                Console.WriteLine(number + " X " + loopVariable + " = " + (number * loopVariable));
                loopVariable = loopVariable + 1;  // increment the value of loop variable
            } while (loopVariable < 11);
        }
    }
}
