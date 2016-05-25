using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo3 {
    class Program {
        //anonymous method
        /// <summary>
        /// when using the anonymous method:
        /// 1. the function that delegate points to is very simple: like one line or two lines of code
        /// 2. reduce overhead: the improvement of performance of anonymous method over normal method is huge:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            EmpOperations op = new EmpOperations();
            Program p = new Program();
            EmpDelegate ed = null;
            Console.WriteLine("how do you want to promote the Employee:");
            string str = Console.ReadLine();
            switch (str.ToLower()) {
                case "job":
                    ed = delegate (Emp e) {
                        return e.Job == "Clerk";
                    };
                    break;
                case "name":
                    Console.Write("Enter name => ");
                    string name = Console.ReadLine();
                    ed = delegate (Emp e) {
                        return e.EName == name;
                    };
                    break;
            }
            op.PromoteEmp(ed);
            Console.ReadKey();
        }

        //use anonymous methods: no need to provide these function;
        //directly put the logic into the delegate statement
        //public bool ByJob(Emp e) {
        //    return e.Job == "Clerk";
        //}

        //public bool ByName(Emp e) {
        //    return e.EName == "Mia";
        //}
    }
}