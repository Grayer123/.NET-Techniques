using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /* while loop is called entry controlled loop because condition gets checked before entering the loop
     * initialization of loop variable
     * condition to exit
     * increment or decrement the value of loop variable
     */
    class WhileLoop
    {
        public static void Main()
        {
            Console.Write("Enter a number => ");
            int number = Convert.ToInt32(Console.ReadLine());
            int loopVariable = 1; //initialization of loop variable
            while (loopVariable < 11) // condition to exit from loop
            {
                Console.WriteLine(number +" X " + loopVariable +" = " + (number*loopVariable));
                loopVariable = loopVariable + 1;  // increment the value of loop variable
                //loopVariable += 1;
                //loopVariable++;
            }
        }
    }
}
