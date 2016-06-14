using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PersonEntities;
using PersonLibrary;

namespace PersonWCF_Project {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService {
        //public static string Dates { get; set; }
        public List<PersonLongEntity> GetPersonLongServ(int age) {
            return PersonLong.GetPersonLong(age);
        }

        public List<PersonShortEntity> GetPersonShortServ(int age) {
            return PersonShort.GetPersonShort(age);
        }

        public void SaveToPersonShortServ(List<PersonShortEntity> lst) {
            PersonShort.SaveToPersonShort(lst);
        }


        public string ShowDates() {
            return PersonLongEntity.Dates;
        }

    }
}
