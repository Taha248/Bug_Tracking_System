using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class ReassignDeveloper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BugId.Text = Session["BugId"].ToString();
            BugId.Enabled = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        try { 
            String AssignedById="";   
         String QueryAssignedBy = "SELECT AssignedBy FROM AssignTester WHERE AssignedTo = '" + Session["testerid"].ToString()+ "' AND BugId = '" + BugId.Text + "'; ";
            MySqlConnection connect = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem");
            MySqlConnection connect1 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem");
            MySqlCommand cmd = new MySqlCommand(QueryAssignedBy, connect);
            connect.Open();
            var reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                AssignedById = reader["AssignedBy"].ToString();
            }
            connect.Close();

            String Query = "INSERT INTO ReassignDeveloper (AssignedBy,AssignTo,BugId,COMMENT,ProjectFiles) VALUES ('"+ AssignedById + "','"+ Session["testerid"].ToString() + "','"+BugId.Text+"','"+Comment.Text+"','"+ProjectFiles.Text+"');";
            connect1.Open();
            MySqlCommand cmd1 = new MySqlCommand(Query, connect1);
            cmd1.ExecuteNonQuery();
            connect1.Close();

                Label6.Text = "Done";
            }
            catch(Exception ex)
            {
                Label6.Text = "" + ex.Message;
            }
        }
    }
}