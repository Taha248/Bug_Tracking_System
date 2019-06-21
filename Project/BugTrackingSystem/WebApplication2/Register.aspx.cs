using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class Register : System.Web.UI.Page
    {
        Int32 Accountcount;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                con.Open();

                String CountQuery = "SELECT COUNT(*) FROM Account";
                MySqlCommand cmdCount = new MySqlCommand(CountQuery, con);

                Accountcount = Convert.ToInt32(cmdCount.ExecuteScalar());
                String QueryString = "INSERT INTO Account (AccountNo,Username,Password,Roles,DateOfCreation) Values('" + Accountcount + "','"
                + Password.Text + "','" + UserName.Text + "','user','" + DateTime.Now.ToString("MM-dd-yyyy h:mmtt") +
                "'); INSERT INTO User (Name,AccountNo,DOB,UserId,Email) Values('" + Name.Text + "','" + Accountcount + "','" + Dob.Text + "','USR-" + Accountcount + "','" + Email.Text + "')";

                MySqlCommand cmd = new MySqlCommand(QueryString, con);

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                lbl.Text = ""+ex.Message;
          //      Label7.Text = "" + ex.Message;
            }
        }
    }
}