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
    public partial class ShowDetails_Dev : System.Web.UI.Page
    {
        /* MySqlDataReader reader;
        MySqlDataReader reader2;*/
        String h;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");


                //TextBox4.Text = Session["Edit4"].ToString();
                // TextBox5.Text = Session["Edit5"].ToString();
                //TextBox6.Text = Session["Edit6"].ToString();



                MySqlCommand com2 = new MySqlCommand("select Bug_Report.*,Status.Status from Bug_Report,Status where Status.BugId = Bug_Report.BugId and Bug_Report.BugId = '" + Session["BugIdReference"].ToString() + "' ", con);

                //MySqlCommand com3 = new MySqlCommand("select Status.Status from Status inner join Bug_Report  on Status.BugId = Bug_Report.BugId  and Bug_Report.Title = '" + Session["BugIdReference2"].ToString() + "' ", con2);


                MySqlDataAdapter sda = new MySqlDataAdapter(com2);

                DataTable dt2 = new DataTable();
                sda.Fill(dt2);

                con.Open();
                DetailsView1.DataSource = dt2;
                DetailsView1.DataBind();
                con.Close();

                /*  reader = com2.ExecuteReader();
                 // reader2 = com3.ExecuteReader();

                  while (reader.Read()&&reader2.Read())
                  {
                      Label2.Text = reader["Title"].ToString();
                      TextBox1.Text = reader["Title"].ToString();
                      TextBox2.Text = reader["Detail"].ToString();
                      TextBox3.Text = reader["Severity"].ToString();
                      TextBox4.Text = reader["Priority"].ToString();
                      TextBox5.Text = reader["ProjectFile"].ToString();
                      TextBox6.Text = reader2["Status"].ToString();

                  }



                  DataTable dt = new DataTable();
                  dt.Columns.Add("BugId");
                  dt.Columns.Add("Title");
                  dt.Columns.Add("Serverity");
                  dt.Columns.Add("Priority");
                  dt.Columns.Add("Status");


                  while (reader.Read() && reader2.Read())
                  {
                      DataRow row = dt.NewRow();
                      row["BugId"] = reader["BugId"];
                      row["Title"] = reader["Title"];
                      row["Serverity"] = reader["Severity"];
                      row["Priority"] = reader["Priority"];
                      row["Status"] = reader2["Status"];



                      dt.Rows.Add(row);
                  }

                //  DetailsView1.DataSource = dt;
                //  DetailsView1.DataBind();

      */
            }
            catch (Exception ex)
            {

            }

        }



        /*  protected void TextBox6_TextChanged(object sender, EventArgs e)
          {

          }*/

        /*protected void Button2_Click(object sender, EventArgs e)
        {
            
           
           // MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
           // con2.Open();

            MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            con3.Open();
            MySqlCommand com3 = new MySqlCommand("select * from Bug_Report where Title = '" + Session["BugIdReference2"].ToString() + "' ", con3);
            var reader3 = com3.ExecuteReader();

            while (reader3.Read())
            {
                h = reader3["BugId"].ToString();
            }

            Label1.Text = h;
            con3.Close();
            MySqlConnection con2 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            con2.Open();
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
            con.Open();
            MySqlCommand com2 = new MySqlCommand("Update Bug_Report  Set Title ='" + TextBox1.Text + "',Detail ='" + TextBox2.Text + "',Severity = '" + TextBox3.Text + "',Priority='"+TextBox4.Text+"',ProjectFile='"+TextBox5.Text+"'  where Title = '" + Session["BugIdReference2"].ToString() + "' ", con2);
            MySqlCommand com = new MySqlCommand("UPDATE Status Set Status ='"+TextBox6.Text+"' WHERE BugId = '"+h+"' ", con);
          
     



            com.ExecuteNonQuery();
            //com2.ExecuteNonQuery();
           
            con.Close();
        }*/

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Developer_Panel.aspx");
        }

        /* protected void Button3_Click(object sender, EventArgs e)
         {
            MySqlConnection con3 = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;database=nscommun_BugTrackingSystem;persistsecurityinfo=True");
             con3.Open();
             MySqlCommand com3 = new MySqlCommand("select * from Bug_Report where Title = '" + Session["BugIdReference2"].ToString() + "' ", con3);
             var reader3 = com3.ExecuteReader();

             while (reader3.Read())
             {
                 h = reader3["BugId"].ToString();
             }

             Label1.Text = h;


         } */
    }
}