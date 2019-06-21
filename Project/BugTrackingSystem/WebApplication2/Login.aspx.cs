using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class Login : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["lang"] = DropDownList15.SelectedItem.Value;
            if (!IsPostBack)
{
                


                DropDownList2.Items[0].Value = "1";
               
                DropDownList2.Items[1].Value = "0";
                //Your ddl initialization here

                Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");
                //Get the required section of the web.config file by using configuration object.
                PagesSection pages = (PagesSection)config.GetSection("system.web/pages");
                if (Session["selectDrpDwn2"] != null) {
                    DropDownList2.SelectedIndex = (int)(Session["selectDrpDwn2"]);
                }
                // Label5.Text = Session["selectDrpDwn"].ToString();
                String p = pages.Theme.ToString();
                if (p == "Theme2")
                {
                    DropDownList2.SelectedIndex = 1;
                }
                else if (p=="Theme1")
                {
                    DropDownList2.SelectedIndex = 0;
                }
                else
                {
                    DropDownList2.SelectedIndex = 2;
                }
            }
            
        }

        protected void RefreshPage(object o, EventArgs e)
        {
            Session["dd2"] = DropDownList2.SelectedValue;
            DropDownList2.SelectedIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByValue(Convert.ToString(Session["dd2"])));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dx = DropDownList2.SelectedIndex;
            Session["selectDrpDwn"] = "";
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");
            //Get the required section of the web.config file by using configuration object.
            PagesSection pages = (PagesSection)config.GetSection("system.web/pages");
            //Update the new values.
            pages.Theme = DropDownList2.SelectedItem.Text.ToString();
            //Session["selectDrpDwn2"] = dx.ToString();
            //Session["selectDrpDwn"] = DropDownList2.SelectedItem.Text;

            if (!pages.SectionInformation.IsLocked)
            {
               
                config.Save();
                Response.Redirect("Login.aspx");
               
            }
            else
            {
                Response.Write("<script>alert('Could not save configuration')</script>");
            }
        }


      

        protected void Button1_Click(object sender, EventArgs e)
        {
            String User = userName.Text;
            String Pass = password.Text;
            String QueryString;
            if (Select.SelectedItem.Text.Equals("User"))
            {
                QueryString = "    SELECT a.*,u.* FROM Account a,User u WHERE u.`AccountNo`=a.`AccountNo`;";
                MySqlConnection con = createConnection();
                UserLogin(con, QueryString);
            }
            else if (Select.SelectedItem.Text.Equals("Admin"))
            {
                QueryString = "SELECT a.*,ad.* FROM Account a,Admin ad WHERE ad.`AccountNo`=a.`AccountNo`;";
                MySqlConnection con = createConnection();
                adminLogin(con, QueryString);

            }
            else if (Select.SelectedItem.Text.Equals("Developer"))
            {
                QueryString = "SELECT a.*,d.* FROM Account a, Developer d WHERE d.`AccountNo`= a.`AccountNo`; ";
                MySqlConnection con = createConnection();
                DeveloperLogin(con, QueryString);
            }
            else if (Select.SelectedItem.Text.Equals("Tester"))
            {
                QueryString = "SELECT a.*,t.* FROM Account a,Tester t WHERE t.`AccountNo`=a.`AccountNo`;";
                MySqlConnection con = createConnection();
                TesterLogin(con, QueryString);
            }




        }

        private void TesterLogin(MySqlConnection con, string queryString)
        {
            String TesterId = "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(queryString, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (userName.Text.Equals("") || password.Text.Equals(""))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "User/Password Field Empty", true);

                    }
                   else if (reader["UserName"].ToString().Equals(userName.Text) && reader["Password"].ToString().Equals(password.Text) && reader["Roles"].ToString().Equals("tester"))
                    {
                      //  Session["testerURL"] = 
                        Session["User_Name"] = reader["UserName"].ToString();
                        Session["testerid"] = reader["TesterId"].ToString();
                        TesterId = reader["TesterId"].ToString();
                        Label3.Text = "SuccessFully LoggedIn!";
                        output.Text = "true";
                        Session["Login"] = "TesterLoggedIn";
                        Response.Redirect("TesterDashBoard.aspx");
                        break;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Incorrect User/Password')", true);

                        Label3.Text = "Tester Failed";
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Label3.Text = "" + ex.Message;
            }



        }
        private void DeveloperLogin(MySqlConnection con, string queryString)
        {
            String DeveloperId = "";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(queryString, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (userName.Text.Equals("") || password.Text.Equals(""))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "User/Password Field Empty", true);

                    }
                    else if (reader["UserName"].ToString().Equals(userName.Text) && reader["Password"].ToString().Equals(password.Text) && reader["Roles"].ToString().Equals("developer"))
                    {
                        Session["AccountNoDeveloper"] = reader["UserName"];
                        Session["DevAccountNo"] = reader["AccountNo"];
                        Session["DeveloperId"] = reader["DeveloperId"].ToString();
                        DeveloperId = reader["DeveloperId"].ToString();
                        Label3.Text = "SuccessFully LoggedIn!";
                        Session["Login"] = "DeveloperLoggedIn";
                        Response.Redirect("Developer_Panel.aspx");
                        output.Text = "true";

                        break;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Incorrect User/Password')", true);
                        Label3.Text = "Developer Failed";
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Label3.Text = "" + ex.Message;
            }



        }
        private void adminLogin(MySqlConnection con, string queryString)
        {
            String AdminId = "a";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(queryString, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (userName.Text.Equals("") || password.Text.Equals(""))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "User/Password Field Empty", true);

                    }
                    else if (reader["UserName"].ToString().Equals(userName.Text) && reader["Password"].ToString().Equals(password.Text) && reader["Roles"].ToString().Equals("admin"))
                    {
                        Session["AdminId"] = reader["AdminId"].ToString();
                        AdminId = reader["AdminId"].ToString();
                        Label3.Text = "SuccessFully LoggedIn!";
                        Session["Login"] = "AdminLoggedIn";

                        Response.Redirect("AdminDashBoard.aspx");
                        Label3.Text = "" + Session["AdminId"];
                        
                        break;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Incorrect User/Password')", true);
                        Label3.Text = "Admin Failed";
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Label3.Text = "" + ex.Message;
            }



        }

        private void UserLogin(MySqlConnection con, String QueryString)
        {
            String userId = "";
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand(QueryString, con);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (userName.Text.Equals("") || password.Text.Equals(""))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "User/Password Field Empty", true);

                    }
                    else if (reader["UserName"].ToString().Equals(userName.Text) && reader["Password"].ToString().Equals(password.Text) && reader["Roles"].ToString().Equals("user"))
                    {
                        Session["UserId"] = reader["UserId"].ToString();
                        userId = reader["UserId"].ToString();
                        Label3.Text = "SuccessFully LoggedIn!";
                        output.Text = "true";
                        Session["Login"] = "UserLoggedIn";
                        Response.Redirect("UserDashBoard.aspx");

                        break;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Incorrect User/Password')", true);
                        // Label3.Text = "User Failed";
                    }
                }
                con.Close();

            }
            catch (Exception ex)
            {
                Label3.Text = "" + ex.Message;
            }

        }

        private MySqlConnection createConnection()
        {
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            return con;
        }

        private String getLoggedInUserId(MySqlConnection con, String AccountId)
        {
            String UserId = "";
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM User where AccountId='" + AccountId + "'", con);
            var Reader = cmd.ExecuteReader();
            while (Reader.Read())
                UserId = Reader["UserId"].ToString();

            return UserId;
        }


        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}