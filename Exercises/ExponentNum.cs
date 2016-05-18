using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework0516 {
    class ExponentNum {
        public void prompt() {
            Console.WriteLine("By default, output the first 100 ExponentNum numbers:");
            int range = 100;
            OutputExponent(range);
        }
        public void OutputExponent(int range) {
            if(range < 1) {//error handling
                return;
            }
            int cnt = 0;
            SortedSet<int> st = new SortedSet<int>();
            st.Add(1);
            while (cnt < range) {
                st.Add(st.First() * 2);
                st.Add(st.First() * 3);
                Console.Write(String.Format("{0, -8}", st.First()));
                st.Remove(st.First());
                cnt++;
                if (cnt % 10 == 0) {//each row output 10 nums
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args) {
            ExponentNum en = new ExponentNum();
            en.prompt();
        }
    }
}
