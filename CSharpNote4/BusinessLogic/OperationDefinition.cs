using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    /// <summary>
    /// use ctrl + .
    /// implement it explicitly
    /// then if u inherit from two interfaces, then it will show it clearly
    /// but if u implement it implicitly, then it get ambiguous
    /// </summary>
    class OperationDefinition : IOperation {
        List<Dept> lst = new List<Dept>();

        //implicit
        //public void Insert() { }

        //explicit(because Interface method: public and abstract)
        //so no public keyword added
        void IOperation.Insert() {
            Dept d = new Dept();
            Console.Write("Enter Dept No => ");
            d.DeptNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Dept Name => ");
            d.DName = Console.ReadLine();

            Console.Write("Enter Dept Location => ");
            d.Location = Console.ReadLine();
            lst.Add(d);
        }

        public Dept FindById(int id) {
            foreach (Dept d in lst) {
                if (d.DeptNo == id) {
                    return d;
                }
            }
            return null;
        }

        void IOperation.Delete() {
            Console.Write("Enter Dept No => ");
            int dno = Convert.ToInt32(Console.ReadLine());
            Dept d = FindById(dno);
            if (d != null) {
                lst.Remove(d);
                Console.WriteLine("Dept {0} with Id = {1} has been removed", d.DName, d.DeptNo);
            }
            Console.ReadKey();
        }

        void IOperation.Update() {
            Console.Write("Enter Dept No => ");
            int dno = Convert.ToInt32(Console.ReadLine());
            Dept d = FindById(dno);
            if (d != null) {
                Console.Write("Enter Name => ");
                d.DName = Console.ReadLine();
                Console.Write("Enter Location => ");
                d.Location = Console.ReadLine();
            }
        }

        void IOperation.PrintAll() {
            Console.WriteLine("Dept List");
            Console.WriteLine("Dept No \t Name \t Location");
            foreach (Dept item in lst) {
                Console.WriteLine("{0} \t {1} \t {2}", item.DeptNo, item.DName, item.Location);
            }
            Console.ReadKey();
        }
    }
}
