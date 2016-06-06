using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageLifeCycleDemo.tables {
    public class Employee {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public int Dept_ID { get; set; }
        public static List<Employee> popEmpData() {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { Emp_ID = 1, Emp_Name = "Sam", Dept_ID = 1 });
            emp.Add(new Employee { Emp_ID = 2, Emp_Name = "Mary", Dept_ID = 2 });
            emp.Add(new Employee { Emp_ID = 3, Emp_Name = "Jack", Dept_ID = 2 });
            emp.Add(new Employee { Emp_ID = 4, Emp_Name = "David", Dept_ID = 1 });
            emp.Add(new Employee { Emp_ID = 5, Emp_Name = "Louis", Dept_ID = 3 });
            emp.Add(new Employee { Emp_ID = 6, Emp_Name = "Vika", Dept_ID = 1 });
            emp.Add(new Employee { Emp_ID = 7, Emp_Name = "Rafa", Dept_ID = 4 });
            return emp;
        }
    }
}