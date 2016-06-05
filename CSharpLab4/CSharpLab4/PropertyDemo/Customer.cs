using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab4.PropertyDemo {
    public class Customer {
        //a read-only CustomerID
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int id) {
            CustomerID = id;
        }

        //override the ToString() method to easily output Customer object
        public override string ToString() {
            return Name + "\t" + City + "\t" + CustomerID;
        }

    }
}
