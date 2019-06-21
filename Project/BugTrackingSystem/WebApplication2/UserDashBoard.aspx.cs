using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Globalization;

namespace WebApplication8
{
    public partial class UserDashBoard : System.Web.UI.Page
    {
        DataTable dt;
        String UserId;
        MySqlDataAdapter adapt;
        protected override void OnPreLoad(EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                BindData();
            }
        }

        private void BindData()
        {
            UserId = Session["UserId"].ToString();

            
            dt = new DataTable();

            TableRow tr = new TableRow();
            TableCell tc = new TableCell();
            try
            {
                MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

                if(DropDownList1.SelectedIndex==0)
                adapt = new MySqlDataAdapter("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& AddedBy = '" + UserId + "'", con);
                else
                    adapt = new MySqlDataAdapter("SELECT s.* FROM Solved_Reports s , Bug_Report b WHERE s.`BugId`=b.`BugId` AND AddedBy='" + UserId + "'", con);

                con.Open();

                //       if (dt.Rows.Count > 0)
                // {
                //      adapt.Fill(dt);
                //            GridView1.DataSource = dt;
                //      GridView1.DataBind();
                //       }
                //    else
                //      {
                // dt.Columns.Add("PayScale", typeof(string));
                //   dt.Rows.Add(tr);
                //     DataRow dr = dt.NewRow(); 
                //    dr[2] = "EMPTY";
                //   dt.Rows.Add(dr);
                adapt.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    NoBugReport.Visible = true;
                }

                con.Close();

                //    }
            }
            catch (Exception ex)
            {
              //  Label1.Text = "FAILD " + ex.Message + Session["UserId"].ToString();
            }
        }


      

        protected void Button2_Click(object sender, EventArgs e)
        {
              String BugId = GridView1.SelectedRow.Cells[1].Text;
                Session["BugId"] = BugId;
            Response.Redirect("EditReport.aspx");
            //Label1.Text = BugId;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void NewReport_Click(object sender, EventArgs e)
        {
            //Label1.Text = "CLICKED";
            Response.Redirect("NewReport.aspx");
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

            adapt = new MySqlDataAdapter("SELECT * FROM  Bug_Report WHERE title LIKE '" + SearchBox.Text + "%'  AND AddedBy='" + Session["UserId"].ToString() + "' OR title LIKE '%" + SearchBox.Text + "' AND AddedBy='" + Session["UserId"].ToString() + "'  OR title LIKE '" + SearchBox.Text + "'  AND AddedBy='" + Session["UserId"].ToString() + "'  OR Detail LIKE '" + SearchBox.Text + "%'  AND AddedBy='" + Session["UserId"].ToString() + "' OR Detail LIKE '%" + SearchBox.Text + "'  AND AddedBy='" + Session["UserId"].ToString() + "' OR Detail LIKE '" + SearchBox.Text + "' AND AddedBy='" + Session["UserId"].ToString() + "';", con);

            dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["BugId"] = GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("ViewReport.aspx");
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
    }
}