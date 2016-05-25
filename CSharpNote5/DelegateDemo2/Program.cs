using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo2{
    class Program{
        static void Main(string[] args) {
            EmpOperations op = new EmpOperations();
            Program p = new Program();
            EmpDelegate ed = null;
            Console.WriteLine("how do you want to promote the Employee:");
            string str = Console.ReadLine();
            switch (str.ToLower()) {
                case "job":
                    ed = new EmpDelegate(p.ByName);
                    break;
                case "name":
                    Console.Write("Enter name => ");
                    string name = Console.ReadLine();
                    ed = new EmpDelegate(p.ByJob);
                    break;
            }
            op.PromoteEmp(ed);
            Console.ReadKey();
        }

        public bool ByJob(Emp e) {
            return e.Job == "Clerk";
        }

        public bool ByName(Emp e) {
            return e.EName == "Mia";
        }
    }
}
