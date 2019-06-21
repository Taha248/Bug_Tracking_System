using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Password.Enabled = false;
            Username.Enabled = false;
            Role.Enabled = false;
            if (!IsPostBack)
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
                String QueryString = "";
                if (Session["Login"].Equals("UserLoggedIn"))
                    QueryString = "SELECT  NAME,Dob,Username,Email,PASSWORD,Roles  FROM User u , Account a WHERE u.`AccountNo`=a.`AccountNo` && u.`UserId`='" + Session["UserId"] + "'";
                else if (Session["Login"].Equals("AdminLoggedIn"))
                    QueryString = "SELECT  NAME,Dob,Username,Email,PASSWORD,Roles  FROM Admin u , Account a WHERE u.`AccountNo`=a.`AccountNo` && u.`AdminId`='" + Session["AdminId"] + "'";
                else if (Session["Login"].Equals("DeveloperLoggedIn"))
                    QueryString = "SELECT  NAME,Dob,Username,Email,PASSWORD,Roles  FROM Developer u , Account a WHERE u.`AccountNo`=a.`AccountNo` && u.`DeveloperId`='" + Session["DeveloperId"] + "'";
                else if (Session["Login"].Equals("TesterLoggedIn"))
                    QueryString = "SELECT  NAME,Dob,Username,Email,PASSWORD,Roles  FROM Tester u , Account a WHERE u.`AccountNo`=a.`AccountNo` && u.`TesterId`='" + Session["TesterId"] + "'";




                con.Open();
                MySqlCommand cmd = new MySqlCommand(QueryString, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Name.Text = Reader["Name"].ToString();
                    DOB.Text = Reader["DOB"].ToString();
                    Username.Text = Reader["Username"].ToString();
                    Email.Text = Reader["Email"].ToString();
                    Password.Text = Reader["Password"].ToString();
                    Role.Text = Reader["Roles"].ToString();
                }

                con.Close();
            }
            else
            {
                return;
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
                String QueryString = "";

                if (Password.Enabled)
                {
                    if (Session["Login"].Equals("UserLoggedIn"))
                    {
                        QueryString = "UPDATE User   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE UserId = '" + Session["UserId"] + "'; UPDATE Account  SET PASSWORD = '" + Password.Text + "' WHERE Username = '" + Username.Text + "'; ";
                    }
                    else if (Session["Login"].Equals("AdminLoggedIn"))
                    {
                        QueryString = "UPDATE Admin   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE UserId = '" + Session["AdminId"] + "'; UPDATE Account  SET PASSWORD = '" + Password.Text + "' WHERE Username = '" + Username.Text + "'; ";

                    }
                    else if (Session["Login"].Equals("DeveloperLoggedIn"))
                    {
                        QueryString = "UPDATE Developer   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE UserId = '" + Session["DeveloperId"] + "'; UPDATE Account  SET PASSWORD = '" + Password.Text + "' WHERE Username = '" + Username.Text + "'; ";
                    }

                    else if (Session["Login"].Equals("TesterLoggedIn"))
                    {
                        QueryString = "UPDATE Tester   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE UserId = '" + Session["TesterId"] + "'; UPDATE Account  SET PASSWORD = '" + Password.Text + "' WHERE Username = '" + Username.Text + "'; ";
                    }



                }
                else
                {
                    if (Session["Login"].Equals("UserLoggedIn"))
                    {
                        QueryString = "UPDATE User   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE UserId = '" + Session["UserId"] + "'; ";

                        MySqlCommand cmd = new MySqlCommand(QueryString, con);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("UserReportDashBoard.aspx");
                    }
                    else if (Session["Login"].Equals("AdminLoggedIn"))
                    {
                        QueryString = "UPDATE Admin   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE AdminId = '" + Session["AdminId"] + "'; ";

                        MySqlCommand cmd = new MySqlCommand(QueryString, con);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("AdminDashBoard.aspx");
                    }
                    else if (Session["Login"].Equals("DeveloperLoggedIn"))
                    {
                        QueryString = "UPDATE Developer   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE DeveloperId = '" + Session["DeveloperId"] + "'; ";

                        MySqlCommand cmd = new MySqlCommand(QueryString, con);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("DeveloperDashBoard.aspx");
                    }
                    else if (Session["Login"].Equals("TesterLoggedIn"))
                    {
                        QueryString = "UPDATE Tester   SET Name = '" + Name.Text + "', Dob = '" + DOB.Text + "', Email = '" + Email.Text + "' WHERE TesterId = '" + Session["TesterId"] + "'; ";

                        MySqlCommand cmd = new MySqlCommand(QueryString, con);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("TesterDashBoard.aspx");
                    }



                }

            }

            catch (Exception ex)
            {
            }

        }
        protected void Change_Click(object sender, EventArgs e)
        {

            Password.Enabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("ViewProfile.aspx");
        }
    }
}