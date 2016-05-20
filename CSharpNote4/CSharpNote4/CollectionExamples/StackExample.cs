using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.CollectionExamples {
    class StackExample {
        public void StackDemo() {
            Stack st = new Stack();
            st.Push("Wednesday");
            st.Push(DateTime.Now);
            st.Push(3.15f);
            st.Pop();
            foreach (object item in st) {
                Console.WriteLine(item);
            }
        }
    }
}
