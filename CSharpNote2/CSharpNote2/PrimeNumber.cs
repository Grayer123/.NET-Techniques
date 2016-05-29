using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /*
     *  
     *  
     */
    class PrimeNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number => ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadKey();
        }
    }
}
