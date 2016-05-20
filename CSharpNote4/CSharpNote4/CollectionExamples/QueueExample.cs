using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.CollectionExamples {
    class QueueExample {
        public void QueueDemo() {

            Queue q = new Queue();
            q.Enqueue("Wednesday");
            q.Enqueue(15);
            q.Enqueue(DateTime.Now);
            q.Enqueue(true);
            q.Enqueue(3.14f);
            q.Dequeue();


            foreach (var item in q) {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Peek());
        }
    }
}
