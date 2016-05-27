using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo {
    class Program {
        static void Iterator1980To2000(IEnumerator<int> num) {
            if(num.Current == 0) {
                num.MoveNext();
            }
            if(num.Current < 2001) {
                Console.WriteLine(num.Current);
                if (num.MoveNext()) {
                    Iterator1980To2000(num);
                }
            }
            else {
                Iterator2001To2020(num);
            }
            
        }

        static void Iterator2001To2020(IEnumerator<int> num) {
            if (num.Current > 2000) {
                Console.WriteLine((num.Current + 2000));
                if (num.MoveNext()) {
                    Iterator1980To2000(num);
                }
            }
            else if(num.Current < 2001) {
                Iterator2001To2020(num);
            }           
        }


        static void Main(string[] args) {
            List<int> oyears = new List<int>();
            oyears.Add(2016);
            oyears.Add(2003);
            oyears.Add(2010);
            oyears.Add(2005);
            oyears.Add(1987);
            oyears.Add(1986);
            oyears.Add(2007);
            oyears.Add(2018);

           /*//IEnumerable uses IEnumerator internally
            * //the biggest difference between IEnumerable and IEnumerator: IEnumerable does not remember 
            * //currently which row is iterating through while IEnuemrator does
            */

           /*
            * public interface IEnumerable<out T> : IEnumerable {
            *       IEnumerator<T> GetEnumerator();
            * }
            */

            IEnumerable<int> ienumerable = (IEnumerable<int>)oyears;
            foreach(int i in ienumerable) {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            /*
             * IEnumerator remembers currently which row is iterating through
             * public interface IEnumerator {
             *     object Current { get; }
             *     bool MoveNext();
             *     void Reset();
             * }             
             */
            //IEnumerator<int> ienumerator = (IEnumerator<int>)oyears; //InvalidCastException
            IEnumerator<int> ienumerator = oyears.GetEnumerator();
            //while (ienumerator.MoveNext()) {
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}
            Console.WriteLine("\n");

            Iterator1980To2000(ienumerator);
        }
    }
}



