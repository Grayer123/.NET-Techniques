using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerTransferDemo {
    public partial class ServerTransfer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void butTranfer_Click(object sender, EventArgs e) {
            Server.Transfer("~/WebForm2.aspx");
        }
    }
}