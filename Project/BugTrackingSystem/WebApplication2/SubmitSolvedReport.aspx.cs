using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class SubmitSolvedReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String str = Session["BugId"].ToString();
            BugId.Text = str;
            BugId.Enabled = false;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        try {

            String developedby="";
            String query1 = "SELECT AssignedBy  FROM AssignTester WHERE BugId = '" + BugId.Text + "'";
      MySqlConnection con1 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            MySqlCommand cmd1 = new MySqlCommand(query1,con1);
             con1.Open();
            var reader = cmd1.ExecuteReader();
            while(reader.Read()) {
                developedby = reader["AssignedBy"].ToString();
            }
            String query2 = "INSERT INTO Solved_Reports  (BugId,Solved_By,Tested_By,Project_Files,Comments) VALUES  ('" + BugId.Text + "', '"+developedby+"', '"+Session["testerid"].ToString()+"', '"+ProjectFiles.Text+"', '"+Comment.Text+ "');UPDATE Bug_Report b,STATUS s SET s.`Status`='Closed' WHERE b.`BugId`=s.`BugId` AND b.`BugId`='"+BugId.Text+"';";

            con1.Close();
            con2.Open();
            MySqlCommand cmd2 = new MySqlCommand(query2,con2);
            cmd2.ExecuteNonQuery();
            con2.Close();
               // Label5.Text = "Done";
            }
            catch(Exception ex) {
            //    Label5.Text = ex.Message;
            }

        }
    }
}