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
    public partial class AssignTester : System.Web.UI.Page
    {
        String b;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");

                MySqlCommand com2 = new MySqlCommand("select AccountNo,Name from Tester", con);
                con.Open();
                var reader = com2.ExecuteReader();

                GridView3.DataSource = reader;
                GridView3.DataBind();
                // MySqlDataAdapter ad = new MySqlDataAdapter(com2);
                //DataTable table = new DataTable();
                //reader.fi



                //     ListBox1.Items.Add


            }



        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Session["AssignedTester"] = GridView3.SelectedRow.Cells[1].Text;

            // Label1.Text = GridView3.SelectedRow.Cells[1].Text;
            // Label2.Text = GridView3.SelectedRow.Cells[2].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
                /*  MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
                  con2.Open();
                  MySqlCommand com1 = new MySqlCommand("select * from Account where UserName='" + Session["AccountNoDeveloper"].ToString() + "'", con2);
                  var reader = com1.ExecuteReader();
                  while (reader.Read())
                  {
                      b = reader["AccountNo"].ToString();
                  }*/
                //con2.Close();
                MySqlCommand com2 = new MySqlCommand("insert into AssignTester (AssignedBy,AssignedTo,BugId) values('" + Session["DeveloperId"] + "','" + "TST-" + Session["AssignedTester"].ToString() + "','" + Session["BugIdReference"].ToString() + "')", con);
                MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
                MySqlCommand com3 = new MySqlCommand("UPDATE Status SET Status = 'RESOLVED' where BugId= '" + Session["BugIdReference"].ToString() + "'", con3);
                con3.Open();
                con.Open();
                com3.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                //  Response.Redirect("Developer_Panel.aspx");
                Response.Redirect("NewLink_ByDev.aspx");
            }
            catch(Exception ex)
            {
                Label1.Text = "" + ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Developer_Panel.aspx");
        }
    }
}