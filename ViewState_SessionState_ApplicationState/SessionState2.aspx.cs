using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_SessionState_ApplicationState {
    public partial class SessionState2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                if (Session["Clicks"] == null) {
                    Session["Clicks"] = 0;
                }
                txtbox1.Text = Session["Clicks"].ToString();
            }
        }

        protected void button1_Click(object sender, EventArgs e) {
            int clickCount = (int)Session["Clicks"] + 1;
            txtbox1.Text = clickCount.ToString();
            Session["Clicks"] = clickCount;
        }
    }
}