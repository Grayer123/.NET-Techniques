using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate {
    public delegate void SampleDelegate();
    class Program {
        public static void SampleMethodOne() {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo() {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree() {
            Console.WriteLine("SampleMethodThree Invoked");
        }
        static void Main(string[] args) {
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //del4 = del1 + del2 + del3 - del2;
            //del4();

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodThree;
            del += SampleMethodTwo; //register del also with SampleMethodTwo 
            del -= SampleMethodOne; //un-register       
            del();
            
        }
    }
}
