using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    //different project mark it as public class
    //a class by default declared as interal(could be access in the current assemble)
    //a class in a namespace could NOT be declared as private, protected, or protected internal
    //could be declared as public or internal
    class Dept {
        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }
    }
}
