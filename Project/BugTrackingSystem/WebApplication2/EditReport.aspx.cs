using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class EditReport : System.Web.UI.Page
    {

        String BugId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


          //      Label7.Text = "Executed";

                if (Session["BugId"] != null)
                {
            //        Label7.Text = "Executed IF";
                    BugId = Session["BugId"].ToString();

              //      Label7.Text = "Executed BugId" + BugId;
                    try
                    {

                        //   Label7.Text = "Executed try";
                        BugId = Session["BugId"].ToString();

                        //  Label7.Text = "BugId:"+BugId;
                        String QueryString = "SELECT Title,Detail,Severity,Priority,ProjectFile FROM Bug_Report WHERE BugId='" + BugId + "'";


                        MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
                        MySqlCommand cmd = new MySqlCommand(QueryString, con);

                        //     Label7.Text = "Executed CMD";
                        con.Open();

                        //   Label7.Text = "Executed Open";
                        var Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {
                            title.Text = Reader["Title"].ToString();
                            Detail.Text = Reader["Detail"].ToString();
                            if (Reader["Priority"].ToString().Equals("Critical")) { Priority.SelectedIndex = 0; }
                            else if (Reader["Priority"].ToString().Equals("High")) { Priority.SelectedIndex = 1; }
                            else if (Reader["Priority"].ToString().Equals("Medium")) { Priority.SelectedIndex = 2; }
                            else if (Reader["Priority"].ToString().Equals("Low")) { Priority.SelectedIndex = 3; }

                            if (Reader["Severity"].ToString().Equals("Blocker")) { Severity.SelectedIndex = 0; }
                            else if (Reader["Severity"].ToString().Equals("Major")) { Severity.SelectedIndex = 1; }
                            else if (Reader["Severity"].ToString().Equals("Moderate")) { Severity.SelectedIndex = 2; }
                            else if (Reader["Severity"].ToString().Equals("Low")) { Severity.SelectedIndex = 3; }
                            Project.Text = Reader["ProjectFile"].ToString();
                        }


                        //    txtId = Reader["Id"].ToString(); 
                        //  Label7.Text = ""+lines;
                        con.Close();
                    }
                    catch (Exception e2)
                    {
            //            Label7.Text = e2.Message;
                    }

                }
                else
                {
           //         Label7.Text = "Null";
                }
            }
        }
        protected override void OnPreLoad(EventArgs e)
        {

            base.OnPreInit(e);
        }
        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                String UpdateQuery = "UPDATE Bug_Report	SET Title = '" + title.Text + "', Detail = '" + Detail.Text + "', Severity = '" + Severity.SelectedItem.Text + "', Priority = '" + Priority.SelectedItem.Text + "', ProjectFile = '" + Project.Text + "'WHERE BugId='" + Session["BugId"] + "'";
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
                MySqlCommand cmd = new MySqlCommand(UpdateQuery, con);

                con.Open();
                cmd.ExecuteNonQuery();

         //       Label7.Text = "Done";
                if (Session["Login"].ToString().Equals("AdminLoggedIn"))
                {

                    Response.Redirect("AdminDashBoard.aspx");
                }
                else if (Session["Login"].ToString().Equals("UserLoggedIn"))
                {

                    Response.Redirect("UserDashBoard.aspx");
                }
                con.Close();

            }
            catch (Exception e1)
            {
       //         Label7.Text = e1.Message;
            }
        }
    }
}