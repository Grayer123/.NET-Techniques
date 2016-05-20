using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote4.ListCollection {
    class ListDemo {
        //For the array, we have to give a specific size of the array
        //manually resize the array
        //For the list don't need to loop through the list
        /// <summary>
        /// generic
        /// </summary>
        public void ListExample() {
            List<string> student = new List<string>();
            student.Add("Pramod");
            student.Add("Hongmin");
            string str = "John";
            student.Add(str);

            student.Remove("Pramod");
            student.RemoveAt(0); //index
            //student.Find(); //LinQ; delegate
            //student.RemoveAll(); //predicate; delegate

            foreach(string s in student) {
                Console.WriteLine(s);
            }
        }
    }
}
