using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2 {
    public class Emp {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public string Job { get; set; }
    }

    public class tryIntitialization {

        int i = 3;
        //Emp e = new Emp { EmpNo = 1, EName = "Scott", Job = "Clerk", Salary = 3500 };

        tryIntitialization ij;
        public void output() {
            Console.WriteLine("I am Ok to initialize a class instance");
        }
    }
}
