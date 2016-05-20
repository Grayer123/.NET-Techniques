using System;
using System.Collections; //ArrayList
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.CollectionExamples {
    class ArrayListExample {
        public void ArrayListDemo() {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(true);
            arr.Add(DateTime.Now);
            arr.Add(15.23f);
            arr.Add("Wednesday");
            arr.Remove("Wednesday");

            foreach (object item in arr) {
                Console.WriteLine(item);
            }
        }
    }
}
