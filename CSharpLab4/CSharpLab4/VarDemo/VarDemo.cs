using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab4.VarDemo {
    class VarDemo {
        static public void VarTest() {
            //affects only the declaration of variables at compile time; 
            //the compiler infers the type of the variable from the type of expression used to initialize it
            int[] nums1 = new int[] { 4, 9, 16 };
            var num2 = new int[] { 4, 9, 16 };

            SortedDictionary<string, List<DateTime>> complex1 = new SortedDictionary<string, List<DateTime>>();
            var complex2 = new SortedDictionary<string, List<DateTime>>();
        }
    }
}
