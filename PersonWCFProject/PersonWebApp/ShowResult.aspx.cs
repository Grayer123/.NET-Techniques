using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonEntities;


namespace PersonWebApp {
    public partial class ShowResult : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void butSubmit_Click(object sender, EventArgs e) {

            int age = Convert.ToInt32(txtBoxInput.Text);
            PersonServ.PersonServiceClient client = new PersonServ.PersonServiceClient();
            PersonLongEntity[] per = client.GetPersonLongServ(age);
            List<PersonLongEntity> lst = per.ToList<PersonLongEntity>();

            //PersonShort.SaveToPersonShort(PersonShort.GetPersonShort(age));
            client.SaveToPersonShortServ(client.GetPersonShortServ(age));
            lblSp.Text = "The SP output parameter @curDate = " + client.ShowDates();
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }
    }
}