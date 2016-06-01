using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringDemo {
    public partial class WebForm2 : System.Web.UI.Page {
        /// <summary>
        /// webform1 Url: http://localhost:57150/WebForm1.aspx
        /// ordinary: http://localhost:57150/WebForm2.aspx?UserName=Ran&UserEmail=grayer123@163.com
        /// method1: http://localhost:57150/WebForm2.aspx?UserName=Ran%20&%20Hang&UserEmail=grayer123@163.com
        /// method2: http://localhost:57150/WebForm2.aspx?UserName=Ran+%26+Hang&UserEmail=grayer123%40163.com
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e) {
            /*
             * string Request.QueryString[int index];
             * string Request.QueryString[string name];
             */
             //using string name
            txtName.Text = Request.QueryString["UserName"];
            txtEmail.Text = Request.QueryString["UserEmail"];

            //using int index
            //txtName.Text = Request.QueryString[0];
            //txtEmail.Text = Request.QueryString[1];
        }
    }
}