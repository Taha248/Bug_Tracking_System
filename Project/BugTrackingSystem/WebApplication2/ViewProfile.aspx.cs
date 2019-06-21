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
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            MySqlCommand command = new MySqlCommand("SELECT * from User  WHERE  AccountNo = '"+ Session["DevAccountNo"] + "'", con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DetailsView1.DataSource = dt;

            DetailsView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["Login"].ToString().Equals("DeveloperLoggedIn"))
            Response.Redirect("Developer_Panel.aspx");
            else if (Session["Login"].ToString().Equals("TesterLoggedIn"))
            {
                Response.Redirect("TesterDashBoard.aspx");
            }
            else if (Session["Login"].ToString().Equals("AdminLoggedIn"))
            {
                Response.Redirect("AdminDashBoard.aspx");
            }
            else if (Session["Login"].ToString().Equals("UserLoggedIn"))
            {
                Response.Redirect("UserDashBoard.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}