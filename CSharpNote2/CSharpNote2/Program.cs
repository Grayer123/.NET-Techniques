using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    /*
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region leapyear
            Console.Write("Enter a year => ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(year)) {
                Console.WriteLine(year + " is a leap year");
            }
            else {
                Console.WriteLine(year + " is not a leap year");
            }
            #endregion

            #region evenorodd
            //Console.Write("Enter a number => ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}
            #endregion


            int z = Convert.ToInt32(null); //0
            //z = int.Parse(null); //throw an exception
            int res;
            bool flag = int.TryParse(null, out res); //flag = False; res = 0
            Console.WriteLine("bool flag = {0}, res = {1}", flag, res);
            //Console.WriteLine(z);


        }
    }
}


