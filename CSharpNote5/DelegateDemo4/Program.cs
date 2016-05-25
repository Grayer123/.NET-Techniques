using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo4{
    class Program{
        //using Predicate
        static void Main(string[] args) {
            EmpOperations op = new EmpOperations();
            Program p = new Program();
            Predicate<Emp> ed = null;
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

        //using predicate, no need to define these functions
        //public bool ByJob(Emp e) {
        //    return e.Job == "Clerk";
        //}

        //public bool ByName(Emp e) {
        //    return e.EName == "Mia";
        //}
    }
}
