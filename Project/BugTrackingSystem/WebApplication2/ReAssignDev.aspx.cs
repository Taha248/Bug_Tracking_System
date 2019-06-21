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
    public partial class ReAssignDev : System.Web.UI.Page
    {
        String b;
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");

            MySqlCommand com2 = new MySqlCommand("select Name,AccountNo from Developer ", con);
            con.Open();
            var reader = com2.ExecuteReader();

            GridView3.DataSource = reader;
            GridView3.DataBind();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Session["ReAssignDeveloper"] = GridView3.SelectedRow.Cells[1].Text;

            //  Label1.Text = GridView3.SelectedRow.Cells[1].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            con2.Open();
            MySqlCommand com1 = new MySqlCommand("select * from Account where UserName='" + Session["AccountNoDeveloper"].ToString() + "'", con2);
            var reader = com1.ExecuteReader();
            while (reader.Read())
            {
                b = reader["AccountNo"].ToString();
            }
            MySqlCommand com2 = new MySqlCommand("insert into Reassigned values ('" + "Dev-" + b + "','" + "Dev-" + Session["ReAssignDeveloper"].ToString() + "')", con);
            con.Open();
            com2.ExecuteReader();
            Response.Redirect("Developer_Panel.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Developer_Panel.aspx");
        }
    }
}