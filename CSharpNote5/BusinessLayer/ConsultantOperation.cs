using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    public class ConsultantOperation {
        //the key must be unique, otherwise pops an error
        SortedList lstConsultants = new SortedList();
        //SortedList<string, object> sss = new SortedList<string, object>();  //generic collection
        public void GetAllConsultants() {
            lstConsultants.Add("Pramod", new Consultant() { Id = 1, Name = "Pramod", Age = 25, EmailId = "Pramod@antra.net", Mobile = "9874563210" });
            lstConsultants.Add("Hongmin", new Consultant() { Id = 2, Name = "Hongmin", Age = 18, EmailId = "Hongmin@antra.net", Mobile = "9847563210" });
            lstConsultants.Add("Tejaswy", new Consultant() { Id = 3, Name = "Tejaswy", Age = 25, EmailId = "Tejaswy@antra.net", Mobile = "9784563210" });
            lstConsultants.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            if (!lstConsultants.ContainsKey("Shengheng")) {
                lstConsultants.Add("Shengheng", new Consultant() { Id = 4, Name = "Shengheng", Age = 25, EmailId = "Shengheng@antra.net", Mobile = "9874653210" });
            }
            lstConsultants.Add("John", new Consultant() { Id = 5, Name = "John", Age = 25, EmailId = "John@antra.net", Mobile = "9874653201" });
            lstConsultants.Add("Yongdong", new Consultant() { Id = 6, Name = "Yongdong", Age = 25, EmailId = "Yongdong@antra.net", Mobile = "9874653201" });
        }
        public void PrintConsultants() {
            foreach(var item in lstConsultants.Values) {
                Consultant c = (Consultant)item; //return the object so we need to force convert
                Console.WriteLine(c.Name);
            }
        }
        /// <summary>
        /// NOTE: return type is Object
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Object GetConsultantValue(string key) {
            return lstConsultants[key];
        }
    }
}
