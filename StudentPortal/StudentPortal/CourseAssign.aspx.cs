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
    public partial class CourseAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from StudentInfo where StudentID=@id", con);
            cmd.Parameters.AddWithValue("@id", TextBox2.Text);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["StudentName"].ToString();

            }
            else
            {

            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {

            string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            string a = "abc";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Course(StudentID,SemesterName) values(@StudentID,@SemesterName)", con);
            cmd.Parameters.AddWithValue("@StudentID",TextBox2.Text);
            cmd.Parameters.AddWithValue("@SemesterName", Label1.Text);
           
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}