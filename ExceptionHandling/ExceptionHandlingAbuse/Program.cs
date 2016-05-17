using System;

namespace ExceptionHandlingAbuse {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Please enter Numerator:");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Denominator:");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int res = Numerator / Denominator;
                Console.WriteLine("Res = {0}", res);
            }
            catch (FormatException) {
                Console.WriteLine("Please enter a number.");
            }
            catch (OverflowException) {
                Console.WriteLine("Only numbers between {0} && {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
