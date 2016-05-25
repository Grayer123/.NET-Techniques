using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo1 {
    public delegate void CommunicateDelegate(int n);
    class Program {
        static void Main(string[] args) {
            MathOperations mclass = new MathOperations();
            MathDelegate del = new MathDelegate(mclass.Add);
            del += mclass.Sub;
            del(10, 20);

            Program p = new Program();
            CommunicateDelegate cd = new CommunicateDelegate(p.GetValues);

            Counter c = new Counter();
            c.PrintCounting(cd);

            Console.ReadKey();
        }

        public void GetValues(int p) {
            Console.WriteLine(8 * p);
        }
    }

    class Counter {
        public void PrintCounting(CommunicateDelegate c) {
            for (int i = 1; i < 11; i++) {
                c(i);
            }
        }
    }
}
