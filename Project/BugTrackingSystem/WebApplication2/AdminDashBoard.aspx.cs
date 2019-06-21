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
    public partial class AdminDashBoard : System.Web.UI.Page
    {

        MySqlDataAdapter adapt;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Session["Login"].ToString().Equals("AdminLoggedIn") || Session["Login"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    String Query = "SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`";
                    BindData(Query);
                }
            }

            Label1.Text = "" + Session["AdminId"].ToString();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            CheckSelectedItem();

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {
         
        }

        protected override void OnLoad(EventArgs e)
        {
            if (IsPostBack)
            {

                CheckSelectedItem();

            }
            base.OnLoad(e);
        }

        private void CheckSelectedItem()
        {
        if(SearchBox.Text.Equals(""))
        {

            if (DropDownList1.SelectedItem.Text.Equals("New"))
            {
                //  GridView1.DataSource = null;
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& s.status='New';");

            }
            else if (DropDownList1.SelectedItem.Text.Equals("Assigned"))
            {
                //    GridView1.DataSource = null;
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& s.status='Assigned';");


            }
            else if (DropDownList1.SelectedItem.Text.Equals("All"))
            {
                //    GridView1.DataSource = null;
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`;");


            }
            else if (DropDownList1.SelectedItem.Text.Equals("Resolved"))
            {
                //     GridView1.DataSource = null;
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& s.status='Resolved';");


            }

            else if (DropDownList1.SelectedItem.Text.Equals("Closed"))
            {
                //    GridView1.DataSource = null;
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& s.status='Closed';");


            }
            }
            else {
                BindData("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`  ");


            }

        }

        protected override void OnInit(EventArgs e)
        {

            base.OnInit(e);
        }
        private void BindData(String Query)
        {
            //String  AdminId = Session["UserId"].ToString();
            dt = new DataTable();

            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");
            adapt = new MySqlDataAdapter(Query, con);
            //    MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT b.BugId,b.title, b.priority, b.severity, s.Status FROM Bug_Report b, Status s WHERE s.`BugId`= b.`BugId`&& AddedBy = '" + UserId + "'", con);
            con.Open();
            if (dt != null)
                adapt.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell();

                tr.Cells.Add(tc);
                dt.Rows.Add(tr);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

     
        protected void NewReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewReport.aspx");
        }

        protected void AddAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAccount.aspx");
        }

        protected void Assign_Click(object sender, EventArgs e)
        {

            String BugId = GridView1.SelectedRow.Cells[1].Text;
            Session["AssigningAdmin"] = Session["AdminId"].ToString();
            Session["BugId"] = BugId;
            Response.Redirect("AssignDeveloper.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String BugId = GridView1.SelectedRow.Cells[1].Text;
            Session["BugId"] = BugId;
            Response.Redirect("EditReport.aspx");
            Label1.Text = BugId;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");


        }
        protected void Search_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=46.105.105.77;user id=nscommun_taha;password=timein;persistsecurityinfo=True;database=nscommun_BugTrackingSystem;allowuservariables=True");

            adapt = new MySqlDataAdapter("SELECT * FROM  Bug_Report WHERE title LIKE '" + SearchBox.Text + "%' OR title LIKE '%" + SearchBox.Text + "'OR title LIKE '" + SearchBox.Text + "'  OR Detail LIKE '" + SearchBox.Text + "%' OR Detail LIKE '%" + SearchBox.Text + "'OR Detail LIKE '" + SearchBox.Text + "';", con);

            dt = new DataTable();
            con.Open();
            adapt.Fill(dt);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            //   MySqlCommand cmd = new MySqlCommand(,con);





        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
            CheckSelectedItem();
        }

        protected void ViewReport_Click(object sender, EventArgs e)
        {
            Session["BugId"] = GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("ViewReport.aspx");
        }
    }
}