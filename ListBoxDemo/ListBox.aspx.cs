using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleDemo.ListBoxDemo {
    public partial class ListBox : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void butSubmit_Click(object sender, EventArgs e) {
            foreach (ListItem li in lstBox.Items) {
                if (li.Selected) {
                    Response.Write("Text = " + li.Text + ", ");
                    Response.Write("Value = " + li.Value + ", ");
                    Response.Write("Index = " + lstBox.Items.IndexOf(li) + "<br />");
                }
            }
        }
    }
}