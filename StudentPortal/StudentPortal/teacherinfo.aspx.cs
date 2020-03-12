using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class teacherinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
                Response.Redirect("Home.aspx");
        }

        protected void Tb12_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Buttonsubmit2_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TeacherInfo(Name,department,HomeTown,Religion,PhoneNumber,teacherID,Password) values(@Name,@department,@HomeTown,@Religion,@phoneNumber,@StudentID,@Password)", con);
           
            cmd.Parameters.AddWithValue("@Name", tb11.Text);
            cmd.Parameters.AddWithValue("@department", Tb12.Text);
            cmd.Parameters.AddWithValue("@HomeTown", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Religion", TextBox3.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", TextBox4.Text);
            cmd.Parameters.AddWithValue("@StudentID", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox6.Text);
            cmd.ExecuteNonQuery();


            con.Close();


        }
    }
}