using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Threading;

namespace WebApplication8
{
    public partial class Developer_Panel : System.Web.UI.Page
    {
        MySqlDataReader reader3;
        String jk;

        MySqlDataReader reader2;
        String b;
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (jk != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(jk);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(jk);
            }*/
            /*  if (page!=isPostBack) { 
              if (jk != null)
              {
                  Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(jk);
                  Thread.CurrentThread.CurrentUICulture = new CultureInfo(jk);
              }
          }*/
            // Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ur");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("ur");
            /*  MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
              con3.Open();
              MySqlCommand com1 = new MySqlCommand("select * from Account where UserName='" + Session["AccountNoDeveloper"].ToString() + "'", con3);
              var reader = com1.ExecuteReader();
              while (reader.Read())
              {
                  b = reader["AccountNo"].ToString();
              }
              con3.Close();*/
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            //Label1.Text = Session["DeveloperId"].ToString();
            MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");

            // MySqlCommand com2 = new MySqlCommand("select * from Bug_Report" , con);
            MySqlCommand com2 = new MySqlCommand("select Bug_Report.* from Bug_Report inner join  AssignDeveloper  on Bug_Report.BugId = AssignDeveloper.BugId and AssignDeveloper.AssignedTo = '" + Session["DeveloperId"].ToString() + "'", con);
            // Label3.Text = b;
            //MySqlCommand com3 = new MySqlCommand("select Status.Status from Status inner join Bug_Report  on Status.BugId = Bug_Report.BugId and Bug_Report.BugId = '" + "Dev-" + b + "'", con2);
            MySqlCommand com3 = new MySqlCommand("select Status.Status from Status inner join AssignDeveloper  on Status.BugId = AssignDeveloper.BugId and AssignDeveloper.AssignedTo = '" + Session["DeveloperId"].ToString() + "'", con2);

            con.Open();
            con2.Open();
            reader3 = com2.ExecuteReader();
            reader2 = com3.ExecuteReader();
            //  Label3.Text = Session["AccountNoDeveloper"].ToString();


            DataTable dt = new DataTable();
            dt.Columns.Add("BugId");
            dt.Columns.Add("Title");
            dt.Columns.Add("Serverity");
            dt.Columns.Add("Priority");
            dt.Columns.Add("Status");


            while (reader3.Read() && reader2.Read())
            {
                DataRow row = dt.NewRow();
                row["BugId"] = reader3["BugId"];
                row["Title"] = reader3["Title"];
                row["Serverity"] = reader3["Severity"];
                row["Priority"] = reader3["Priority"];
                row["Status"] = reader2["Status"];
                dt.Rows.Add(row);
            }


            GridView3.DataSource = dt;

            GridView3.DataBind();

            con2.Close();
            con.Close();


        }

    

        protected override void InitializeCulture()
        {
            if (Session["lang"] != null)
            {
                string bh = Session["lang"].ToString();
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(bh);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(bh);
            }
            base.InitializeCulture();
        }

   /*     protected override void OnPreInit(EventArgs e)
        {
         
            if (DropDownList15 != null)
            {
                String yy = DropDownList15.SelectedValue.ToString();
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(yy);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(yy);
            }
            base.OnPreInit(e);
        }*/
        protected void DropDownList15_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(jk);
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(jk);

            // jk = DropDownList15.SelectedItem.Text.ToString();

            /*  if (jk == "English")
              {
                  Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                  Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
              }
              else
              {
                  Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ur");
                  Thread.CurrentThread.CurrentUICulture = new CultureInfo("ur");
              }*/
        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            // Label1.Text = GridView3.SelectedRow.Cells[1].Text;
            // Label2.Text = GridView3.SelectedRow.Cells[2].Text;

            Session["BugIdReference"] = GridView3.SelectedRow.Cells[1].Text;
            Session["BugIdReference2"] = GridView3.SelectedRow.Cells[2].Text;

            Session["BugId"] = GridView3.SelectedRow.Cells[1].Text;

            /* Session["Edit1"] = GridView3.SelectedRow.Cells[1].Text;
             Session["Edit2"] = GridView3.SelectedRow.Cells[2].Text;
             Session["Edit3"] = GridView3.SelectedRow.Cells[3].Text;
           //  Session["Edit4"] = GridView3.SelectedRow.Cells[4].Text;
            // Session["Edit5"] = GridView3.SelectedRow.Cells[5].Text;
            // Session["Edit6"] = GridView3.SelectedRow.Cells[6].Text;*/
        }

        /*  protected void Button2_Click(object sender, EventArgs e)
          {

          }

          protected void Button1_Click(object sender, EventArgs e)
          {

          } */



        protected void Button4_Click(object sender, EventArgs e)
        {

            Response.Redirect("Extended_Report.aspx");

        }


        /*
               protected void Button7_Click(object sender, EventArgs e)
               {
                 Session["Edit1"] = GridView3.SelectedRow.Cells[1].Text;
                   Session["Edit2"] = GridView3.SelectedRow.Cells[2].Text;
                   Session["Edit3"] = GridView3.SelectedRow.Cells[3].Text;
                   Session["Edit4"] = GridView3.SelectedRow.Cells[4].Text;
                   Session["Edit5"] = GridView3.SelectedRow.Cells[5].Text;
                   Session["Edit6"] = GridView3.SelectedRow.Cells[6].Text;


               } */

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignTester.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReAssignDev.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewReport.aspx");  // Detail(s)
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}