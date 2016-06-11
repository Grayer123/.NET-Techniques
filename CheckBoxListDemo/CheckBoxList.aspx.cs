using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleDemo.CheckBoxListDemo {
    public partial class CheckBoxList : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                ckBoxDegree.DataSource = Degree.getDegrees();
                ckBoxDegree.DataTextField = "Name";
                ckBoxDegree.DataValueField = "ID";
                
                ckBoxDegree.DataBind();
                //ckBoxDegree.Items[2].Selected = true; //can only set this property after DataBind()
                ckBoxDegree.SelectedValue = "2";
                //ckBoxDegree.SelectedIndex = 1;
                ckBoxDegree.Items[1].Enabled = false;
            }
        }

        protected void butSubmit_Click(object sender, EventArgs e) {
            foreach(ListItem li in ckBoxDegree.Items) {
                if (li.Selected) {
                    Response.Write("Text = " + li.Text + ", ");
                    Response.Write("Value = " + li.Value + ", ");
                    Response.Write("Index = " + ckBoxDegree.Items.IndexOf(li) + "<br />");
                }
            }
        }

        protected void butSelectAll_Click(object sender, EventArgs e) {
            foreach(ListItem li in ckBoxDegree.Items) {
                li.Selected = true;
            }
        }

        protected void butDeselectAll_Click(object sender, EventArgs e) {
            foreach(ListItem li in ckBoxDegree.Items) {
                li.Selected = false;
            }
        }
    }
}


