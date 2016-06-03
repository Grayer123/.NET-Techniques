using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerTransferDemo {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //method 1:
            //var previousFormCollection = Request.Form;
            //lbl1.Text = previousFormCollection["txtName"];
            //lbl2.Text = previousFormCollection["txtEmail"];

            //method 2:
            Page previousPage = Page.PreviousPage;
            if(previousPage != null) {
                lbl1.Text = ((TextBox)previousPage.FindControl("txtName")).Text;
                lbl2.Text = ((TextBox)previousPage.FindControl("txtEmail")).Text;
            }
        }
    }
}