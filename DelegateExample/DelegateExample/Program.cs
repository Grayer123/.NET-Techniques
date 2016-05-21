using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample {
    //this delegate could point to any function with void return type and string parameter
    /// <summary>
    /// create instance of delegate
    /// </summary>
    /// <param name="msg"></param>
    public delegate void HelloFunctionDelegate(string msg);

    delegate bool IsPromotable(Employee empl);

    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        /// <summary>
        /// hard code: Experience >= 5, not reusable
        /// </summary>
        /// <param name="employeeList"></param>
        //public static void PromoteEmployee(List<Employee> employeeList) {
        //    foreach(Employee employee in employeeList) {
        //        if(employee.Experience >= 5) {
        //            Console.WriteLine(employee.Name + " promoted");
        //        }
        //    }
        //}
        /// <summary>
        /// passing in a function as a parameter 
        /// no hard code; could be reused
        /// </summary>
        /// <param name="employeeList"></param>
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligible) {
            foreach (Employee employee in employeeList) {
                if (isEligible(employee)) {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }

    class Program {
        public static void Hello(string strMsg) {
            Console.WriteLine(strMsg);
        }

        public static bool Promote(Employee emp) {
            if(emp.Experience >= 5) {
                return true;
            }
            return false;
        }
        static void Main(string[] args) {
            //a delegate is a type safe function pointer
            //passing the name of the function that would like to be invoked
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { Id = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { Id = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);
            //Employee.PromoteEmployee(empList, isPromotable);
            //lamd function
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
            //Employee.PromoteEmployee(empList);
        }
    }
}
