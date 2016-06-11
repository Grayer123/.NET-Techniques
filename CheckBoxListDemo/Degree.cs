using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageLifeCycleDemo.CheckBoxListDemo {
    public class Degree {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Degree> getDegrees() {
            List<Degree> dgr = new List<Degree>();
            dgr.Add(new Degree { ID = 1, Name = "Bachelor" });
            dgr.Add(new Degree { ID = 2, Name = "Graduate" });
            dgr.Add(new Degree { ID = 3, Name = "Post Graudate" });
            dgr.Add(new Degree { ID = 4, Name = "Doctrate" });
            return dgr;
        }
    }
}


