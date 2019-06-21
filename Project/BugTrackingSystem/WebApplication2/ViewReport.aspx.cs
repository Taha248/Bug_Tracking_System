using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class ViewReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlCommand command;

           String tst =Session["Login"].ToString();
            
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            if (!tst.Equals("TesterLoggedIn"))
            {
              

                command = new MySqlCommand("Select * from Bug_Report Where BugId='" + Session["BugId"].ToString() + "'", con);
            }
            else
            {
                String tsterId = Session["testerid"].ToString();
                command = new MySqlCommand("SELECT b.`BugId`,b.`Detail`,b.`Title`,b.`Severity`,b.`Priority`,d.`ProjectFiles` FROM Bug_Report b,AssignTester d WHERE b.`BugId`=d.`BugId` AND b.BugId='" + Session["BugId"].ToString() + "'", con);

            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DetailsView1.DataSource = dt;

            DetailsView1.DataBind();
        }
    }
}