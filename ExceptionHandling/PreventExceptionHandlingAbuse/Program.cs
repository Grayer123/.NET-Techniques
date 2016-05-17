using System;

namespace PreventExceptionHandlingAbuse {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Please enter Numerator:");
                int Numerator;
                bool isNumrSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (isNumrSuccessful) {
                    Console.WriteLine("Please enter Denominator:");
                    int Denominator;
                    bool isDemoSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (isDemoSuccessful && Denominator != 0) {
                        int res = Numerator / Denominator;
                        Console.WriteLine("Res = {0}", res);
                    }
                    else {
                        if (Denominator == 0) {
                            Console.WriteLine("Denominator could not be Zero");
                        }
                        else {
                            Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else {
                    Console.WriteLine("Numerator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
