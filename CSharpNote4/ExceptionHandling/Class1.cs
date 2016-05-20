using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Class1{
        public void ExceptionHandlingDemo() {
            try {
                Console.Write("Enter a number => ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your age => ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 30) {
                    throw new CustomException();
                }
            }
            catch (FormatException fe) {
                Console.WriteLine("Only Integers are allowed");
            }
            catch (OverflowException oe) {
                Console.WriteLine("Value must be in the range of {0} to {1}", int.MinValue, int.MaxValue);
            }
            catch (CustomException ce) {
                Console.WriteLine(ce.Message);
            }
            catch (Exception ex) {
                Console.WriteLine("Please check the entered value");
            }
            finally {
                Console.WriteLine("This code will execute in both cases");
            }
        }
    }
}
