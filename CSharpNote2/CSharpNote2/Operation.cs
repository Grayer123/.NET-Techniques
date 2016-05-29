using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum Operation
    {
        Addition = 1,
        Multiplication,
        Subtraction,
        Division
    }

    public class MathOperations
    {
        public static void Main()
        {

            Console.Write("Enter first float number => ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter second float number => ");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Clear();

            string[] enumName = Enum.GetNames(typeof(Operation));
            int[] enumvalues = (int[])Enum.GetValues(typeof(Operation));
            for (int i = 0; i < enumName.Length; i++){
                Console.WriteLine("Press {0} for {1}", enumvalues[i], enumName[i]);
            }

            Console.Write("Enter option =>");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case (int)Operation.Addition:
                    Console.WriteLine("sum of {0} and {1} is {2}", a, b, (a + b));
                    break;
                case (int)Operation.Subtraction:
                    Console.WriteLine("sub of {0} and {1} is {2}", a, b, (a - b));
                    break;
                case (int) Operation.Multiplication:
                    Console.WriteLine("multiplication of {0} and {1} is {2}", a, b, (a * b));
                    break;
                case (int)Operation.Division:
                    Console.WriteLine("divison of {0} and {1} is {2}", a, b, (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.ReadKey();
        }

    }
}

#region enumNote

    //enum Operation {
    //    Addition = 1,
    //    Multiplication,
    //    Subtraction,
    //    Division
    //}
    //double a = 1.00, b = 2.00;
    //string[] enumName = Enum.GetNames(typeof(Operation));
    //int[] enumvalues = (int[])Enum.GetValues(typeof(Operation));
    //for (int i = 0; i<enumName.Length; i++){
    //    Console.WriteLine("Press {0} for {1}", enumvalues[i], enumName[i]);
    //}

    //Console.Write("Enter option =>");
    //int option = Convert.ToInt32(Console.ReadLine());
    //switch (option){
    //    case (int)Operation.Addition:
    //        Console.WriteLine("sum of {0} and {1} is {2}", a, b, (a + b));
    //        break;
    //    case (int)Operation.Subtraction:
    //        Console.WriteLine("sub of {0} and {1} is {2}", a, b, (a - b));
    //        break;
    //    case (int) Operation.Multiplication:
    //        Console.WriteLine("multiplication of {0} and {1} is {2}", a, b, (a* b));
    //        break;
    //    case (int)Operation.Division:
    //        Console.WriteLine("divison of {0} and {1} is {2}", a, b, (a / b));
    //        break;
    //    default:
    //        Console.WriteLine("Invalid option");
    //        break;
    //}
    //Console.ReadKey();

    #endregion