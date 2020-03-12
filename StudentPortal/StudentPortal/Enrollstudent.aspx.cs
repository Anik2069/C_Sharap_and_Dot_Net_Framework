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
    public partial class Enrollstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
                Response.Redirect("Home.aspx");
        }

        protected void Buttonsubmit2_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentInfo(ApplicationID,StudentName,department,HomeTown,Religion,StudentID,Password) values(@ApplicationID,@StudentName,@department,@HomeTown,@Religion,@StudentID,@Password)", con);
            cmd.Parameters.AddWithValue("@ApplicationID", Convert.ToInt16(tb11.Text));
            cmd.Parameters.AddWithValue("@StudentName", Tb12.Text);
            cmd.Parameters.AddWithValue("@department", TextBox2.Text);
            cmd.Parameters.AddWithValue("@HomeTown", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Religion", TextBox4.Text);
            cmd.Parameters.AddWithValue("@StudentID", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox6.Text);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("insert into AccountSchema(StudentID,Name,Payable,Due,Paid)values (@StudentID,@Name,@Payable,@Due,@Paid)", con);
            cmd.Parameters.AddWithValue("@StudentID", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Name", Tb12.Text);

            cmd.Parameters.AddWithValue("@Payable", 0);
            cmd.Parameters.AddWithValue("@Due",0);
            cmd.Parameters.AddWithValue("@Paid", 0);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        protected void Tb12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}