using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonLibrary;
using System.Configuration;
using System.Data.SqlClient;

namespace Person_ADO {
    public partial class Show : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {                       
        }

        protected void butSubmit_Click(object sender, EventArgs e) {
            int age = Convert.ToInt32(txtBoxInput.Text);           
            PersonShort.SaveToPersonShort(PersonShort.GetPersonShort(age));
            lblSp.Text = "The SP output parameter @curDate = " + PersonLong.Dates;

            string connectString = ConfigurationManager.ConnectionStrings["DBCS2"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectString)) {               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Person_Short";
                try {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                    reader.Close();
                }                    
                catch (Exception ex) {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}