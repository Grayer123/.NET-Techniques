using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote5.GenericExample {
    class CompareValue {
        public bool CompareTwoValues(int a, int b) {
            //return a.Equals(b);
            return a == b;
        }
        //make it as an object
        //undesired Boxing is occuring here

        //float is a value type
        //object = ref type
        //must be slower

        //compare a string with a float number: like: "20.15f", 20.15f
        //this does not make any sense, because a float number could not compare with a string
        //Conversion of a value type to ref type is called boxing 
        //conversion of ref type to value type is called unboxing
        /// <summary>
        /// when using generic T, == could not be applied on T; so we could use Equals() function
        /// </summary> using System.Object type causes two problems:
        /// 1. AreEqual() method is not type safe: could pass int and string for comparison, which does not make sense
        /// 2. Performance degradation due to boxing and unboxing
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool CompareTwoValues(object a, object b) {
            return a.Equals(b);
        }

        //could be any type, like the template
        public bool CompareTwoValues<T>(T a, T b) {
            return a.Equals(b);
        }
    }

    //make a generic class
    class CompareValue2<S,T> {
        public bool IsEqual(T a, T b) {
            //return a == b; //== could not be applied to type T
            return a.Equals(b);
        }

        public int IsLarger(S a, S b) {
            return a.ToString().CompareTo(b.ToString());
        }
    }

    //make a generic class
    class CompareValue2<T> where T : struct {
        //class CompareValue2<T, S> where T : struct {
        //    CompareValue

        }
}
