using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    class WholeSquare {
        public void prompt() {
            Console.WriteLine("Please input the range for the whole square:");
            Console.WriteLine("Please enter A:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter B(B >= A):");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There are {0} whole square numbers in the range", findWholeSquare(num1, num2));
        }
        public int findWholeSquare(int num1, int num2) {
            int minVal = (int)Math.Ceiling(Math.Sqrt(num1));
            int maxVal = (int)(Math.Sqrt(num2));
            int cnt = maxVal - minVal + 1;
            return cnt >= 0 ? cnt : 0;

        }
        static void Main(string[] args) {
            WholeSquare ws = new WholeSquare();
            ws.prompt();
        }
    }
}
