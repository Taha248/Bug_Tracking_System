using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AddAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                con.Open();

                String CountQuery = "SELECT COUNT(*) FROM Account";
                MySqlCommand cmdCount = new MySqlCommand(CountQuery, con);

                int Accountcount = Convert.ToInt32(cmdCount.ExecuteScalar());
                Accountcount++;
                String QueryAddAccount = "INSERT INTO Account (Username,PASSWORD,Roles,AccountNo) VALUES('" + Username.Text + "','" + Password.Text + "','" + Role.SelectedItem.Text + "','" + Accountcount + "');";
                String QueryAddUser = "INSERT INTO User (NAME,AccountNo,DOB,UserId,Email) VALUES('" + Name.Text + "','" + Accountcount + "','" + Dob.Text + "','USR-" + Accountcount + "','" + Email.Text + "');";
                String QueryAddAdmin = "INSERT INTO Admin (NAME,AccountNo,DOB,AdminId,Email) VALUES('" + Name.Text + "','" + Accountcount + "','" + Dob.Text + "','ADM-" + Accountcount + "','" + Email.Text + "');";
                String QueryAddDeveloper = "INSERT INTO Developer (NAME,AccountNo,DOB,DeveloperId,Email) VALUES('" + Name.Text + "','" + Accountcount + "','" + Dob.Text + "','DEV-" + Accountcount + "','" + Email.Text + "');";
                String QueryAddTester = "INSERT INTO Tester (NAME,AccountNo,DOB,DeveloperId,Email) VALUES('" + Name.Text + "','" + Accountcount + "','" + Dob.Text + "','TST-" + Accountcount + "','" + Email.Text + "');";

                if (Role.SelectedItem.Text.Equals("user"))
                {
                    MySqlCommand cmd = new MySqlCommand(QueryAddAccount + "" + QueryAddUser, con);
                    cmd.ExecuteNonQuery();

                }
                else if (Role.SelectedItem.Text.Equals("admin"))
                {
                    MySqlCommand cmd = new MySqlCommand(QueryAddAccount + "" + QueryAddAdmin, con);
                    cmd.ExecuteNonQuery();
                }
                else if (Role.SelectedItem.Text.Equals("developer"))
                {
                    MySqlCommand cmd = new MySqlCommand(QueryAddAccount + "" + QueryAddDeveloper, con);
                    cmd.ExecuteNonQuery();
                }
                else if (Role.SelectedItem.Text.Equals("tester"))
                {
                    MySqlCommand cmd = new MySqlCommand(QueryAddAccount + "" + QueryAddTester, con);
                    cmd.ExecuteNonQuery();
                    Label8.Text = "Done";
                }
                //     Response.Redirect("AdminDashBoard.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Label8.Text = ex.Message + " ";
            }
        }
    }
}