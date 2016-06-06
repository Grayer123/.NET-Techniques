using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageLifeCycleDemo.tables {
    public class Department {
        public int Dept_ID { get; set; }
        public string Dept_Name { get; set; }

        public static List<Department> popDeptData() {
            List<Department> dept = new List<Department>();
            dept.Add(new Department { Dept_ID = 1, Dept_Name = "Computer Engineer" });
            dept.Add(new Department { Dept_ID = 2, Dept_Name = "Data Scientist" });
            dept.Add(new Department { Dept_ID = 3, Dept_Name = "UI Development" });
            dept.Add(new Department { Dept_ID = 4, Dept_Name = "Test Team" });
            return dept;
        }
    }
}


