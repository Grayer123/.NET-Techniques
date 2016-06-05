using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLab4.PropertyDemo;

namespace CSharpLab4.ExtensionMethodsDemo {
    public delegate bool KeyValueFilter<K, V>(K key, V value);
    public static class Extensions {
        /// <summary>
        /// With C# 3.0, you can now define an extension method that can be invoked using instance method syntax. 
        /// An extension method is declared by specifying the keyword this 
        /// as a modifier on the first parameter of the method.
        /// </summary>
        /// <param name="customer1"></param>
        /// <param name="customer2"></param>
        /// <returns></returns>
        public static bool Compare(this Customer customer1, Customer customer2) {
            if (customer1.CustomerID == customer2.CustomerID &&
                    customer1.Name == customer2.Name &&
                    customer1.City == customer2.City) {
                return true;
            }
            return false;
        }

        public static List<T> Append<T>(this List<T> a, List<T> b) {
            //public List(IEnumerable<T> collection);
            var newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }

        public static List<K> FilterBy<K,V>(this Dictionary<K, V> items, KeyValueFilter<K,V> filter) {
            var result = new List<K>();
            foreach(KeyValuePair<K,V> elem in items) {
                if(filter(elem.Key, elem.Value)) {
                    result.Add(elem.Key);
                }               
            }
            return result;
        }
    }
}
