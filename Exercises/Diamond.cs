using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise7;

namespace Exercise6 {
    class Diamond {
        public void PrintDiamond(int row) {
            for(int i = 0; i < row; i++) {//the upper part of diamond 
                for(int j = 0; j < row - i; j++) { //output the white space
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) { //output the star
                    Console.Write("*");
                }
                for (int k = 0; k < i; k++) { //output the remaining star
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = row - 2; i >= 0; i--) {//the lower part of diamond
                for (int j = 0; j <= (row - 1) - i; j++) {//output the white space
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) {//output the white space
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++) {//output the white space
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            Diamond d = new Diamond();
            Console.WriteLine("please specify the rows of the Diamond: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("The Diamond shows:");
            d.PrintDiamond(row);
            Exercise7.ATM ert = new Exercise7.ATM();
        }
    }
}
