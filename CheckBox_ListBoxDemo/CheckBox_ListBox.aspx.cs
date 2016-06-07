using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleDemo.CheckBox_ListBoxDemo {
    public partial class CheckBox_ListBox : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ckBoxList_SelectedIndexChanged(object sender, EventArgs e) {
            lstBox.Items.Clear(); //Clear() first, otherwise could add the duplicated records
            foreach(ListItem li in ckBoxList.Items) {
                if (li.Selected) {
                    //lstBox.Items.Add(li); //at this time li has been selected, Add() has the overloaded Add(string) version
                    lstBox.Items.Add(li.Text);
                }
            }

            if(ckBoxList.SelectedIndex == -1) { //no items has been selected
                lblSummary.ForeColor = System.Drawing.Color.Red;
            }
            lblSummary.Text = lstBox.Items.Count.ToString() + " Item(s) Selected";
        }
    }
}