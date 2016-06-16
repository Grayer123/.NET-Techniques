using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient1 {
    public partial class Client1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CompanyService.CompanyPublicServiceClient client1 = 
                new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Response.Write(client1.GetPublicInfo() + "<br />");

            CompanyService.CompanyConfidentialServiceClient client2 =
                new CompanyService.CompanyConfidentialServiceClient("WSHttpBinding_ICompanyConfidentialService");
            Response.Write(client2.GetConfidentialInfo());
        }
    }
}