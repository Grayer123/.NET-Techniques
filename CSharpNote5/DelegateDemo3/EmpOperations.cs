using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo3 {
    public delegate bool EmpDelegate(Emp e);
    
   public class EmpOperations
    {
        public List<Emp> GetEmp()
        {
            return new List<Emp> {
            new Emp(){EmpNo=1, EName="Scott", Job="Clerk", Salary=3500},
            new Emp(){EmpNo=2, EName="Steve", Job="Salesman", Salary=4500},
            new Emp(){EmpNo=3, EName="Mia", Job="Clerk", Salary=3400},
            new Emp(){EmpNo=4, EName="David", Job="Clerk", Salary=3700},
            new Emp(){EmpNo=5, EName="Aaron", Job="Salesman", Salary=4300},
            };
        }
        public void PromoteEmp(EmpDelegate emp) {
            List<Emp> lst = new List<Emp>();
            lst = GetEmp();
            foreach (var e in lst) {
                if (emp(e)) {
                    Console.WriteLine(e.EName + " has been promoted");
                }
            }
        }
    }
}
