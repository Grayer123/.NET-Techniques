using System;
using System.IO;

namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            StreamReader sr = null;
            try {
                sr = new StreamReader(@"C:\Users\graye\Documents\New folder1\data.txt");
                Console.WriteLine(sr.ReadToEnd());
                
            }
            catch (FileNotFoundException ex) {
                /*
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                */

                //log the details to the DB
                Console.WriteLine("Please check whether the file {0} exists", ex.FileName); //ex.FileName only exists for FileNotFoundException 
            }

            catch(DirectoryNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            finally {//if not put in the finally block, and there is an exception in the catch block, then sr.Close() will not execute
                if(sr != null) { //if sr = null, then it could not be closed
                    sr.Close();
                }
                Console.WriteLine("Finally Block");
            }
        }
    }
}
