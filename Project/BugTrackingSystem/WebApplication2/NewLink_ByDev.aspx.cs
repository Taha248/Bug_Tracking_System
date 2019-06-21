using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication8
{
    public partial class NewLink_ByDev : System.Web.UI.Page
    {
        String h;
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");

            MySqlCommand com1 = new MySqlCommand("select * from Bug_Report where BugId = '" + Session["BugIdReference"] + "'", con3);
            con3.Open();
            var reader = com1.ExecuteReader();

            /*   while (reader.Read())
               {
                   h = reader["ProjectFile"].ToString();
               }
               con3.Close();
               TextBox1.Text = h;
               */


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            con3.Open();
            MySqlCommand com1 = new MySqlCommand("UPDATE AssignTester SET ProjectFiles = '" + TextBox1.Text + "' WHERE BugId = '" + Session["BugIdReference"].ToString() + "'", con3);
            com1.ExecuteNonQuery();
            con3.Close();

            Response.Redirect("Developer_Panel.aspx");
        }
    }
}