using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringDemo {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void butTranfer_Click(object sender, EventArgs e) {
            // ~ means the root directory of application project
            // ? indicates the beginning of query string
            // UserName is the name of first query string, the value comes from txtName.Text
            // & indicates another beginning of query string
            //could use this way to append as many query strings as wanted, but there is limit of the length of query string
            //Response.Redirect("~/WebForm2.aspx?UserName=" + txtName.Text + "&UserEmail=" + txtEmail.Text);

            //using Server.UrlEncode to encode &(ampersand)
            Response.Redirect("~/WebForm2.aspx?UserName=" + Server.UrlEncode(txtName.Text)
                              + "&UserEmail=" + Server.UrlEncode(txtEmail.Text));

            //using String.Replace() method to replace &(ampersand) with %26
            //Response.Redirect("~/WebForm2.aspx?UserName=" + txtName.Text.Replace("&", "%26")
            //                  + "&UserEmail=" + txtEmail.Text.Replace("&", "%26"));
        }
    }
}