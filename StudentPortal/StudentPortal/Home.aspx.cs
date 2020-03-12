using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a=DropDownList1.Text;
            if (a=="Student") {
                loginStudent();    
            }
            else if(a=="Teacher")
            {

                loginTeacher();
            }
            else
            {

                loginAdmin();
            }
        }
      
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginStudent()
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from StudentInfo where StudentID=@userName and Password=@pass", con);
            cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                Session["UserName"] = TextBox1.Text;
                L1.Text = "Login Success";
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                L1.Text = "Login Failed";
            }
            con.Close();



        }
        private void loginTeacher()
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from TeacherInfo where teacherID=@userName and Password=@pass", con);
            cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                Session["UserName"] = TextBox1.Text;
                L1.Text = "Login Success";
               Response.Redirect("teacherprofile1.aspx");
            }
            else
            {
                L1.Text = "Login Failed";
            }
            con.Close();
        } 

    
        private void loginAdmin()
        {
            if (TextBox1.Text=="Anik" && TextBox2.Text=="Password")
            {
                Session["UserName"] = "Anik";
                

                Response.Redirect("adminHome.aspx");
            }
            else if (TextBox1.Text == "Saurav" && TextBox2.Text == "Password2")
            {
                Session["UserName"] = "Saurav";
                Response.Redirect("adminHome.aspx");
            }
            Response.Redirect("Home.aspx");
        }
    }
}