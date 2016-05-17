using System;
using System.IO;

/*
 * First, we want to do division operation of two integers:
 * but there could be exceptions (FormatException; OverflowException; DivideByZeroException)
 * so we put the statements into the try block, and use a catch(Exception ex) to catch and log msg to log file
 * HOWEVER, when we log error to a log file in the catch block, there could be no such file(this example) Exception, DirectoryNotFoundException...
 * so we should put all these into a try block; and if it occurs, throw a new exception: 
 * throw new FileNotFoundException(filePath + "is not present", ex); the ex is the InnerException, that is the original exception
 *expt.InnerException.GetType().Name to get the inner exception info.
*/
namespace InnerExceptions {
    class Program {
        static void Main(string[] args) {
            try {
                try {
                    Console.WriteLine("Enter First Number:");
                    int fs = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fs / sn;
                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception ex) {
                    string filePath = @"C:\Users\graye\Documents\sample\log1.txt";
                    if (File.Exists(filePath)) {//if the file exists, then log the error msg to file
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("Problem Occurs, Please Try Again Later.");
                    }
                    else {//here just give an example of FileNotFoundException (could be Path exception)
                        throw new FileNotFoundException(filePath + "is not present", ex); //ex is original exception, as a parameter pass to the new exception
                    }
                }
            }
            catch (Exception expt) {
                Console.WriteLine("Current Exception = {0}", expt.GetType().Name); 
                Console.WriteLine("Inner Exception = {0}", expt.InnerException.GetType().Name); //get the InnerException(original exception)
            }
        }
    }
}
