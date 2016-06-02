using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_SessionState_ApplicationState {
    public partial class ApplicationState1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                if (Application["Clicks"] == null) {
                    Application["Clicks"] = 0;
                }
                txtbox1.Text = Application["Clicks"].ToString();
            }
        }

        protected void button1_Click(object sender, EventArgs e) {
            int clickCount = (int)Application["Clicks"] + 1;
            txtbox1.Text = clickCount.ToString();
            Application["Clicks"] = clickCount;
        }
    }
}