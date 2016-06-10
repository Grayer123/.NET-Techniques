using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageLifeCycleDemo.tables;


namespace PageLifeCycleDemo {
    public partial class WebForm3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                dropListDepts.DataSource = Department.popDeptData();
                dropListDepts.DataTextField = "Dept_Name";
                dropListDepts.DataValueField = "Dept_ID";
                dropListDepts.DataBind();
                //add the default record to the Department table
                ListItem liDept = new ListItem("Select Dept.", "0");
                dropListDepts.Items.Insert(0, liDept); //insert it to the beginning 


                ListItem liEmp = new ListItem("Select Employee.", "0");
                dropListEmpts.Items.Insert(0, liEmp);
                dropListEmpts.Enabled = false;
            }
            
        }

        protected void dropsdwnDepts_SelectedIndexChanged(object sender, EventArgs e) {
            if(dropListDepts.SelectedIndex != 0) {
                dropListEmpts.Enabled = true;
                int val = Convert.ToInt32(dropListDepts.SelectedValue);

                dropListEmpts.DataSource = Employee.popEmpData().FindAll(x => x.Dept_ID == val);
                dropListEmpts.DataTextField = "Emp_Name";
                dropListEmpts.DataValueField = "Emp_ID";
                dropListEmpts.DataBind();
                ListItem liEmp = new ListItem("Select Employee.", "0");
                dropListEmpts.Items.Insert(0, liEmp);
            }
            else {
                dropListEmpts.SelectedIndex = 0;
                dropListEmpts.Enabled = false;
            }
        }
    }
}




