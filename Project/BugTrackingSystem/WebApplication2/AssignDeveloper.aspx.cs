using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class AssignDeveloper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bugId.Text = Session["BugId"].ToString();
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                con.Open();
                String Query = "SELECT NAME,Email FROM Account a,Developer d  WHERE Roles='developer' AND d.`AccountNo`=a.`AccountNo`;";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //     ListBox1.Items.Add

                    ListBox1.Items.Add(new ListItem("" + reader["Email"], "" + reader["Email"]));



                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection Devcon = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                Devcon.Open();
                String DevQuery = "SELECT DeveloperId FROM Developer WHERE Email='" + ListBox1.SelectedItem.Text + "';";
                MySqlCommand Devcmd = new MySqlCommand(DevQuery, Devcon);
                String DeveloperId = "";
                var reader = Devcmd.ExecuteReader();
                while (reader.Read())
                {
                    DeveloperId = reader["DeveloperId"].ToString();

                }
                Label4.Text = "" + Session["AssigningAdmin"].ToString();
                Devcon.Close();
                String Query = "INSERT INTO AssignDeveloper VALUES('" + Session["AssigningAdmin"].ToString() + "','" + DeveloperId + "','" + Int32.Parse(Session["BugId"].ToString()) + "') ; UPDATE Status SET Status='Assigned' WHERE BugId='" + Session["BugId"].ToString() + "';";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);

                cmd.ExecuteNonQuery();
                con.Close();

                Label4.Text = "Done" ;
                Response.Redirect("AdminDashBoard.aspx");
            }
            catch (Exception ex)
            {
                Label4.Text = "" + ex.Message;
            }
        }

    }
}