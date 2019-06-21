using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class SubmitSolveReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String str = Session["BugId"].ToString();
            BugId.Text = str;
            BugId.Enabled = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String query = "";
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            MySqlCommand cmd = new MySqlCommand();
               
                    }
    }
}