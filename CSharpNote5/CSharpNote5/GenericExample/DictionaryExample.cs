using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

//dicionary is generic type, can take any type of key and value
//output the original sequence(that is: the insert sequence)
//the duplicate key cannot be allowed
//Hashtable in C# is not generic type, and the data stored in Hashtable would be sorted according to the HashCode
namespace CSharpNote5.GenericExample {
    class DictionaryExample {
        Dictionary<string, Consultant> dict = new Dictionary<string, Consultant>();
        public void GetAllConsultants() {


            dict.Add("Pramod", new Consultant() { Id = 1, Name = "Pramod", Age = 25, EmailId = "Pramod@antra.net", Mobile = "9874563210" });
            dict.Add("Hongmin", new Consultant() { Id = 2, Name = "Hongmin", Age = 25, EmailId = "Hongmin@antra.net", Mobile = "9847563210" });
            dict.Add("Tejaswy", new Consultant() { Id = 3, Name = "Tejaswy", Age = 25, EmailId = "Tejaswy@antra.net", Mobile = "9784563210" });
            dict.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            if (!dict.ContainsKey("Shengheng")) {
                dict.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            }
            dict.Add("John", new Consultant() { Id = 5, Name = "John", Age = 25, EmailId = "John@antra.net", Mobile = "9874653201" });
            dict.Add("Yongdong", new Consultant() { Id = 6, Name = "Yongdong", Age = 25, EmailId = "Yongdong@antra.net", Mobile = "9874653201" });
            //dict.Add("John", new Consultant());
        }

        public void PrintConsultants() {
            foreach (var item in dict) {
                Console.WriteLine(item.Value.Name);
            }
        }
    }
}
