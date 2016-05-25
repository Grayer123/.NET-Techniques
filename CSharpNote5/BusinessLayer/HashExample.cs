using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class HashExample {
        //there is no unsorted list 
        //list is generic type
        //the foreach output sequence is not the same with the insert sequence
        //probably would sort according the hash value of the key
        //sortedList would sort the record by the alphabet sequence of key
        Hashtable hashConsultants = new Hashtable();
        public void GetAllConsultants() {
            hashConsultants.Add("Pramod", new Consultant() { Id = 1, Name = "Pramod", Age = 25, EmailId = "Pramod@antra.net", Mobile = "9874563210" });
            hashConsultants.Add("Hongmin", new Consultant() { Id = 2, Name = "Hongmin", Age = 25, EmailId = "Hongmin@antra.net", Mobile = "9847563210" });
            hashConsultants.Add("Tejaswy", new Consultant() { Id = 3, Name = "Tejaswy", Age = 25, EmailId = "Tejaswy@antra.net", Mobile = "9784563210" });
            hashConsultants.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            if (!hashConsultants.ContainsKey("Shengheng")) {
                hashConsultants.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            }
            hashConsultants.Add("John", new Consultant() { Id = 5, Name = "John", Age = 25, EmailId = "John@antra.net", Mobile = "9874653201" });
            hashConsultants.Add("Yongdong", new Consultant() { Id = 6, Name = "Yongdong", Age = 25, EmailId = "Yongdong@antra.net", Mobile = "9874653201" });
        }

        public void PrintConsultants() {
            foreach (var item in hashConsultants.Values) {
                Consultant c = (Consultant)item;
                Console.WriteLine(c.Name);
            }
        }

        public Object GetConsultantValue(string key) {
            return hashConsultants[key];
        }
    }
}
