using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MultiWCFService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService {
        public string GetConfidentialInfo() {
            return "This is confidential info and only available over TCP behind the company FireWall";
        }

        public string GetPublicInfo() {
            return "This is public info and available over HTTP to all general public outside the FireWall";
        }
    }
}
