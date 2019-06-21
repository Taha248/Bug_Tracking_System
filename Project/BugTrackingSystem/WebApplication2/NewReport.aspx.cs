using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class NewReport : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                return;
            }
        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                con.Open();
                String QueryCount = "Select count(*) From Bug_Report";
                MySqlCommand cmdCount = new MySqlCommand(QueryCount, con);
                int count = Convert.ToInt32(cmdCount.ExecuteScalar());
                count++;
                String P = Priority.SelectedItem.Text;
                String S = Severity.SelectedItem.Text;
                Log.Text = "" + P + " " + S;

                String QueryInsert = "INSERT INTO Bug_Report(BugId, Title, Detail, Severity, Priority, ProjectFile,AddedBy) VALUES('" + count + "', '" + title.Text + "', '" + Detail.Text + "', '" + S + "', '" + P + "', '" + Project.Text + "','" + Session["UserId"] + "'); INSERT INTO Status(BugId) VALUES('" + count + "');";
                MySqlCommand cmd = new MySqlCommand(QueryInsert, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("UserDashBoard.aspx");
            }
            catch (Exception ex)
            {
                Log.Text = ex.Message;
            }
        }
    }
}