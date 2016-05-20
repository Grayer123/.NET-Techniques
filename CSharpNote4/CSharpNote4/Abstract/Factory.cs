using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.Abstract {
    /// <summary>
    /// Factory, RIP
    /// </summary>
    class Factory {
        public static BaseCustomer GetCustomer(string customerType) {
            Dictionary<string, BaseCustomer> obj = new Dictionary<string, BaseCustomer>();
            obj.Add("customer", new Customer());
            obj.Add("lead", new Lead());
            return obj[customerType];
        }
    }
}
