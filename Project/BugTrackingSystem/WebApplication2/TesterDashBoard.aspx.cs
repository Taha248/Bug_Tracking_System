using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication8
{
    public partial class TesterDashBoard : System.Web.UI.Page
    {

        MySqlConnection connect = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem");
        public static int index = 0;
      protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Session["Login"] .Equals("TesterLoggedIn") )
            // {
            //    Response.Redirect("Login.aspx");
            //}
            //else
          /*  if (Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }*/
         //   txtBox1.Text = Session["User_Name"].ToString();

            ShowTable();

        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selValue = GridView1.SelectedRow.Cells[1].Text;
            index = Convert.ToInt32(selValue.ToString());

        }


        protected void ShowTable()
        {
            connect.Open();
            MySqlDataReader myReader1;
            MySqlCommand comd = connect.CreateCommand();
            //  comd.CommandType = CommandType.Text;
            //Session["testerId"]
            comd.CommandText = "select  b.BugId,b.title, b.priority, b.severity, s.Status from Bug_Report b,AssignTester a, Status s where b.BugId = a.BugId AND s.BugId = a.BugId AND a.AssignedTo = '" + Session["testerId"].ToString() + "'";
            //Solved_Reports Bug_Report
            // comd.ExecuteNonQuery();
            myReader1 = comd.ExecuteReader();
            //   DataTable dt = //new DataTable();
            //  MySqlDataAdapter da = new MySqlDataAdapter();
            // da.Fill(dt);
            //  myReader1.GetTextReader();
            GridView1.DataSource = myReader1;
            GridView1.DataBind();
            connect.Close();

        //    myForm.Visible = false;

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            String BugId = GridView1.SelectedRow.Cells[1].Text;
            Session["BugId"] = BugId;
            Response.Redirect("SubmitSolvedReport.aspx");

            /*      //submit Solved Report
                 myPanel.Visible = false;
                 myForm.Visible = true;
                 Button8.Visible = false;
                 TextBox5.Visible = false;
                 Label6.Visible = false;
                 TextBox6.Visible = false;
                 Label7.Visible = false;
                 TextBox7.Visible = false;
                 Label8.Visible = false;
                 TextBox8.Visible = false;
                 Label9.Visible = false;

                 connect.Open();
                 MySqlCommand comd = connect.CreateCommand();
                 comd.CommandType = CommandType.Text;
                 MySqlDataReader myReader = null;
                 comd.CommandText = "SELECT * FROM Status where BugId = '" + index.ToString() + "'";

                 //   comd.ExecuteNonQuery();
                 myReader = comd.ExecuteReader();
                 while (myReader.Read())
                 {
                     TextBox1.Text = (myReader["BugId"].ToString());
                     TextBox2.Text = (myReader["Status"].ToString());
                     //    TextBox5.Text = (myReader["Detail"].ToString());
                     //    TextBox6.Text = (myReader["Severity"].ToString());
                     //    TextBox7.Text = (myReader["Priority"].ToString());
                     //    TextBox8.Text = (myReader["AddedBy"].ToString());
                 }
                 TextBox1.ReadOnly = true;
                 TextBox2.ReadOnly = true;
                 connect.Close();
  */
        }

        protected void Button2_Click(object sender, EventArgs e)
            {

            Response.Redirect("Profile.aspx");
            /*  myPanel.Visible = false;
              myForm.Visible = true;

              //Edit Profile
              // myPanel.Visible = false;
              //  myForm.Visible = true;
              TextBox3.Visible = false;
              Label4.Visible = false;
              Label5.Visible = false;
              Label9.Visible = false;
              TextBox8.Visible = false;
              TextBox4.Visible = false;
              Button5.Visible = false;
              Label2.Text = "Account No";
              Label3.Text = "Tester ID";
              Label6.Text = "Email";
              Label7.Text = "Name";
              Label8.Text = "DOB";
              connect.Open();
              MySqlCommand comd = connect.CreateCommand();
              comd.CommandType = CommandType.Text;
              MySqlDataReader myReader = null;
              comd.CommandText = "SELECT * FROM Tester";

              //   comd.ExecuteNonQuery();
              myReader = comd.ExecuteReader();
              while (myReader.Read())
              {
                  TextBox1.Text = (myReader["AccountNo"].ToString());
                  TextBox2.Text = (myReader["TesterId"].ToString());
                  TextBox5.Text = (myReader["NAME"].ToString());
                  TextBox6.Text = (myReader["DOB"].ToString());
                  TextBox7.Text = (myReader["Email"].ToString());
              }
              connect.Close();

              */
        }
            /*

            protected void Button3_Click(object sender, EventArgs e)
            {
                //View Profile
                myPanel.Visible = false;
                myForm.Visible = true;
                TextBox3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label9.Visible = false;
                TextBox8.Visible = false;
                TextBox4.Visible = false;
                Button5.Visible = false;
                Label2.Text = "Account No";
                Label3.Text = "Tester ID";
                Label6.Text = "Email";
                Label7.Text = "Name";
                Label8.Text = "DOB";
                TextBox1.ReadOnly = true;
                TextBox2.ReadOnly = true;
                TextBox7.ReadOnly = true;
                TextBox5.ReadOnly = true;
                TextBox6.ReadOnly = true;
                connect.Open();
                MySqlCommand comd = connect.CreateCommand();
                comd.CommandType = CommandType.Text;
                MySqlDataReader myReader = null;
                comd.CommandText = "SELECT * FROM Tester where AccountNo = (Select AccountNo from Account where Username = '" + Session["User_Name"].ToString() + "')";

                //   comd.ExecuteNonQuery();
                myReader = comd.ExecuteReader();
                while (myReader.Read())
                {
                    TextBox1.Text = (myReader["AccountNo"].ToString());
                    TextBox2.Text = (myReader["TesterId"].ToString());
                    TextBox5.Text = (myReader["NAME"].ToString());
                    TextBox6.Text = (myReader["DOB"].ToString());
                    TextBox7.Text = (myReader["Email"].ToString());
                }
                connect.Close();
            }
            */
            protected void Button4_Click(object sender, EventArgs e)
            {

            Session["BugId"] = GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("ViewReport.aspx");
            //View Report

            /*
                            try
                            {
                                if (!GridView1.SelectedRow.Cells.Equals(""))
                                {

                                    myPanel.Visible = false;
                                    TextBox3.Visible = false;
                                    Label4.Visible = false;
                                    Button8.Visible = false;
                                    Button5.Visible = false;
                                    Label5.Visible = false;
                                    TextBox4.Visible = false;
                                    myForm.Visible = true;
                                    connect.Open();
                                    MySqlCommand comd = connect.CreateCommand();
                                    comd.CommandType = CommandType.Text;
                                    MySqlDataReader myReader = null;
                                    comd.CommandText = "SELECT * FROM Bug_Report where BugId = '" + index.ToString() + "'";

                                    //   comd.ExecuteNonQuery();
                                    myReader = comd.ExecuteReader();
                                    while (myReader.Read())
                                    {
                                        TextBox1.Text = (myReader["BugId"].ToString());
                                        TextBox2.Text = (myReader["Title"].ToString());
                                        TextBox5.Text = (myReader["Detail"].ToString());
                                        TextBox6.Text = (myReader["Severity"].ToString());
                                        TextBox7.Text = (myReader["Priority"].ToString());
                                        TextBox8.Text = (myReader["AddedBy"].ToString());
                                    }
                                    TextBox1.ReadOnly = true;
                                    TextBox2.ReadOnly = true;
                                    TextBox7.ReadOnly = true;
                                    TextBox8.ReadOnly = true;
                                    TextBox5.ReadOnly = true;
                                    TextBox6.ReadOnly = true;
                                    connect.Close();
                                }

                            }
                            catch (Exception ex)
                            {

                                Response.Write("<script LANGUAGE='JavaScript' >alert('Please Select any Row from List')</script>");

                            }

                            */

        }
      

        protected void Button5_Click(object sender, EventArgs e)
        {

        Session.Abandon();
        Response.Redirect("Login.aspx");
            /*    ///Form submit Button
              ///


              MySqlCommand comd = connect.CreateCommand();
              comd.CommandType = CommandType.Text;
              comd.CommandText = "INSERT into Solved_Reports (BugId,Comments) VALUES ('" + TextBox1.Text + "','" + TextBox4.Text + "')";
              comd.ExecuteNonQuery();
              connect.Close();
              Response.Redirect("TesterPanel.aspx");*/
          }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["BugId"] = GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("ReassignDeveloper.aspx");
        }

        /*  protected void Button8_Click(object sender, EventArgs e)
        {
            //update profile


            connect.Open();
            MySqlCommand comd = connect.CreateCommand();
            comd.CommandType = CommandType.Text;
            comd.CommandText = "UPDATE Tester SET AccountNo='" + TextBox1.Text + "',TesterId='" + TextBox2.Text + "',NAME='" + TextBox5.Text + "',DOB='" + TextBox6.Text + "',Email='" + TextBox7.Text + "' where AccountNo = 1";
            comd.ExecuteNonQuery();
            connect.Close();
            Response.Redirect("TesterPanel.aspx");

        }*/
    }
}